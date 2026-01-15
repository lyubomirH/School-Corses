using System;
using System.Collections.Generic;

namespace exe.Data.Models;

public partial class GameType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? BonusStatsId { get; set; }

    public virtual Statistic? BonusStats { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
