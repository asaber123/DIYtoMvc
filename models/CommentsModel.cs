namespace DIYtoMvc.Models;
using System.ComponentModel.DataAnnotations;


public class CommmentsModel{
    public CommmentsModel(){
    }
    public CommmentsModel( string name, string comment, string theme){
        this.Name = name;
        this.Comment = comment;
        this.Theme = theme;
    }

    [Required(ErrorMessage ="You must enter a name")]
    public string? Name { get; set; }

    [Required(ErrorMessage ="The comment field is empty..")]   
    [MaxLength(50)] 
    public string? Comment { get; set; }

    [Required(ErrorMessage ="Please enter a field")]    
    public string? Theme { get; set; }
    
    // public class ViewModelComment{
    //     public IEnumerable<CommmentsModel> CommentList{ get; set;}
    // }


}
