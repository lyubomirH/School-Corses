using System;
using System.Collections.Generic;

namespace exe.Data.Models;

public partial class Game
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Start { get; set; }

    public int? Duration { get; set; }

    public int GameTypeId { get; set; }

    public bool IsFinished { get; set; }

    public virtual GameType GameType { get; set; } = null!;

    public virtual ICollection<UsersGame> UsersGames { get; set; } = new List<UsersGame>();
}
