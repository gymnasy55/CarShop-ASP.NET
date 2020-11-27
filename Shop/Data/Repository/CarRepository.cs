using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDbContent;

        public CarRepository(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Car> GetCars => _appDbContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavouriteCars => _appDbContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car GetObjectCar(int carId) => _appDbContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}
