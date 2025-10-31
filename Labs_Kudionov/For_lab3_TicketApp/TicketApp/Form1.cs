using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelInstruction.Visible = false;

            // Сгенерировать билет
            int ticketNumber = random.Next(0, 1000000); // 0–999999
            string ticket = ticketNumber.ToString("D6"); // Дополнить нулями слева

            // Показать билет
            labelTicket.Text = ticket;
            labelTicket.Visible = true;

            // Проверка счастливости
            bool isLucky = IsLucky(ticket);

            // Отобразить результат с цветом
            labelResult.Visible = true;
            if (isLucky)
            {
                labelResult.Text = "Счастливый билет!";
                labelResult.ForeColor = Color.Green;
                labelTicket.ForeColor = Color.Green;
            }
            else
            {
                labelResult.Text = "Обычный билет.";
                labelResult.ForeColor = Color.Red;
                labelTicket.ForeColor = Color.Red;
            }
        }
        private bool IsLucky(string ticket)
        {
            int sumFirst = (ticket[0] - '0') + (ticket[1] - '0') + (ticket[2] - '0');
            int sumLast = (ticket[3] - '0') + (ticket[4] - '0') + (ticket[5] - '0');
            return sumFirst == sumLast;
        }
    }
}
