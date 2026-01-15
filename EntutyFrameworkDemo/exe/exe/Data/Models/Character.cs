using System;
using System.Collections.Generic;

namespace exe.Data.Models;

public partial class Character
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? StatisticId { get; set; }

    public virtual Statistic? Statistic { get; set; }

    public virtual ICollection<UsersGame> UsersGames { get; set; } = new List<UsersGame>();
}
