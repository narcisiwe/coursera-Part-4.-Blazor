using EventEase.Models;

namespace EventEase.Services;

public class AttendanceService
{
    public List<AttendeeModel> Attendees { get; } = [];

    public void RegisterAttendance(string eventTitle, string fullName, string email)
    {
        Attendees.Add(new AttendeeModel
        {
            EventTitle = eventTitle,
            FullName = fullName,
            Email = email,
            CheckedIn = false
        });
    }

    public void ToggleCheckIn(Guid id)
    {
        var attendee = Attendees.FirstOrDefault(a => a.Id == id);
        if (attendee is not null)
        {
            attendee.CheckedIn = !attendee.CheckedIn;
        }
    }

    public void Remove(Guid id)
    {
        var attendee = Attendees.FirstOrDefault(a => a.Id == id);
        if (attendee is not null)
        {
            Attendees.Remove(attendee);
        }
    }
}
