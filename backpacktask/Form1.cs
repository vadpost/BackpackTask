using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpackTask
{
    public partial class Form1 : Form
    {
        private List<Item> items; //У ньому буде зберігається список товарів, якими необхідно заповнити транспорт
        public Form1()
        {
            InitializeComponent();

            AddItems();
            ShowItems(items);
        }

        private void AddItems()
        { //стоворення статичних даних
            items = new List<Item>();
            /*items.Add(new Item("П1", 11, 19));
            items.Add(new Item("П2", 16, 25));
            items.Add(new Item("П3", 25, 45));
            items.Add(new Item("П4", 20, 35));*/
        }

        private void AddGoods_Click(object sender, EventArgs e)
        {
            //введення товару №1
            ListViewItem item1 = new ListViewItem(txtName1.Text);
            item1.SubItems.Add(txtWeight1.Text);
            item1.SubItems.Add(txtPrice1.Text);
            itemsListView.Items.Add(item1);

            //введення товару №2
            ListViewItem item2 = new ListViewItem(txtName2.Text);
            item2.SubItems.Add(txtWeight2.Text);
            item2.SubItems.Add(txtPrice2.Text);
            itemsListView.Items.Add(item2);

            //введення товару №3
            ListViewItem item3 = new ListViewItem(txtName3.Text);
            item3.SubItems.Add(txtWeight3.Text);
            item3.SubItems.Add(txtPrice3.Text);
            itemsListView.Items.Add(item3);

            //введення товару №4
            ListViewItem item4 = new ListViewItem(txtName4.Text);
            item4.SubItems.Add(txtWeight4.Text);
            item4.SubItems.Add(txtPrice4.Text);
            itemsListView.Items.Add(item4);

            //ініціалізація товарів
            items = new List<Item>();
            items.Add(new Item(txtName1.Text, Convert.ToDouble(txtWeight1.Text), Convert.ToDouble(txtPrice1.Text)));//товар №1
            items.Add(new Item(txtName2.Text, Convert.ToDouble(txtWeight2.Text), Convert.ToDouble(txtPrice2.Text)));//товар №2
            items.Add(new Item(txtName3.Text, Convert.ToDouble(txtWeight3.Text), Convert.ToDouble(txtPrice3.Text)));//товар №3
            items.Add(new Item(txtName4.Text, Convert.ToDouble(txtWeight4.Text), Convert.ToDouble(txtPrice4.Text)));//товар №4

            txtName1.Clear(); txtName2.Clear(); txtName3.Clear(); txtName4.Clear();
            txtWeight1.Clear(); txtWeight2.Clear(); txtWeight3.Clear(); txtWeight4.Clear();
            txtPrice1.Clear(); txtPrice2.Clear(); txtPrice3.Clear(); txtPrice4.Clear();
        }

        private void ShowItems(List<Item> _items)
        {//виводить список предметів в ListView та вивиодить суму ваги та суму ціни
            itemsListView.Items.Clear();
            double price = 0;
            double weigth = 0;
            foreach (Item i in _items)
            {
                itemsListView.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(), 
                    i.price.ToString() }));
                price += i.price;
                weigth += i.weigth;
                label5.Text = ("Ціна: ") + Convert.ToString(price);
                label6.Text = ("Вага: ") + Convert.ToString(weigth);
            }
        }

       

        private void ShowConditionsButton_Click(object sender, EventArgs e)
        {
            //кнопка "очистити таблицю"
            itemsListView.Items.Clear();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            //кнопка "Розв'язати"
            Backpack bp = new Backpack(Convert.ToDouble(weightTextBox.Text));// конвертування максимальної ваги в Backpack

            bp.MakeAllSets(items);//всі об'єкни пеглядаються для огляду

            List<Item> solve = bp.GetBestSet();//витяг об'єктів які відповідаються умовам

            if(solve == null)
            {
                MessageBox.Show("Немає розв'язку!");
            }
            else
            {
                itemsListView.Items.Clear();

                ShowItems(solve);// визивається фунція ShowItems

                MessageBox.Show("Розв'язок в таблиці!");
            }
        }

    }
}