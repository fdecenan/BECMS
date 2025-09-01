using BECMS.Reports.Models;
using BECMS.Reports.ReportPrint;
using BECMS.Repository;
using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.Design.Class;
using FerPROJ.Design.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECMS.Reports {
    public class TransactionReport {
        private delegate Task<ReportDocument> MyFunction(Guid id);
        private Dictionary<ReportList, MyFunction> reportFunctions;
        public TransactionReport() {
            reportFunctions = new Dictionary<ReportList, MyFunction>();
            reportFunctions.Add(ReportList.PatientPrescriptionReport, PatientPrescriptionReport);
        }

        public enum ReportList {
            PatientPrescriptionReport,
        }
        private async Task<ReportDocument> PatientPrescriptionReport(Guid id) {
            using (var repo = new PatientRepository()) {
                var rpt = new PatientPrescriptionPrint();
                var entity = await repo.GetByIdAsync(id);
                var model = entity.ToDestination<PatientPrescriptionModel>();
                var entityDataTable = await model.ToDataTableAsync();
                rpt.SetDataSource(entityDataTable);
                return rpt;
            }
        }
        private async Task<ReportDocument> GetReportAsync(ReportList reportType, Guid id) {
            var rpt = await reportFunctions[reportType](id);
            if (rpt != null) {
                return rpt;
            }
            return null;
        }
        public async Task PreviewReportAsync(ReportList reportType, Guid id) {
            await FrmSplasherLoading.ShowSplashAsync();

            // Define the logic for the background task
            Func<BackgroundWorker, DoWorkEventArgs, Task> doWorkAsync = async (worker, e) => {
                int currentProgress = 0;
                const int delayDuration = 500; // Delay duration between progress updates (1 second)

                // Start the task to get the report asynchronously
                var reportTask = GetReportAsync(reportType, id);

                // Simulate a running progress until the task is completed
                while (currentProgress < 100) {

                    // Check if the task is completed
                    if (reportTask.IsCompleted) {
                        currentProgress = 100; // Ensure the progress is set to 100% when task is complete
                        break;
                    }

                    // Increment the progress
                    currentProgress++;

                    // Report progress to the UI thread
                    worker.ReportProgress(currentProgress);

                    // Wait for the specified delay before updating progress
                    await Task.Delay(delayDuration);
                }

                // Once the task is done, get the report
                ReportDocument report = await reportTask;

                // Set the result
                e.Result = report;
            };

            // Define the logic for updating the UI with progress
            Func<ProgressChangedEventArgs, Task> progressChangedAsync = async (e) => {
                int progress = e.ProgressPercentage;
                FrmSplasherLoading.SetLoadingText(progress);
                await Task.CompletedTask;
            };

            // Define the logic to handle task completion
            Func<RunWorkerCompletedEventArgs, Task> runWorkerCompletedAsync = async (e) => {
                await Task.Delay(1000);
                FrmSplasherLoading.SetLoadingText(100);
                var report = (ReportDocument)e.Result;
                if (report != null) {
                    await CBaseReportLayer.GenerateReport(report);
                    FrmSplasherLoading.CloseSplash();
                }
            };

            // Call the extension method to run the background task with progress reporting
            await CBackgroundTaskManager.RunWithProgressAsync(doWorkAsync, progressChangedAsync, runWorkerCompletedAsync);
        }
    }
}
