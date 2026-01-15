using exe.Data.Models;

namespace exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new DiabloContext();

            // Console.WriteLine(GetGamesInformation(context));
            // Console.WriteLine(GetItemsWithPriceOver790(context));
            // Console.WriteLine(GetItemWithTypeAxe(context));
            // Console.WriteLine(AddNewGame(context));
            // Console.WriteLine(GetUsersAndGamesInformation(context));
            // Console.WriteLine(GetUsersGames(context));
            // Console.WriteLine(GetUsersWithMoreThan5Games(context));
            // Console.WriteLine(IncreasePrice(context));
        }
        public static string GetGamesInformation(DiabloContext context)
        {
            var games = context.Games
                .OrderBy(g => g.Start)
                .Select(g => new
                {
                    g.Name,
                    g.Start,
                    g.Duration,
                    g.IsFinished
                })
                .ToList();

            var result = string.Join(Environment.NewLine, games.Select(g =>
                $"{g.Name} {g.Start:dd-MMM-yy h:mm:ss tt} {g.Duration} {(g.IsFinished ? "Finished" : "Unfinished")}"));

            return result;
        }

        public static string GetItemsWithPriceOver790(DiabloContext context)
        {
            var items = context.Items
                .Where(i => i.Price > 790)
                .OrderBy(i => i.Name)
                .Select(i => new
                {
                    i.Name,
                    Price = Math.Round(i.Price, 2)
                })
                .ToList();

            var result = string.Join(Environment.NewLine, items.Select(i =>
                $"{i.Name} - {i.Price:F2}"));

            return result;
        }

        public static string GetItemWithTypeAxe(DiabloContext context)
        {
            var items = context.Items
                .Where(i => i.ItemType.Name == "Axe")
                .OrderBy(i => i.Price)
                .ThenByDescending(i => i.Name)
                .Select(i => new
                {
                    i.Name,
                    ItemType = i.ItemType.Name,
                    Price = Math.Round(i.Price, 2)
                })
                .ToList();

            var result = string.Join(Environment.NewLine, items.Select(i =>
                $"{i.Name} with type {i.ItemType} - ${i.Price:F2}"));

            return result;
        }

        public static string AddNewGame(DiabloContext context)
        {
            var newGame = new Game
            {
                Name = "Demo",
                Start = new DateTime(2016, 2, 13),
                Duration = 7,
                GameTypeId = 5,
                IsFinished = false
            };

            context.Games.Add(newGame);
            context.SaveChanges();

            var lastGames = context.Games
                .OrderByDescending(g => g.Id)
                .Take(10)
                .Select(g => g.Name)
                .ToList();

            var result = string.Join(Environment.NewLine, lastGames);
            return result;
        }

        public static string GetUsersAndGamesInformation(DiabloContext context)
        {
            var users = context.Users
                .Where(u => u.RegistrationDate.Year >= 2013 && u.RegistrationDate.Year <= 2014)
                .OrderBy(u => u.RegistrationDate)
                .Take(10)
                .Select(u => new
                {
                    u.Username,
                    u.FirstName,
                    u.LastName,
                    RegistrationDate = u.RegistrationDate,
                    Games = u.UsersGames.Select(ug => new
                    {
                        GameName = ug.Game.Name,
                        ug.Level,
                        JoinedOn = ug.JoinedOn,
                        Duration = ug.Game.Duration,
                        IsFinished = ug.Game.IsFinished
                    })
                    .OrderBy(g => g.GameName)
                })
                .ToList();

            var result = new List<string>();

            foreach (var user in users)
            {
                result.Add($"Username:{user.Username} Names: {user.FirstName} {user.LastName} - Registration Date: {user.RegistrationDate:dd-MMM-yy h:mm:ss tt}");

                foreach (var game in user.Games)
                {
                    var durationInfo = game.IsFinished ? game.Duration.ToString() : "Not finished";
                    result.Add($"-- Game: {game.GameName}, Level: {game.Level} - {game.JoinedOn:M/d/yyyy h:mm:ss tt}, Duration: {durationInfo}");
                }
            }

            return string.Join(Environment.NewLine, result);
        }

        public static string GetUsersGames(DiabloContext context)
        {
            var users = context.Users
                .Select(u => new
                {
                    u.Username,
                    u.Email,
                    GamesCount = u.UsersGames.Count
                })
                .OrderByDescending(u => u.GamesCount)
                .ThenBy(u => u.Username)
                .Take(10)
                .ToList();

            var result = string.Join(Environment.NewLine, users.Select(u =>
                $"{u.Username}, {u.Email} - {u.GamesCount} games"));

            return result;
        }

        public static string GetUsersWithMoreThan5Games(DiabloContext context)
        {
            var users = context.Users
                .Where(u => u.UsersGames.Count > 5)
                .Select(u => new
                {
                    u.Username,
                    GamesCount = u.UsersGames.Count
                })
                .OrderBy(u => u.GamesCount)
                .ThenBy(u => u.Username)
                .ToList();

            var result = string.Join(Environment.NewLine, users.Select(u =>
                $"Username: {u.Username} - Count Games:{u.GamesCount}"));

            return result;
        }

        public static string IncreasePrice(DiabloContext context)
        {
            var itemsToUpdate = context.Items
                .Where(i => i.Statistic.Luck == 18)
                .ToList();

            foreach (var item in itemsToUpdate)
            {
                item.Price *= 1.12m;
            }

            context.SaveChanges();

            var updatedItems = context.Items
                .Where(i => i.Statistic.Luck == 18)
                .Select(i => new
                {
                    i.Name,
                    Speed = i.Statistic.Speed,
                    Price = Math.Round(i.Price, 2)
                })
                .OrderBy(i => i.Name)
                .ThenBy(i => i.Price)
                .ToList();

            var result = string.Join(Environment.NewLine, updatedItems.Select(i =>
                $"{i.Name} {i.Speed} (${i.Price:F2})"));

            return result;
        }
    }
}
