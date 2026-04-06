namespace EventEase.Services;

public class SessionStateService
{
    public bool IsLoggedIn { get; private set; }
    public string CurrentUserName { get; private set; } = string.Empty;

    public event Action? StateChanged;

    public void Login(string userName)
    {
        CurrentUserName = userName;
        IsLoggedIn = true;
        NotifyStateChanged();
    }

    public void Logout()
    {
        CurrentUserName = string.Empty;
        IsLoggedIn = false;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => StateChanged?.Invoke();
}
