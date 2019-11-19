using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CopAPI.Models
{
    public class actor
    {
        [Key]
        public int act_id { get; set;}
        public string act_fname { get; set; }
        public string act_lname { get; set; }
        public string act_gender { get; set; } 
    }
}