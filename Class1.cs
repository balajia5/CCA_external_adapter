using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using System.Threading.Tasks;
using Microsoft.Uii.Csr;
using Microsoft.Uii.Csr.Win32Api;

namespace extadap
{



    public class Class1:ApplicationAdapter
    {
        int len;
        public string strin;
        const int WM_GETTEXT = 0x000D;
        StringBuilder sb = new StringBuilder(100);
        IntPtr hwnd;
        public override bool NotifyContextChange(Context context)
        {
            string lpwindowname = "WindowsForms10.Window.8.app.0.1948c4c_r11_ad1";
            IntPtr temp = Win32API.FindWindow(lpwindowname, null);
            IntPtr edit_hwnd = Win32API.GetWindow(hwnd,Win32API.GW_CHILD);
            Win32API.SetWindowTextAny(edit_hwnd, context["CustomerFirstName"]);
            base.NotifyContextChange(context);
            return true;
        }
    }
}
