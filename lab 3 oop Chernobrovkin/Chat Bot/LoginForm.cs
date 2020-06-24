using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Chat_Bot
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Если нажата ЛКМ
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EntryField.Text == "")
            {
                MessageBox.Show("Вы не ввели имя");
            } else
            {
                ChatForm frm = new ChatForm();
                frm.bot.LoadHistory(EntryField.Text);
                frm.Show();
                frm.RestoreChat();
                this.Hide();
            }
        }


        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                LoginButton_Click(LoginButton, null);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EntryField.ResetText();  
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
