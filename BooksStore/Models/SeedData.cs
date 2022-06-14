using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

namespace BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BooksStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
               new Book
               {
                   Title = "ALBUM BLACKPINK: THE ALBUM",
                   Description = "https://mcdn.nhanh.vn/store/26155/ps/20201003/3012020120154_album%20Blackpinl.png",
                   Genre = "ALBUM",
                   Price = 50.000m
               },
                new Book
                {
                    Title = "ALBUM TWICE - SIGNAL",
                    Description = "https://mcdn.nhanh.vn/store/26155/ps/20200923/z2090739666576_ed6786e1910810611ea65a20cc874d00.jpg",
                    Genre = " ALBUM",
                    Price = 35.000m
                },
                new Book
                {
                    Title = "ALBUM BTS - PROOF",
                    Description = "https://mcdn.nhanh.vn/store/26155/ps/20220610/10062022070650_album_prood.jpg",
                    Genre = "ALBUM",
                    Price = 50.000m
                },
                new Book
                {
                    Title = "ALBUM TREASURE - THE SECOND STEP CHAPTER ONE",
                    Description = "https://mcdn.nhanh.vn/store/26155/ps/20220220/20022022080233_treasure.jpg",
                    Genre = "ALBUM",
                    Price = 20.000m
                },
                new Book
                {
                    Title = "ALBUM HWASA - [GUILTY PLEASURE]",
                    Description = "https://mcdn.nhanh.vn/store/26155/ps/20211206/06122021041210_album_hwasa.jpg",
                    Genre = "ALBUM",
                    Price =50.000m
                }
                );

                context.SaveChanges();
            }
        }
    }
}