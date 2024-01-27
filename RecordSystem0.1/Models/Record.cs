namespace RecordSystem0._1.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string AssetName { get; set; }
        public string Data { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
    }

}
