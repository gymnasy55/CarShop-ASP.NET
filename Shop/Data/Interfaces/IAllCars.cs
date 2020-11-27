using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> GetCars { get; }
        IEnumerable<Car> GetFavouriteCars { get; }
        Car GetObjectCar(int carId);
    }
}
