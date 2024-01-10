using Microsoft.JSInterop;

namespace Cw.Data;

public class Utils
{
    public static async Task setAlert(IJSRuntime js, String alertClass, String alertMsg)
    {
        await js.InvokeVoidAsync("setAlert", alertClass, alertMsg);
    }
}