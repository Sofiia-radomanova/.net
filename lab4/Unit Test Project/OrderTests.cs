using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdersLibrary.Models;
using System.Collections.Generic;

namespace lab4.tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void TestTotalSumOfflineWithDelivery()
        {
            var orders = new List<Order>
            {
                new OnlineOrder(1, 100, 20),
                new StoreOrder(2, "Іван", 80)
            };

            double total = OrderCalculator.GetTotalSum(orders);

            Assert.AreEqual(200, total);
        }


        [TestMethod]

        public void TestTotalSumOnline()
        {
            var orders = new List<Order>
            {
                new OnlineOrder(1, 300, 145),
                new OnlineOrder(2, 347, 100)
            };
            double total = OrderCalculator.GetTotalSum(orders);

            Assert.AreEqual(892, total);
        }

        [TestMethod]
        public void TestTotalSumOffline()
        {
            var orders = new List<Order>
            {
                new OnlineOrder(1, 300, 130),
                new OnlineOrder(2, 300, 100)
            };
            double total = OrderCalculator.GetTotalSum(orders);

            Assert.AreEqual(830, total);
        }

        [TestMethod]
        public void TestAddGoodsOnlineOrder()
        {
            var order = new OnlineOrder(1, 0, 20); // початковий TotalAmount = 0
            order.AddGoods(new OrderItem("Товар1", 50, 2)); // 100
            order.AddGoods(new OrderItem("Товар2", 30, 3)); // 90

            Assert.AreEqual(190, order.TotalAmount);
            Assert.AreEqual(210, order.GetFinalAmount()); // 190 + 20 DeliveryCost
        }

      
        [TestMethod]
        public void TestAddGoodsStoreOrder()
        {
            var order = new StoreOrder(2, "Іван", 0);
            order.AddGoods(new OrderItem("ТоварA", 25, 4)); // 100
            order.AddGoods(new OrderItem("ТоварB", 10, 5)); // 50

            Assert.AreEqual(150, order.TotalAmount);
            Assert.AreEqual(150, order.GetFinalAmount()); 
        }

        //перевірка порожнього списку замовлень
        [TestMethod]
        public void TestTotalSumEmptyOrders()
        {
            var orders = new List<Order>();
            double total = OrderCalculator.GetTotalSum(orders);

            Assert.AreEqual(0, total);
        }


    }
}
