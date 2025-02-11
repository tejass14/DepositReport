namespace DepositReport.Domain.Entities
{
    public class Files
    {
        public long FileId { get; set; } 
        public byte FileTypeId { get; set; }
        public string FileName { get; set; }
        public string FullFileNameAndPath { get; set; }
        public Guid RunId { get; set; }
        public DateTime DateAdded { get; set; }
        public int TotalReadLines { get; set; }
        public virtual FileTypes FileTypes { get; set; }
        public virtual ICollection<Achd> Achds { get; set; }   
        public virtual ICollection<Acht> Achts { get; set; }
        public virtual ICollection<Ca> Ca { get; set; }
    }
}
