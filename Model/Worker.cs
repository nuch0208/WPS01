using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace WPS.Model
{
    public class Worker
    {
         [Key]
        public int Id { get; set; }
        public int Person_id { get; set; }  
        public int Auth_id { get; set; }    
        public DateTime Date { get; set; }
        public DateTime Start { get; set; } 
        public DateTime Finish { get; set; }    
        public string Department { get; set; }  
        public string Mat_type  { get; set; } 

    }
}