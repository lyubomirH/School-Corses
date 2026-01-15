using Entity_Framework_Code_First_LAB.Configration;
using Entity_Framework_Code_First_LAB.Data;
using Entity_Framework_Code_First_LAB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Entity_Framework_Code_First_LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctx = new ForumDbContext();
            //var result = ctx.Posts.ToList();
            //foreach (var item in result)
            //{
            //    ctx.Users.Find(item.UserId);
            //}

            //var result = ctx.Users.Select(u => new 
            //{
            //    u.Username,
            //    PostCount = u.Posts.Count(),
            //}).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var postsAnsers = ctx.PostAnswers.Select(ps => new { ps.UserId, ps.AnswerContent, ps.PostId}).ToList();
            //var users = ctx.Users.Select(u => new { u.Id, u.Username}).ToList();

            //foreach(var post in postsAnsers)
            //{
            //    foreach (var user in users)
            //    {
            //        if (post.UserId == user.Id)
            //        {
            //            Console.WriteLine($"Auter: {user.Username} -> Post: {post.PostContent}");
            //        }
            //    }
            //}

            var result = ctx.Posts
                .Include(p => p.PostAnswers)
                .ThenInclude(pa => pa.User)
                .Select(p => new
                {
                    p.User.Username,
                    p.PostContent,
                    p.PostAnswers
                }).ToList();

            foreach (var item in result) 
            {
                Console.WriteLine($"{item.Username} wrote:{Environment.NewLine}{item.PostContent}");
                foreach (var answer in item.PostAnswers)
                {
                    Console.WriteLine($"    =={answer.User.Username} =={Environment.NewLine}==answerd: {answer.AnswerContent}==");
                }
                Console.WriteLine(new string('-', 100));
                Console.WriteLine(new string('-', 100));
            }

        }
    }
}
