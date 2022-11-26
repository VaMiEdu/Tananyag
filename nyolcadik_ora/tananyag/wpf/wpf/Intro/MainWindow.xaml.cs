using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ordersJsonPath = "orders.json";

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(ordersJsonPath))
            {
                var file = File.ReadAllText(ordersJsonPath);

                var pizzaList = JsonConvert.DeserializeObject<Order[]>(file);

                pizzaList.ToList();

                foreach (var pizza in pizzaList)
                {
                    orders_listBox.Items.Add(pizza);
                }
            }


            pizzaName_comboBox.Items.Add("Piedone");
            pizzaName_comboBox.Items.Add("Vegan");
            pizzaName_comboBox.Items.Add("Songoku");
            pizzaName_comboBox.Items.Add("Marghareta");
            pizzaName_comboBox.Items.Add("Hawaii");
            pizzaName_comboBox.Items.Add("Négysajtos");

            pizzaName_comboBox.SelectedIndex = 0;

        }

        private void order_button_Click(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order(personName_textBox.Text, pizzaName_comboBox.SelectedItem.ToString(), tomato_radioButton.IsChecked);

            orders_listBox.Items.Add(newOrder);

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var orders = new List<Order>();

            foreach (var pizza in orders_listBox.Items)
            {
                orders.Add(pizza as Order);
            }

            var json = JsonConvert.SerializeObject(orders);

            File.WriteAllText(ordersJsonPath, json);

        }
    }
}
