using System.ComponentModel.DataAnnotations;

namespace WPS.Model

{
public class Person

{
    [Key]
    public int Id { get; set; }  
    public string Cid { get; set; }         
    public string  HN { get; set; } 
    public string Name { get; set; }
    public string Surename  { get; set; }   
}

}

