using Microsoft.AspNetCore.Components;
using QMS.MainDisplay.Sevices;
using QMS.MainDisplay.State;

namespace QMS.MainDisplay.Components.Pages
{
    public partial class Home:IDisposable
    {
        [Inject] public GlobalState GlobalState { get; set; } = default!;
        [Inject] public ILiveQueueService LiveQueueService { get; set; } = default!;

        private Action? _stateChangedHandler;
        protected override void OnInitialized()
        {
            _stateChangedHandler = () => InvokeAsync(StateHasChanged);
            GlobalState.OnStateChanged += _stateChangedHandler;
            //GlobalState.OnStateChanged += StateHasChanged;
            base.OnInitialized();
        }

        void InsertNewQueue()
        {
            GlobalState.AddToQueueList("X");
        }

        public void Dispose()
        {
            _stateChangedHandler = () => InvokeAsync(StateHasChanged);
            GlobalState.OnStateChanged += _stateChangedHandler;
            //GlobalState.OnStateChanged -= StateHasChanged;
        }
    }
}