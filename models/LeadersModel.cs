namespace DIYtoMvc.Models;
public class LeadersModel
{
    //constructor that runns everytime there is an instance ofthe class. 
    public LeadersModel(){}
    //Constructor that can fill in values from a course
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