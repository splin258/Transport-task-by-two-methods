using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO_ind
{
    public partial class Form1 : Form
    {
        List<List<int>> Price = new List<List<int>>();
        List<int> Zapas = new List<int>();
        List<int> Potr = new List<int>();
        List<List<int>> res = new List<List<int>>();
        public bool Save = false;
        public int summ = 0;
        public Form1()
        {
            InitializeComponent();
            res.Add(new List<int>());
            res.Add(new List<int>());
            res.Add(new List<int>());
            res.Add(new List<int>());
            res.Add(new List<int>());
            res.Add(new List<int>());

            Price.Add(new List<int>());
            Price.Add(new List<int>());
            Price.Add(new List<int>());
            Price.Add(new List<int>());
            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    res[i].Add(0);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (priceA1_B1.Text != "" || priceA2_B1.Text != "" || priceA3_B1.Text != "" || priceA4_B1.Text != "" || priceA5_B1.Text != "" || priceA6_B1.Text != "")
            {
                try
                {
                    Price[0].Add(Convert.ToInt32(priceA1_B1.Text));
                    Price[0].Add(Convert.ToInt32(priceA2_B1.Text));
                    Price[0].Add(Convert.ToInt32(priceA3_B1.Text));
                    Price[0].Add(Convert.ToInt32(priceA4_B1.Text));
                    Price[0].Add(Convert.ToInt32(priceA5_B1.Text));
                    Price[0].Add(Convert.ToInt32(priceA6_B1.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей цены для строки B1 ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля цены заполнены для строки B1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (priceA1_B2.Text != "" || priceA2_B2.Text != "" || priceA3_B2.Text != "" || priceA4_B2.Text != "" || priceA5_B2.Text != "" || priceA6_B2.Text != "")
            {
                try
                {
                    Price[1].Add(Convert.ToInt32(priceA1_B2.Text));
                    Price[1].Add(Convert.ToInt32(priceA2_B2.Text));
                    Price[1].Add(Convert.ToInt32(priceA3_B2.Text));
                    Price[1].Add(Convert.ToInt32(priceA4_B2.Text));
                    Price[1].Add(Convert.ToInt32(priceA5_B2.Text));
                    Price[1].Add(Convert.ToInt32(priceA6_B2.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей цены для строки B2 ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля цены заполнены для строки B2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (priceA1_B3.Text != "" || priceA2_B3.Text != "" || priceA3_B3.Text != "" || priceA4_B3.Text != "" || priceA5_B3.Text != "" || priceA6_B3.Text != "")
            {
                try
                {
                    Price[2].Add(Convert.ToInt32(priceA1_B3.Text));
                    Price[2].Add(Convert.ToInt32(priceA2_B3.Text));
                    Price[2].Add(Convert.ToInt32(priceA3_B3.Text));
                    Price[2].Add(Convert.ToInt32(priceA4_B3.Text));
                    Price[2].Add(Convert.ToInt32(priceA5_B3.Text));
                    Price[2].Add(Convert.ToInt32(priceA6_B3.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей цены для строки B3 ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля цены заполнены для строки B3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (priceA1_B4.Text != "" || priceA2_B4.Text != "" || priceA3_B4.Text != "" || priceA4_B4.Text != "" || priceA5_B4.Text != "" || priceA6_B4.Text != "")
            {
                try
                {
                    Price[3].Add(Convert.ToInt32(priceA1_B4.Text));
                    Price[3].Add(Convert.ToInt32(priceA2_B4.Text));
                    Price[3].Add(Convert.ToInt32(priceA3_B4.Text));
                    Price[3].Add(Convert.ToInt32(priceA4_B4.Text));
                    Price[3].Add(Convert.ToInt32(priceA5_B4.Text));
                    Price[3].Add(Convert.ToInt32(priceA6_B4.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей цены для строки B1 ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля цены заполнены для строки B4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (Zap1.Text != "" || Zap3.Text != "" || Zap4.Text != "" || Zap2.Text != "")
            {
                try
                {
                    Zapas.Add(Convert.ToInt32(Zap1.Text));
                    Zapas.Add(Convert.ToInt32(Zap2.Text));
                    Zapas.Add(Convert.ToInt32(Zap3.Text));
                    Zapas.Add(Convert.ToInt32(Zap4.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей столбца запасов ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля столбца запасов заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (potr1.Text != "" || potr2.Text != "" || potr3.Text != "" || potr4.Text != "" || potr5.Text != "" || potr6.Text != "")
            {
                try
                {
                    Potr.Add(Convert.ToInt32(potr1.Text));
                    Potr.Add(Convert.ToInt32(potr2.Text));
                    Potr.Add(Convert.ToInt32(potr3.Text));
                    Potr.Add(Convert.ToInt32(potr4.Text));
                    Potr.Add(Convert.ToInt32(potr5.Text));
                    Potr.Add(Convert.ToInt32(potr6.Text));
                }
                catch
                {
                    MessageBox.Show("В одном из полей строки потребностей ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Save = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не все поля строки потребностей заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            if (Potr[0] + Potr[1] + Potr[2] + Potr[3] + Potr[4] + Potr[5] != Zapas[0] + Zapas[1] + Zapas[2] + Zapas[3])
            {
                MessageBox.Show("Задача не сбалансированная", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Save = false;
                return;
            }
            Save = true;
        }
        private int min(int min1, int min2, int min3, int min4)
        {
            if (min1 < min2 && min1 < min3 && min1 < min4)
            {
                return min1;
            }
            if (min2 < min1 && min2 < min3 && min2 < min4)
            {
                return min2;
            }
            if(min3 < min1 && min3 < min2 && min3 < min4)
            {
                return min3;
            }
            return min4;
        }
        private void output()
        {
            res_prod_A1_B1.Text = res[0][0].ToString();
            res_prod_A2_B1.Text = res[1][0].ToString();
            res_prod_A3_B1.Text = res[2][0].ToString();
            res_prod_A4_B1.Text = res[3][0].ToString();
            res_prod_A5_B1.Text = res[4][0].ToString();
            res_prod_A6_B1.Text = res[5][0].ToString();
            res_prod_A1_B2.Text = res[0][1].ToString();
            res_prod_A2_B2.Text = res[1][1].ToString();
            res_prod_A3_B2.Text = res[2][1].ToString();
            res_prod_A4_B2.Text = res[3][1].ToString();
            res_prod_A5_B2.Text = res[4][1].ToString();
            res_prod_A6_B2.Text = res[5][1].ToString();
            res_prod_A1_B3.Text = res[0][2].ToString();
            res_prod_A2_B3.Text = res[1][2].ToString();
            res_prod_A3_B3.Text = res[2][2].ToString();
            res_prod_A4_B3.Text = res[3][2].ToString();
            res_prod_A5_B3.Text = res[4][2].ToString();
            res_prod_A6_B3.Text = res[5][2].ToString();
            res_prod_A1_B4.Text = res[0][3].ToString();
            res_prod_A2_B4.Text = res[1][3].ToString();
            res_prod_A3_B4.Text = res[2][3].ToString();
            res_prod_A4_B4.Text = res[3][3].ToString();
            res_prod_A5_B4.Text = res[4][3].ToString();
            res_prod_A6_B4.Text = res[5][3].ToString();

            summa.Text = "Summ = " + summ.ToString();
            PotrA1.Text = Potr[0].ToString();
            PotrA2.Text = Potr[1].ToString();
            PotrA3.Text = Potr[2].ToString();
            PotrA4.Text = Potr[3].ToString();
            PotrA5.Text = Potr[4].ToString();
            PotrA6.Text = Potr[5].ToString();

            ZapB1.Text = Zapas[0].ToString();
            ZapB2.Text = Zapas[1].ToString();
            ZapB3.Text = Zapas[2].ToString();
            ZapB4.Text = Zapas[3].ToString();
        }

        private List<int> copy(int[] mas, List<int> vs)
        {
          
            for (int i = 0; i < mas.Count(); i++)
            {
                vs.Add(mas[i]);
            }
            return vs;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            if (Save != false)
            {
                if (Metod.Text == "Метод «северо-западного угла»")
                {
                    int[] _Zapas = {0,0,0,0};
                    Zapas.CopyTo(_Zapas);
                    int[] _Potr = {0,0,0,0,0,0 };
                    Potr.CopyTo(_Potr);
                    int num_zap = 0;
                    int num_mag = 0;
                    while (true)
                    {


                        if (_Zapas[num_zap] >= _Potr[num_mag])
                        {
                            res[num_mag][num_zap] = _Potr[num_mag];
                            summ += res[num_mag][num_zap] * Price[num_zap][num_mag];
                            _Zapas[num_zap] = _Zapas[num_zap] - _Potr[num_mag];
                            _Potr[num_mag] = 0;
                            num_mag++;
                            if (_Zapas[3] == 0) break;
                            if (_Zapas[num_zap] == 0)
                                num_zap++;
                            if (_Potr[num_mag] == 0)
                                num_mag++;
                        }
                        else
                        {
                            res[num_mag][num_zap] = _Zapas[num_zap];
                            summ += res[num_mag][num_zap] * Price[num_zap][num_mag];
                            _Potr[num_mag] = _Potr[num_mag] - _Zapas[num_zap];
                            _Zapas[num_zap] = 0;
                            num_zap++;
                            if (_Zapas[3] == 0) break;
                            if (_Zapas[num_zap] == 0)
                                num_zap++;
                            if (_Potr[num_mag] == 0)
                                num_mag++;
                        }
                    }
                    output();
                }
                else
                {
                    if (Metod.Text == "Метод «минимального элемента»")
                    {
                        int[] _Zapas = { 0, 0, 0, 0 };
                        Zapas.CopyTo(_Zapas);
                        int[] _Potr = { 0, 0, 0, 0, 0, 0 };
                        Potr.CopyTo(_Potr);
                        int min, index_min, num_mag = 0, num_zap = 0;
                        int[] _price = { 0, 0, 0, 0, 0, 0 };
                        Price[0].CopyTo(_price);
                        List<int> pr = new List<int>();
                        pr = copy(_price, pr);
                        min = Price[0].Min();
                        index_min = Price[0].IndexOf(min);
                        while (true)
                        {
                            
                            if (_Zapas[num_zap] >= _Potr[index_min])
                            {
                                res[index_min][num_zap] = _Potr[num_zap];
                                summ += res[index_min][num_zap] * Price[num_zap][index_min];
                                _Zapas[num_zap] = _Zapas[num_zap] - _Potr[index_min];
                                _Potr[index_min] = 0;
                                if (_Zapas[num_zap] == 0)
                                {
                                    num_zap++;
                                    if(num_zap>4)
                                    {
                                        return;
                                    }
                                }
                                if(_Potr[index_min] == 0)
                                {
                                    
                                pr.RemoveAt(index_min);
                                    min = pr.Min();

                                    index_min = Price[0].IndexOf(min);
                                }
                                
                            }
                            else
                            {
                                res[0][num_zap] = _Zapas[0];
                                summ += res[0][num_zap] * Price[0][num_zap];
                                _Potr[0] = _Potr[num_zap] - _Zapas[0];
                                _Zapas[0] = 0;
                                if (_Zapas[num_zap] == 0)
                                {
                                    num_zap++;
                                    if (num_zap > 4)
                                    {
                                        return;
                                    }
                                }
                                if (_Potr[index_min] == 0)
                                {

                                    pr.RemoveAt(index_min);
                                    min = pr.Min();

                                    index_min = Price[0].IndexOf(min);
                                }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбирете метод", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
            }
        }
    }
}
