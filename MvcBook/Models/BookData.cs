using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcBook.Models
{
    public static class BookData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcBookContext>>()))
            {
                
                if (context.Book.Any())
                {
                    return;   
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Design Patterns",
                        Genre = "Computação",
                        PublishDate = Convert.ToDateTime("1994-05-10"),
                        Author = "Erich Gamma",
                        Price = 149.99M
                    },

                    new Book
                    {
                        Title = "A Guerra dos Tronos",
                        Genre = "Aventura",
                        PublishDate = Convert.ToDateTime("2010-07-01"),
                        Author = "George R. R. Martin",
                        Price = 59.99M
                    },

                    new Book
                    {
                        Title = "Cinquenta Tons de Cinza",
                        Genre = "Romance",
                        PublishDate = Convert.ToDateTime("2012-01-20"),
                        Author = "E. L. James",
                        Price = 29.99M
                    },

                    new Book
                    {
                        Title = "A Cabana",
                        Genre = "Western",
                        PublishDate = Convert.ToDateTime("2008-12-05"),
                        Author = "William P. Young",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}