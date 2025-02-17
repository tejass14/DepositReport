namespace DepositReport.Core.DTOs
{
    public class DepositRequest
    {
        // The date for which the deposits are to be fetched
        public DateTime Date { get; set; }

        // Optional: Add more properties if you need a date range or other filtering criteria
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public DepositRequest(DateTime date)
        {
            Date = date;
        }

        public DepositRequest(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}