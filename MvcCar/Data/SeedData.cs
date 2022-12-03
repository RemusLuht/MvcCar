using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                if (context.Car.Any())
                {
                    return;
                }
                context.Car.AddRange(
                  new Car
                  {
                      Name = "BMW",
                      Color = "Black",
                      Speed = 120,

                  },
                   new Car
                   {
                       Name = "Audi",
                       Color = "White",
                       Speed = 110,

                   },
                    new Car
                    {
                        Name = "Fiat",
                        Color = "Red",
                        Speed = 85,

                    }


                );
                context.SaveChanges();
                if (context.Car.Any())
                {
                    return;
                }
            }
        }
    }
}