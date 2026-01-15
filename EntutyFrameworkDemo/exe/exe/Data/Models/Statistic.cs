using System;
using System.Collections.Generic;

namespace exe.Data.Models;

public partial class Statistic
{
    public int Id { get; set; }

    public int Strength { get; set; }

    public int Defence { get; set; }

    public int Mind { get; set; }

    public int Speed { get; set; }

    public int Luck { get; set; }

    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

    public virtual ICollection<GameType> GameTypes { get; set; } = new List<GameType>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
