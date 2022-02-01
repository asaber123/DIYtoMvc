namespace DIYtoMvc.Models;
using System.ComponentModel.DataAnnotations;


public class CommmentsModel{

    
    [Required] 
    public int?  Id { get; set; }

    [Required(ErrorMessage ="You must enter a name")]
    public string? Name { get; set; }

    [Required(ErrorMessage ="The comment field is empty..")]   
    [MaxLength(50)] 
    public string? Comment { get; set; }

    [Required(ErrorMessage ="Please enter a field")]    
    public string? Theme { get; set; }

    public CommmentsModel(){

    }
}
