namespace MarksApi.Data.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;   // "Teacher" or "Student"
    public int? StudentId { get; set; }                // set only for Student users

    public Student? Student { get; set; }
}