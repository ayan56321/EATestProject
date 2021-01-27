using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Base;

namespace EAEmployeeTest
{
    public class HookInitialize :TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.Chrome)
        {
            InitializeSettings();
            NavigateSite();
        }
    }
}
