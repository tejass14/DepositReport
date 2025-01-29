namespace DepositReport.Domain.Entities
{
    public class DepositTransactionTypes
    {
        public int DepositTransactionTypeID { get; set; }
        public string DepositTransactionTypeName { get; set; }

        public ICollection<DepositTransactions> DepositTransactions { get; set; }
    }
}
