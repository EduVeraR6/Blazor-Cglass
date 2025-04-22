namespace PruebaBlazor.Services
{
    public class ToastService
    {
        public event Action<string, string, int> OnShow;
        public event Action OnHide;

        public void ShowToast(string message, string type, int dismissAfter = 3)
        {
            OnShow?.Invoke(message, type, dismissAfter);
        }

        public void HideToast()
        {
            OnHide?.Invoke();
        }


        public void ShowSuccess(string message, int dismissAfter = 3) => ShowToast(message, "exito", dismissAfter);
        public void ShowError(string message, int dismissAfter = 3) => ShowToast(message, "error", dismissAfter);
        public void ShowWarning(string message, int dismissAfter = 3) => ShowToast(message, "cuidado", dismissAfter);
        public void ShowInfo(string message, int dismissAfter = 3) => ShowToast(message, "info", dismissAfter);
        public void ShowAlert(string message, int dismissAfter = 3) => ShowToast(message, "alert", dismissAfter);
    }
}
