using QMS.MainDisplay.State;

namespace QMS.MainDisplay.Sevices;

public class LiveQueueService : ILiveQueueService
{
    private readonly GlobalState _globalState;
    public LiveQueueService(GlobalState globalState)
    {
        _globalState = globalState;
    }


    public void AddQueue(string queue)
    {
        _globalState.AddToQueueList(queue);
    }
}