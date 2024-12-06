using Libre_MEJG.Data.Models;
using Microsoft.AspNetCore.Builder;
using System;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;

namespace Libre_MEJG.Data
{
    public class AppDblnitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "1st Book Title",
                        Descripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "1st Autor",
                        ConverUrl = "https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {
                        Titulo = "2nd Book Title",
                        Descripcion = "2nd Book Description",
                        IsRead = true,
                        Genero = "Biography",
                        Autor = "2nd Autor",
                        ConverUrl = "https...",
                        DateAdded = DateTime.Now

                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
