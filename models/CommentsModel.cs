namespace DIYtoMvc.Models;
using System.ComponentModel.DataAnnotations;

public class CommmentsModel{
    public int? Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]    
    public string? Comment { get; set; }

    [Required]    
    public string? Theme { get; set; }

    [Required]    
    public string? Age { get; set; }
    //public date? Date { get; set; }

    public CommmentsModel(){

    }
}
