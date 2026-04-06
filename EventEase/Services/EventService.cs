using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    public List<EventModel> Events { get; } =
    [
        new()
        {
            Title = "Blazor Community Meetup",
            Location = "Riga Tech Hub",
            Description = "A local meetup for .NET and Blazor developers.",
            Date = DateTime.Today.AddDays(7),
            AvailableSeats = 50
        },
        new()
        {
            Title = "UI Design for Event Apps",
            Location = "Online",
            Description = "A virtual workshop about user-friendly event app interfaces.",
            Date = DateTime.Today.AddDays(12),
            AvailableSeats = 80
        },
        new()
        {
            Title = "Startup Networking Night",
            Location = "Jurmala Conference Center",
            Description = "An evening for founders, developers, and product teams.",
            Date = DateTime.Today.AddDays(18),
            AvailableSeats = 35
        }
    ];

    public EventModel? GetById(Guid id) => Events.FirstOrDefault(e => e.Id == id);

    public void AddEvent(EventModel eventModel)
    {
        Events.Add(eventModel);
    }

    public void DeleteEvent(Guid id)
    {
        var item = GetById(id);
        if (item is not null)
        {
            Events.Remove(item);
        }
    }
}
