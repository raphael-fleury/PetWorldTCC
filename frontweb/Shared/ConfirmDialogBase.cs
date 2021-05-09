using System;
using Microsoft.AspNetCore.Components;

namespace PetWorldWeb.Shared
{
    public class ConfirmDialogBase : DialogBase
    {
        private Action confirmed;

        public string ConfirmText { get; set; } = "Confirm";
        public string CancelText { get; set; } = "Cancel";

        public event Action Confirmed
        {
            add { confirmed += value; }
            remove { confirmed -= value; }
        }

        public void Confirm()
        {
            confirmed?.Invoke();
            Hide();
        }

        public void Cancel() => Hide();

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }
    }
}