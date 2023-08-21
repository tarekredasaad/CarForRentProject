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
            IEnumerable<Car> cars;

            if(brandid != 0)
            {
            cars = _CarRepository.GetAll()
                .Include(c=> c.Model).ThenInclude(m=> m.Brand)
                .Where(m => m.Model.BrandID == brandid).ToList();
            }
            else if (name != null)
            {
                 cars = _CarRepository.GetAll()
                .Include(c=> c.Model).ThenInclude(m=> m.Brand).Where(m=>m.Model.Name == name).ToList();
            }
            else if (year != 0)
            {

                 cars = _CarRepository.GetAll(c=>c.Year == year)
                .Include(c=> c.Model).ThenInclude(m=> m.Brand).ToList();

            }else if(brandid != 0 && name != null)
            {
              cars = _CarRepository.GetAll()
                .Include(c=> c.Model).ThenInclude(m=> m.Brand)
                .Where(m=>m.Model.Name == name && m.Model.BrandID == brandid).ToList();
            

            }else if(brandid != 0 && year != 0)
            {
              cars = _CarRepository.GetAll(c => c.Year == year)
                .Include(c=> c.Model).ThenInclude(m=> m.Brand)
                .Where(m=> m.Model.BrandID == brandid).ToList();
            

            }else if(name != null && year != 0)
            {
              cars = _CarRepository.GetAll(c => c.Year == year)
                .Include(c=> c.Model).ThenInclude(m=> m.Brand)
                .Where(m=> m.Model.Name == name).ToList();
            

            }else if(name != null && year != 0 && name != null)
            {
              cars = _CarRepository.GetAll(c => c.Year == year)
                .Include(c=> c.Model).ThenInclude(m=> m.Brand)
                .Where(m=> m.Model.Name == name && m.Model.BrandID == brandid).ToList();
            

            }
            else
            {
                 cars = _CarRepository.GetAll()
                    .Include(c=> c.Model).ThenInclude(m=> m.Brand).ToList();          
            

            }

            return cars;
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