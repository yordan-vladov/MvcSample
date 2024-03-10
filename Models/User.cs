using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    public string? Password { get; set; }
}