using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using OrdersLibrary.Models;

namespace OrdersWpfApp
{
    public partial class MainWindow : Window
    {
        private List<Order> orders = new List<Order>();
        private List<OrderItem> currentItems = new List<OrderItem>();

        public MainWindow()
        {
            InitializeComponent();
            UpdateItemsDisplay();
        }

        private void BtnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtItemName.Text;
                if (!double.TryParse(txtItemPrice.Text, out double price))
                {
                    MessageBox.Show("Введіть коректну ціну");
                    return;
                }
                if (!int.TryParse(txtItemQty.Text, out int quantity))
                {
                    MessageBox.Show("Введіть коректну кількість");
                    return;
                }

                var item = new OrderItem(name, price, quantity);
                currentItems.Add(item);
                UpdateItemsDisplay();

                // Очистити поля
                txtItemName.Text = "Товар " + (currentItems.Count + 1);
                txtItemPrice.Text = "100";
                txtItemQty.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentItems.Count == 0)
                {
                    MessageBox.Show("Додайте товари до замовлення");
                    return;
                }

                if (!int.TryParse(txtNumber.Text, out int number))
                {
                    MessageBox.Show("Введіть коректний номер замовлення");
                    return;
                }

                Order order;
                bool isOnline = cmbOrderType.SelectedIndex == 0;

                if (isOnline)
                {
                    if (!double.TryParse(txtDelivery.Text, out double delivery))
                    {
                        MessageBox.Show("Введіть коректну вартість доставки");
                        return;
                    }
                    order = new OnlineOrder(number, 0, delivery);
                }
                else
                {
                    order = new StoreOrder(number, txtClient.Text, 0);
                }

                // Додати всі товари
                foreach (var item in currentItems)
                {
                    order.AddGoods(item);
                }

                orders.Add(order);
                UpdateOrdersDisplay();
                ClearCurrentOrder();

                MessageBox.Show($"Замовлення №{number} створено!\nСума: {order.GetFinalAmount():N2} грн");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Створюємо список ICalculable, додаючи замовлення
            var calculableList = new List<OrdersLibrary.Models.ICalculable>();
            foreach (var order in orders)
            {
                calculableList.Add(order); // Order є ICalculable
            }

            // Додамо для прикладу подарункову картку
            calculableList.Add(new OrdersLibrary.Models.GiftCard(999, 100));

            // Використовуємо метод OrderCalculator
            double total = OrdersLibrary.Models.OrderCalculator.GetTotalSum(calculableList);

            // double total = 0; // старий код
            // foreach (var order in orders)
            // {
            //     total += order.GetFinalAmount();
            // }

            txtSummary.Text = $"Загальна сума (вкл. картку 100 грн): {total:N2} грн | Кількість замовлень: {orders.Count}";
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearCurrentOrder();
        }

        private void UpdateOrdersDisplay()
        {
            var displayList = new List<OrderDisplay>();
            foreach (var order in orders)
            {
                displayList.Add(new OrderDisplay
                {
                    Number = order.Number,
                    Type = order is OnlineOrder ? "Online" : "Store",
                    TotalAmount = order.TotalAmount,
                    FinalAmount = order.GetFinalAmount()
                });
            }
            dgOrders.ItemsSource = displayList;
        }

        private void UpdateItemsDisplay()
        {
            var displayList = new List<ItemDisplay>();
            foreach (var item in currentItems)
            {
                displayList.Add(new ItemDisplay
                {
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    Total = item.GetTotal()
                });
            }
            dgItems.ItemsSource = displayList;
        }

        private void ClearCurrentOrder()
        {
            currentItems.Clear();
            UpdateItemsDisplay();
            txtItemName.Text = "Товар 1";
            txtItemPrice.Text = "100";
            txtItemQty.Text = "1";
        }
    }

    // Прості класи для відображення даних
    public class OrderDisplay
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public double TotalAmount { get; set; }
        public double FinalAmount { get; set; }
    }

    public class ItemDisplay
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}