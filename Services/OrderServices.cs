using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data.Repository;
using WebApplication1.Models;

namespace Services
{
    public class OrderServices
    {
        private readonly IRepository<Order> _OrderRepository;
        private readonly IRepository<OrderCar> _OrderCarRepository;

        public OrderServices(IRepository<Order> repository
            , IRepository<OrderCar> orderCarRepository)
        {
            _OrderRepository = repository;
            _OrderCarRepository = orderCarRepository;
        }
        public async Task<dynamic> AddOrder(OrderDTO orderDTO)
        {
            if (orderDTO != null)
            {
                Order order = new Order();
                order.CustomerName = orderDTO.CustomerName;
                order.CustomerNationality = orderDTO.Nationality;
                //Stock stock = await unitOfWorkRepository.Stock.GetById(order.StockID);
                //order.carID = orderDTO.CarId;
                order.DrivingLicense = orderDTO.DrivingLicense;
                order.TransactionDate = orderDTO.TransactionDate;
                //order.RentFrom = orderDTO.RentFrom;
                //order.RentTo = orderDTO.RentTo;
                //order.Quantity = orderDTO.Quantity;
                order.AdvancedPayment = orderDTO.AdvancedPayment;


               order = _OrderRepository.create(order);
               


                //unitOfWorkRepository.Order.Add(order);

                return order;
            }
            else
            {
                return "BadRequest Please input your data correctly";
            }
        }

        public async Task<dynamic> AddCars(OrderCarsDTO carsDTOs)
        {
            List<OrderCar> orderCars = new List<OrderCar>();
            if (carsDTOs != null)
            {

                //foreach (var car in carsDTOs)
                //{

                    OrderCar orderCar = new OrderCar();
                    orderCar.CarId = carsDTOs.Id;
                    orderCar.OrderId = carsDTOs.orderId;
                    orderCar.Quantity = carsDTOs.quantity;
                    orderCar.RentFrom = carsDTOs.rentFrom;
                    orderCar.RentTo = carsDTOs.rentTo;
                    //orderCars.Add(orderCar);
                    orderCar = _OrderCarRepository.create(orderCar);

                //}
                 return orderCar;
            }
            else
            {
                return "BadRequest Please input your data correctly";
            }
        }

     }
}
