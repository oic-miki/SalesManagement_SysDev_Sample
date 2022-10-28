using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class Form1 : Form
    {

        private Decimal heightRatio;
        private Decimal widthRatio;

        private Person person;

        private List<Panel> panels = new List<Panel>();

        public Form1(F_Login fLogin)
        {

            InitializeComponent();

            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);

            hidePanels();

            button1.Text = "名前を変更する";
            button2.Text = "年齢を変更する";
            button3.Text = "情報を削除する";

            button4.Text = "名前を変更";
            button5.Text = "年齢を変更";
            button6.Text = "情報を削除";

            person = fLogin.getPerson();

            label1.addPerson(person);
            label2.addPerson(person);
            //            label1.Text = person.getName();

            //            changeScreenSize();

        }

        private void changeScreenSize()
        {

            Decimal screenHeight = new Decimal(Screen.PrimaryScreen.Bounds.Height);
            Decimal screenWidth = new Decimal(Screen.PrimaryScreen.Bounds.Width);

            heightRatio = Decimal.Divide(screenHeight, new Decimal(this.Height));
            widthRatio = Decimal.Divide(screenWidth, new Decimal(this.Width));

            this.Height = Decimal.ToInt32(Decimal.Round(
                Decimal.Multiply(new Decimal(this.Height), heightRatio), 2));

            panel1.Height = Decimal.ToInt32(Decimal.Round(
                Decimal.Multiply(new Decimal(panel1.Height), heightRatio), 2));

            List<Button> buttons = new List<Button>();

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);

            foreach (Button button in buttons)
            {

                button.Height = Decimal.ToInt32(Decimal.Round(
                    Decimal.Multiply(new Decimal(button.Height), heightRatio), 2));

            }

        }

        private void hidePanels()
        {

            foreach(Panel panel in panels)
            {

                panel.Hide();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            hidePanels();

            panel1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            hidePanels();

            panel2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            hidePanels();

            panel3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            person.setName(textBox1.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {

                person.setAge(Int16.Parse(textBox2.Text));

            }
            catch (FormatException fe)
            {

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            person.setName("");
            person.setAge(0);
            //this.Hide();

        }
    }
}
