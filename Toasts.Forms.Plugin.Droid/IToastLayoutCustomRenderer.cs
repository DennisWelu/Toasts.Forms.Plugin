﻿using Android.App;
using Android.Views;

namespace Toasts
{
    public interface IToastLayoutCustomRenderer
    {
        View Render(Activity activity, ToastNotificationType type, string title, string description, object context);
    }
}
