namespace DIYtoMvc.Models;
//This is the model for the leaders that gets print out on about page. 
public class LeadersModel
{
    public LeadersModel(){}
    public LeadersModel(string name, string email, string phoneNumber)
    {
        this.Name = name;
        this.Email = email;
        this.PhoneNumber = phoneNumber;
    }

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }




}