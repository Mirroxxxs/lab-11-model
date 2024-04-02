﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace pract11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         internal class Date
         {
            int day;
            int month;
            int year;
            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            public string GetInformation()
            {
                string information;
                information = $"{this.day}.{this.month}.{this.year}";
                return information;
            }
        }
        private void append_Click(object sender, EventArgs e)
        {
            Date new_date;
            if (Day.Text == ""  || Month.Text == "" || Year.Text == "")
            {
                MessageBox.Show("Введите число");
            }
            if (Year.Text != "")
            {
                if (Year.Text.All(char.IsNumber))
                {
                   int yearValue = int.Parse(Year.Text);
                   if (yearValue > 0)
                   {
                        if(Month.Text != "")
                        {
                            if(Month.Text.All(char.IsNumber))
                            {
                                int monthValue = int.Parse(Month.Text);
                                if (monthValue >= 1 && monthValue <= 12)
                                {
                                    if (Day.Text != "")
                                    {
                                        if (Day.Text.All(char.IsNumber))
                                        {
                                            int dayValue = int.Parse(Day.Text);
                                            if (dayValue > 0 && (((monthValue == 1 || monthValue == 3 || monthValue == 5 || monthValue == 7 || monthValue == 8 || monthValue == 10  || monthValue == 11) && dayValue <= 31) ||
                                         
                                                ((monthValue == 4 || monthValue == 6 || monthValue == 9 || monthValue == 11) && dayValue <= 30) ||   ((monthValue == 2 && dayValue <= 29 && yearValue % 4 == 0) ||
                                              ((monthValue == 2 && dayValue <= 28 && yearValue % 4 != 0) )))
                                            {
                                                new_date = new Date(Convert.ToInt32(Day.Text), Convert.ToInt32(Month.Text), Convert.ToInt32(Year.Text));
                                                Result.Text = new_date.GetInformation();
                                            }
                                            else
                                            {
                                                MessageBox.Show("День не входит в диапазон");
                                            }
                                          
                                        }
                                        else
                                        {
                                            MessageBox.Show("Введите число");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Месяц не входит в диапазон");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введите число");
                            }
                        }
                   }
                   else
                   {
                        MessageBox.Show("Год не входит в диапазон");
                   }
                }
                else
                {
                    MessageBox.Show("Введите число");
                }
            }
        }
    }
}
