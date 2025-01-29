namespace DepositReport.Domain.Entities
{
    public class Files
    {
        public int FileID { get; set; } 
        public int FileTypeID { get; set; }
        public string FileName { get; set; }
        public string FullFileNameAndPath { get; set; }
        public int RunID { get; set; }
        public DateTime DateAdded { get; set; }
        public int TotalReadLines { get; set; }
        public virtual FileTypes FileTypes { get; set; }
        public virtual ICollection<ACHD> Achds { get; set; }   
        public virtual ICollection<ACHT> Achts { get; set; }
    }
}
