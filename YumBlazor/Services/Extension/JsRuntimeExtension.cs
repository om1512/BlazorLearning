using Microsoft.JSInterop;

namespace YumBlazor.Services.Extension
{
    public static class JsRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime iJsRuntime, string message)
        {
            await iJsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime iJsRuntime, string message)
        {
            await iJsRuntime.InvokeVoidAsync("showToastr", "error", message);
        }
    }
}
