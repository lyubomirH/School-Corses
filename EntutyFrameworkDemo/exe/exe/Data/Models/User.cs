using System;
using System.Collections.Generic;

namespace exe.Data.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateTime RegistrationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string IpAddress { get; set; } = null!;

    public virtual ICollection<UsersGame> UsersGames { get; set; } = new List<UsersGame>();
}
