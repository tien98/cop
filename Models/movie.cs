using System;
using System.ComponentModel.DataAnnotations;
namespace CopAPI.Models
{
    public class movie
    {
        [Key]
        public int mov_id { get; set;}
        public string mov_title { get; set; }
        public int mov_year { get; set; }
        public int mov_time { get; set; }
        public string mov_lang { get; set; } 

        [DataType(DataType.Date)]
        public DateTime mov_dt_rel { get; set; }
        // public  mov_dt_rel { get; set;} 
        public string mov_rel_country { get; set; }

    }
}