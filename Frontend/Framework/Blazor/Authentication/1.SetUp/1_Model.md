# Creating A Model

What data to collect when registering user

``UserRegister.cs``

```c#
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }

    [Required, EmailAddress] 
    public string Email { get; set; }

    [Required, StringLength(10, MinimumLength = 5, 
    ErrorMessage = "Your username is too long (15 charaters max. || min of 5)")]
    public string Username { get; set; }
    [Required,
    StringLength(16, MinimumLength = 5,
    ErrorMessage = "Your username is too long (16 charaters max. || min of 5)")]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Password do not match")]
    public string ConfirmedPassword { get; set; }

    public DateTime DataOfBirth { get; set; }
    
    [Range(typeof(bool), "true", "true", ErrorMessage = "Only confired users can create account")]
    public bool IsConfirmed { get; set; } = true;
```

What data to use when authenticating ***UserRegister***

```UserLogin.cs```

```c#
    [Required(ErrorMessage = "Username is required.")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; }
```