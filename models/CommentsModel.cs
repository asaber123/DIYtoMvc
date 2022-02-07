namespace DIYtoMvc.Models;
using System.ComponentModel.DataAnnotations;


//This is the model for the comment form
public class CommmentsModel{
    public CommmentsModel(){
    }
    public CommmentsModel( string name, string comment, string theme, string member, string age){
        this.Name = name;
        this.Comment = comment;
        this.Theme = theme;
        this.Member = member;
        this.Age = age;

    }
    //Adding validation to the form. This field is required to the data to be stored. Error messages get displayed to the user
    [Required(ErrorMessage ="You must enter a name")]
    public string? Name { get; set; }
    //Adding validation to the form. This field is required to the data to be stored. Error messages get displayed to the user
    [Required(ErrorMessage ="The comment field is empty..")]   
    [MaxLength(50)] 
    public string? Comment { get; set; }
    //Adding validation to the form. This field is required to the data to be stored. Error messages get displayed to the user
    [Required(ErrorMessage ="Please enter a field")]    
    public string? Theme { get; set; }

    public string? Age { get; set;}

    public string? Member { get; set; }



}
