using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDescription = "Уютный и большой",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/leaf.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", Description = "Современный вид транспорта" },
                        new Category { CategoryName = "Классические автомобили", Description = "Машины c двигателем внутреннего сгорания" }
                    };
                    _category = new Dictionary<string, Category>();
                    foreach (var k in list)
                        _category.Add(k.CategoryName, k);
                }

                return _category;
            }
        }
    }
}
