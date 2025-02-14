using System.ComponentModel.DataAnnotations;

namespace DepositReport.Domain.Entities
{
    public class DepositTransactionTypes
    {
        [Key]
        public byte DepositTransactionTypeId { get; set; }
        public string DepositTransactionTypeName { get; set; }

        public ICollection<DepositTransactions> DepositTransactions { get; set; }
    }
}
