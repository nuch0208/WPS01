using System.ComponentModel.DataAnnotations;

namespace WPS.Model
{
    public class Department
    {
        [Key]
        public int Opd_id { get; set; } 
        public string Opd_name  { get; set; }
        public string Departments { get; set; }
    }  
}