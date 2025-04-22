using Microsoft.AspNetCore.Components;
namespace PruebaBlazor.Shared.Components
{
    public partial class ToastComponent : ComponentBase
    {
        private bool ShowMessage { get; set; } = false;
        private string MessageContent { get; set; } = string.Empty;
        private string MessageTitle { get; set; } = string.Empty;
        private string MessageType { get; set; } = "info"; // default to info
        public int DismissAfter { get; set; } = 3;

        private string MessageTypeClass => MessageType switch
        {
            "exito" => "bg-success text-white",
            "error" => "bg-danger text-white",
            "alert" => "bg-warning",
            "cuidado" => "bg-warning",
            "info" => "bg-info text-dark",
            _ => "bg-secondary text-white"
        };

        private string GetHeaderClass() => MessageType switch
        {
            "exito" => "bg-success text-white",
            "error" => "bg-danger text-white",
            "alert" => "bg-warning",
            "cuidado" => "bg-warning",
            "info" => "bg-info text-dark",
            _ => "bg-secondary text-white"
        };

        protected override async Task OnInitializedAsync()
        {
            ToastService.OnShow += ShowToast;
            ToastService.OnHide += HideMessage;
        }

        private async void ShowToast(string message, string type, int dismissAfter)
        {
            MessageContent = message;
            MessageType = type;

            // Establecer el título según el tipo de operación
            MessageTitle = type switch
            {
                "exito" => "Registro Guardado",
                "error" => "Error",
                "cuidado" => "Advertencia",
                "alert" => "Alerta",
                "info" => "Información",
                _ => "Notificación"
            };

            ShowMessage = true;
            await InvokeAsync(StateHasChanged); // Ensure the UI updates

            if (dismissAfter > 0)
            {
                await Task.Delay(dismissAfter * 1000);
                HideMessage();
            }
        }

        private void HideMessage()
        {
            ShowMessage = false;
            InvokeAsync(StateHasChanged); // Ensure the UI updates
        }

        public void Dispose()
        {
            ToastService.OnShow -= ShowToast;
            ToastService.OnHide -= HideMessage;
        }
    }
}