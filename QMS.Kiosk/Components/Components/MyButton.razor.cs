using Microsoft.AspNetCore.Components;

namespace QMS.Kiosk.Components.Components
{
    public partial class MyButton
    {
        [Parameter]
        public string Text { get; set; } = "Click Me";
        
        [Parameter]
        public EventCallback OnClick { get; set; }

        [Parameter]
        public string Variant { get; set; } = "Primary";

        [Parameter]
        public string Size { get; set; } = "md";
    }
}
