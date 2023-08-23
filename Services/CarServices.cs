using WebApplication1.Data.Repository;
using System;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class CarServices
    {
        private readonly IRepository<Car> _CarRepository;
        private readonly IRepository<Model> _ModelRepository;

        public CarServices(IRepository<Car> repository,
            IRepository<Model> modelrepository) 
        {
            _CarRepository = repository;
            _ModelRepository = modelrepository;
        }

        public async Task<dynamic> Get(int brandid,string name,int year) 
        {
            string model = "Model";
            string brand = "Brand";
            IEnumerable<Car> cars =_CarRepository.GetAll()
            .Include(c => c.Model).ThenInclude(m => m.Brand);

            if (brandid != 0)
            {
                cars = cars.Where(m => m.Model.BrandID == brandid);
            }

            if (name != null)
            {
                cars = cars.Where(m => m.Model.Name == name);
            }

            if (year != 0)
            {
                cars = cars.Where(c => c.Year == year);
            }

            var filteredCars = cars.ToList();

            return filteredCars;
        }
        //public async Task<dynamic> filter(int id) 
        //{
        //    string model = "Model";
        //    string brand = "Brand";

        //    IEnumerable<Car> cars = _CarRepository.GetAll();
            
        //    return cars;
        //}
    }
}