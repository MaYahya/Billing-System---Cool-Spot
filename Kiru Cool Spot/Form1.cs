using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kiru_Cool_Spot
{
    public partial class Form1 : Form
    {
        private int rowIndex = 0;
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Qty";
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[1].Width = 20;
        }

        private int GetExistingRowIndex(string labelText)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == labelText)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private int GetColumn2Sum()
        {
    sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    sum += (int)row.Cells[2].Value;
                }
            }
            return sum;

        }

        private void Clickss(Panel panel, int b)
        {


            string labelText = panel.Controls.OfType<Label>().FirstOrDefault()?.Text;
            if (!string.IsNullOrEmpty(labelText))
            {
                int existingRowIndex = GetExistingRowIndex(labelText);
                if (existingRowIndex != -1)
                {
                    // If a row already exists for the label text, increment the click count.
                    int clickCount = (int)dataGridView1.Rows[existingRowIndex].Cells[1].Value;
                    dataGridView1.Rows[existingRowIndex].Cells[1].Value = clickCount + 1;
                    dataGridView1.Rows[existingRowIndex].Cells[2].Value = (clickCount + 1) * b;
                }
                else
                {
                    // Otherwise, add a new row with the label text and click count of 1.
                    rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = labelText;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = 1;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = b;
                    rowIndex++;
                }



            }

            int sum = GetColumn2Sum();
            label20.Text = sum.ToString() + ".00 LKR";

        }


       

        private void panel8_Click(object sender, EventArgs e)
        {
            Clickss(panel24, 790);
        }

        private void button12_Click(object sender, EventArgs e)
        {


           
                if (dataGridView1.Rows.Count > 0)
                {
                    // Remove last row
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

                    // Subtract value from total sum
                    int sum = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sum += int.Parse(row.Cells[2].Value.ToString());
                    }
                    label20.Text = sum.ToString()+".00 LKR";
                }
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label20.Text = "0.00 LKR";
            label4.Text = "0.00 LKR";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double aa = double.Parse(textBox1.Text);
            label4.Text = (aa-sum).ToString()+".00 LKR";
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Clickss(panel9, 260);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Clickss(panel10, 1350);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Clickss(panel10, 1350);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            Clickss(panel11, 2350);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            Clickss(panel12, 150);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            Clickss(panel13, 190);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            Clickss(panel14, 110);
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            Clickss(panel15, 250);
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Clickss(panel11, 2350);
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            Clickss(panel20, 300);
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            Clickss(panel16, 500);
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            Clickss(panel17, 550);
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            Clickss(panel18, 650);
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            Clickss(panel19, 750);
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            Clickss(panel21, 850);
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            Clickss(panel24, 790);
        }

        private void panel8_Click_1(object sender, EventArgs e)
        {
            Clickss(panel8, 650);
        }



        private void Hideoption()
        {
            for (int i = 8; i <= 15; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }

            for (int i = 25; i <= 36; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }

            for (int i = 16; i <= 24; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }

        }


        private void juiceBtn_Click(object sender, EventArgs e)
        {
            Hideoption();
        }

        private void iceBtn_Click(object sender, EventArgs e)
        {
            for (int i = 8; i <= 24; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }

            for (int i = 25; i <= 36; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }
        }

        private void cakesBtn_Click(object sender, EventArgs e)
        {
            for (int i = 16; i <= 36; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }

            for (int i = 8; i <= 15; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 8; i <= 36; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();

                }
            }
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            Clickss(panel22, 350);
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            Clickss(panel23, 150);
        }

        private void panel36_Click(object sender, EventArgs e)
        {
            Clickss(panel36, 570);
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            Clickss(panel25, 120);
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            Clickss(panel26, 400);
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            Clickss(panel27, 350);
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            Clickss(panel28, 410);
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            Clickss(panel29, 90);
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            Clickss(panel30, 500);
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            Clickss(panel31, 710);
        }

        private void panel32_Click(object sender, EventArgs e)
        {
            Clickss(panel32, 440);
        }

        private void panel33_Click(object sender, EventArgs e)
        {
            Clickss(panel33, 390);
        }

        private void panel34_Click(object sender, EventArgs e)
        {
            Clickss(panel34, 950);
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            Clickss(panel35,250);
        }
    }
}
