namespace DepositReport.Domain.Entities
{
    public class FileTypes
    {
        public byte FileTypeID { get; set; }
        public string FileTypeName { get; set; }
        public string SourcePath { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Files> Files { get; set; }
    }
}
