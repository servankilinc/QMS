using System.Timers;

namespace QMS.MainDisplay.State;

public class GlobalState
{
    public List<string> QueueList { get; set { field = value; NotifyStateChanged(); } } = new();
    public string? ActiveItem { get; set { field = value; NotifyStateChanged(); } }
    private System.Timers.Timer? _timer;
    public GlobalState()
    {
        _timer = new System.Timers.Timer(5000);
        _timer.Elapsed += OnTimerTick;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }
    private void OnTimerTick(object? sender, ElapsedEventArgs e)
    {
        AddToQueueList($"Auto Item - {DateTime.Now:HH:mm:ss}");
    }

    public void AddToQueueList(string item)
    {
        QueueList.Add(item);
        NotifyStateChanged();
    }

    public void SelectActiveItem(string item)
    {
        ActiveItem = item;
        NotifyStateChanged();
    }
    public event Action? OnStateChanged;
    public void NotifyStateChanged() => OnStateChanged?.Invoke();
}