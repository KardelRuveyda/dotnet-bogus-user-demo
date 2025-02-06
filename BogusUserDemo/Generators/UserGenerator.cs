using Bogus;
using BogusUserDemo;

public class UserGenerator : Faker<User>
{
    public UserGenerator()
    {
        RuleFor(u => u.Id, f => f.Random.Guid());
        RuleFor(u => u.FirstName, f => f.Name.FirstName());
        RuleFor(u => u.LastName, f => f.Name.LastName());
        RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName));
        RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());
        RuleFor(u => u.BirthDate, f => f.Date.PastDateOnly(30));
        RuleFor(u => u.Address, f => f.Address.FullAddress());
    }
}