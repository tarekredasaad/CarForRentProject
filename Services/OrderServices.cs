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

        public OrderServices(IRepository<Order> repository)
        {
            _OrderRepository = repository;
        }
        public async Task<dynamic> AddOrder(OrderDTO orderDTO)
        {
            if (orderDTO != null)
            {
                Order order = new Order();
                order.CustomerName = orderDTO.CustomerName;
                order.CustomerNationality = orderDTO.CustomerNationality;
                //Stock stock = await unitOfWorkRepository.Stock.GetById(order.StockID);
                //order.carID = orderDTO.CarId;
                order.DrivingLicense = orderDTO.DrivingLicense;
                order.TransactionDate = orderDTO.TransactionDate;
                //order.RentFrom = orderDTO.RentFrom;
                //order.RentTo = orderDTO.RentTo;
                //order.Quantity = orderDTO.Quantity;
                order.AdvancedPayment = orderDTO.AdvancedPayment;

                _OrderRepository.create(order);

                //unitOfWorkRepository.Order.Add(order);

                return "order has inserted successfully";
            }
            else
            {
                return "BadRequest Please input your data correctly";
            }
        }
    }
}
