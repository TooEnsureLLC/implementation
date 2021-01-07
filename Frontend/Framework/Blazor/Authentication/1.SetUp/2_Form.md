# Create Authentication Form
> /Client/Shared/

Using blazor built in editform control.

``AuthRegisteration.razor``

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TooEnsure.Lib.Client.Models.Authentication;

namespace ProjectName.Client.Shared.Auth.RegisterComponent
{
    public partial class Register
    {
        UserRegister user = new UserRegister();

        [Inject] protected NavigationManager NavManager { get; set; }

        public void HandleRegister()
        {
            System.Console.WriteLine($"Adding user to database");
            NavManager.NavigateTo("page/login");
        }
    }
}
```

``AuthenticationLogin.razor``

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TooEnsure.Lib.Client.Models.Authentication;

namespace ProjectName.Client.Shared.Auth.LoginComponent
{
    public partial class Login
    {
        private UserLogin user = new UserLogin();

        private void HandleLoginAsync()
        {
            System.Console.WriteLine($"user: {user.Username} pw: {user.Password}");
        }
    }
}

```