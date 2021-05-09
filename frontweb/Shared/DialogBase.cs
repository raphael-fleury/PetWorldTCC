using Microsoft.AspNetCore.Components;

namespace PetWorldWeb.Shared
{
    public class DialogBase : ComponentBase
    {
        public string Title { get; set; } = "Title";
        public string Body { get; set; } = "Body";

        protected bool Active { get; private set; }

        public void Show()
        {
            Active = true;
            StateHasChanged();
        }

        public void Hide()
        {
            Active = false;
            StateHasChanged();
        }
    }
}