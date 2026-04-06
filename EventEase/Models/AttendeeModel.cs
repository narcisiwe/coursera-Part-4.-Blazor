namespace EventEase.Models;

public class AttendeeModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string EventTitle { get; set; } = string.Empty;
    public bool CheckedIn { get; set; }
}
