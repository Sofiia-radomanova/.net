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

            //double total = OrderCalculator.GetTotalSum(orders); //(лаб4)
            // Приводимо List<Order> до List<ICalculable> для поліморфізму
            double total = OrderCalculator.GetTotalSum(orders.Cast<ICalculable>().ToList());

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
            //double total = OrderCalculator.GetTotalSum(orders);
            double total = OrderCalculator.GetTotalSum(orders.Cast<ICalculable>().ToList());
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
            //double total = OrderCalculator.GetTotalSum(orders);
            double total = OrderCalculator.GetTotalSum(orders.Cast<ICalculable>().ToList());
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
            //double total = OrderCalculator.GetTotalSum(orders);
            double total = OrderCalculator.GetTotalSum(orders.Cast<ICalculable>().ToList());
            Assert.AreEqual(0, total);
        }

        // тест для демонстрації поліморфізму з ICalculable
        [TestMethod]
        public void TestTotalSumWithICalculablePolymorphism()
        {
            // Створюємо список об'єктів, що реалізують ICalculable
            var calculableItems = new List<ICalculable>
            {
                new OnlineOrder(10, 100, 20), // 120
                new StoreOrder(20, "Петро", 80), // 80
                new GiftCard(1, 50) // 50
            };

            // Використовуємо метод, що працює через інтерфейс
            double total = OrderCalculator.GetTotalSum(calculableItems);

            Assert.AreEqual(250, total); // 120 + 80 + 50 = 250
        }

        //тест для демонстрації поліморфізму з IClientInfo
        [TestMethod]
        public void TestClientInfoPolymorphism()
        {
            var clientItems = new List<IClientInfo>
            {
                new OnlineOrder(55, 0, 0),
                new StoreOrder(66, "Олена", 0)
            };

            var identifiers = OrderCalculator.GetClientIdentifiers(clientItems);

            Assert.AreEqual(2, identifiers.Count);
            Assert.IsTrue(identifiers.Contains("Online-User-55"));
            Assert.IsTrue(identifiers.Contains("Олена"));
        }
    }
}
