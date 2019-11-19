using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CopAPI.Models
{
    public class movie_cast
    {
        [Key]
        public int act_id { get; set; }
        public string role { get; set; } 
        
        [ForeignKey("mov_id")]
        public int mov_id { get; set; }
    }
}