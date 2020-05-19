using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sushi_bot
{
    public partial class SushiBot : Form
    {
        Customer customer = new Customer();

        Dictionary<string, int> sushiDictionary = new Dictionary<string, int>
        {
            {"Спайси текка маки", 1},
            {"Сяке маки", 2},
            {"Спайси сяке маки", 3},
            {"Текка маки", 4},
            {"Авокадо маки", 5},
            {"Сяке авокадо маки", 6},
            {"Каппа маки", 7},
            {"Унаги маки", 8},
            {"Спайси кунсей маки", 9},
            {"Энсёку маки", 10},
            {"Катори маки", 11},
            {"Сяке оригами маки", 12}
        };

        List<Sushi> bucketSushiList = new List<Sushi>();

        public SushiBot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1MaxValue)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else 
            {
                WebSiteSushiVeslaWorker worker = new WebSiteSushiVeslaWorker(webSiteSushiVesla);

                foreach (var item in bucketSushiList)
                {
                    worker.SushiClicker(item.siteNumber);
                }

                customer.TelephoneNumber = textBoxTelNumber.Text.Remove(0, 4);

                worker.WriteInformation(customer.Street, 
                                        customer.House, 
                                        customer.Quarter, 
                                        customer.Name,
                                        customer.TelephoneNumber,
                                        customer.Email,
                                        customer.PaymentMethod,
                                        customer.MoneySurrender,
                                        customer.Comment,
                                        customer.RealPurchase);
            }
        }

        private void comboBoxChahgeOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrganization = (string)comboBoxChahgeOrganization.SelectedItem;

            if (selectedOrganization.Equals("Суши Вёсла"))
            {
                if (progressBar1.Value < progressBar1MaxValue && sushiChecked.Equals(false))
                {
                    sushiChecked = true;
                    progressBar1.Value += progressBarStep;                   
                }

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (sushiChecked)
                {
                    sushiChecked = false;
                    progressBar1.Value -= progressBarStep;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            customer.Name = textBoxName.Text;

            if (!nameIsChanged)
            {
                progressBar1.Value += progressBarStep;
                nameIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            if (textBoxName.Text.Length < 1 && nameIsChanged)
            {
                progressBar1.Value -= progressBarStep;
                nameIsChanged = false;
                CompleteOrder.BackColor = Color.FromName("Red");
                
            }
        }

        private void comboBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPaymentMethod = (string)comboBoxPayment.SelectedItem;

            if (!paymentIsChanged)
            {
                progressBar1.Value += progressBarStep;
                paymentIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            if (comboBoxPayment.Text.Length < 1 && paymentIsChanged)
            {
                progressBar1.Value -= progressBarStep;
                paymentIsChanged = false;
                labelMoneySdacha.Text = "";
                textBoxMoneySum.Text = "";
                textBoxMoneySum.Enabled = false;
                CompleteOrder.BackColor = Color.FromName("Red");
            }

            if (selectedPaymentMethod.Equals("Наличные"))
            {
                customer.PaymentMethod = "Наличные";
                labelMoneySdacha.Text = "С какой суммы подготовить сдачу?";
                textBoxMoneySum.Enabled = true;
            }

            if (selectedPaymentMethod.Equals("Картой онлайн"))
            {
                customer.PaymentMethod = "Картой онлайн";
                labelMoneySdacha.Text = "";
                textBoxMoneySum.Text = "";
                textBoxMoneySum.Enabled = false;
            }

            if (selectedPaymentMethod.Equals("Картой курьеру"))
            {
                customer.PaymentMethod = "Картой курьеру";
                labelMoneySdacha.Text = "";
                textBoxMoneySum.Text = "";
                textBoxMoneySum.Enabled = false;
            }
        }

        private void textBoxTelNumber_TextChanged(object sender, EventArgs e)
        {
            customer.TelephoneNumber = textBoxTelNumber.Text;

            if (customer.TelephoneNumber.Length == 13 && customer.TelephoneNumber.Contains("+375") && !telNumberIsChanged)
            {
                progressBar1.Value += progressBarStep;                
                telNumberIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (telNumberIsChanged)
                {
                    telNumberIsChanged = false;
                    progressBar1.Value -= progressBarStep;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            customer.Email = textBoxEmail.Text;

            if (customer.Email.Length > 5 &&
                customer.Email.Contains("@") &&
                !emailIsChanged &&
                customer.Email.Contains(".com") ||
                customer.Email.Contains(".ru")  ||
                customer.Email.Contains(".su"))
            {
                progressBar1.Value += progressBarStep;
                emailIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (emailIsChanged)
                {
                    emailIsChanged = false;
                    progressBar1.Value -= progressBarStep;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customer.Street = textBoxStreet.Text;

            if (customer.Street.Length > 0 && !streetIsChanged)
            {
                progressBar1.Value += progressBarStep;
                streetIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (customer.Street.Length < 1)
                {
                    progressBar1.Value -= progressBarStep;
                    streetIsChanged = false;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBoxHome_TextChanged(object sender, EventArgs e)
        {
            customer.House = textBoxHome.Text;

            if (customer.House.Length > 0 && !homeIsChanged)
            {
                progressBar1.Value += progressBarStep;
                homeIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (customer.House.Length < 1)
                {
                    progressBar1.Value -= progressBarStep;
                    homeIsChanged = false;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            customer.Quarter = textBox2.Text;

            if (customer.Quarter.Length > 0 && !quarterIsChanged)
            {
                progressBar1.Value += progressBarStep;
                quarterIsChanged = true;

                if (progressBar1.Value == progressBar1MaxValue)
                {
                    CompleteOrder.BackColor = Color.FromName("Green");
                }
            }

            else
            {
                if (customer.Quarter.Length < 1)
                {
                    progressBar1.Value -= progressBarStep;
                    quarterIsChanged = false;
                    CompleteOrder.BackColor = Color.FromName("Red");
                }
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            customer.Comment = textBoxComment.Text;
        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            toolTip1.RemoveAll();
            toolTip1.SetToolTip(treeView1, e.Node.ToolTipText);
            toolTip1.UseFading = true;
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (!treeView1.SelectedNode.Text.Equals("Суши"))
            {
                MessageBox.Show($"{treeView1.SelectedNode.Text} добавлены в корзину!");

                TreeNode node = (TreeNode)treeView1.SelectedNode.Clone();

                double cost = Convert.ToDouble(node.Tag);

                Sushi sushi = new Sushi();

                sushi.name = node.Text;

                foreach (var sushiDict in sushiDictionary)
                {
                    if (sushiDict.Key.Equals(sushi.name))
                    {
                        sushi.siteNumber = sushiDict.Value;
                        bucketSushiList.Add(sushi);
                    }
                }

                node.Text += $" (сет 8шт.) {node.Tag}руб.";
                sushi.bucketName = node.Text;

                treeView2.Nodes.Add(node);
                
                labelSum.Text = $"Сумма заказа : {totalPrice += cost}руб";                       
            }
        }

        private void treeView2_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView2.SelectedNode;

            double cost = Convert.ToDouble(node.Tag);

            MessageBox.Show($"{treeView2.SelectedNode.Text} удалены из корзины!");           

            var item = bucketSushiList.Find(x => x.bucketName.Equals(node.Text));

            bucketSushiList.Remove(item);
            treeView2.Nodes.Remove(node);

            labelSum.Text = $"Сумма заказа : {totalPrice -= cost}руб";
        }

        private void textBoxMoneySum_TextChanged(object sender, EventArgs e)
        {
            customer.MoneySurrender = textBoxMoneySum.Text;
        }

        private void truePurchaseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (truePurchaseBox.Checked)
            {
                customer.RealPurchase = true;
                MessageBox.Show("После перехода на сайт и заполнения формы, суши будут заказаны по настоящему!");
            }
            
            else
            {
                customer.RealPurchase = false;
                MessageBox.Show("Суши не будут заказаны (форма будет заполнена)!");
            }
        }
    }
}
