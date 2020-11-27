using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> GetCars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryCars.GetCategories.First()
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
                        Category = _categoryCars.GetCategories.Last()
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
                        Category = _categoryCars.GetCategories.Last()
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
                        Category = _categoryCars.GetCategories.Last()
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
                        Category = _categoryCars.GetCategories.First()
                    }
                };
            }
                
        }

        public IEnumerable<Car> GetFavouriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
