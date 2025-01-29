namespace DepositReport.Core.Services
{
    public class DepositReportService
    {
        //private readonly DepositReportContext _context;

        //public DepositReportService(DepositReportContext _context)
        //{

        //}
        //public void GenerateReport()
        //{
        //    var depositReports = _context.DepositReports
        //.FromSqlRaw("SELECT * FROM DepositReport WHERE DepositDate = {0}", date)
        //.ToList();

        //    // Log Action 
        //    foreach (var depositReport in depositReports)
        //    {
        //        var ccMIDs = depositReport.CCMIDs;

        //        var reportDepositsCC = _context.Database
        //            .SqlQueryRaw<DepositReport>("SELECT * FROM ReportDeposits_CC WHERE DepositDate = {0} AND DepositTypeID = 3", date);

        //        foreach (var reportDepositCC in reportDepositsCC)
        //        {

        //        }

        //    }
        //}
    }
}
