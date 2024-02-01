using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RecordSystem0._1.Models
{
    public class Record  //This class is from god
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string AssetName { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public DateTime StartPeriod { get; set; }

        [Required]
        public DateTime EndPeriod { get; set; }

        [Required]
        public DateTime UpdatedTime { get; set; }

        [Required]
        public string UpdatedBy { get; set; }
    }

}
