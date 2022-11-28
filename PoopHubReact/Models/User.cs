using System.Collections;

namespace PoopHub.Models;

public class User
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public long Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email {
        get;
        set;
    }
    public List<Toilet> CreatedToilets { get; set; }
    public int Role { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public User()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {

    }



}