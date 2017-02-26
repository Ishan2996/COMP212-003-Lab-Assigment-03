using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Ex03
{
    public partial class Ex03 : Form
    {

        bool isNumeric = false;
        Random rnd = new Random();
        List<int> intList = new List<int>();
        List<double> dList = new List<double>();
        int a;
        double b;
        public Ex03()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = rnd.Next(1, 50);
            intList.Add(a);

            textBox1.Text = a.ToString();
            isNumeric = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = rnd.NextDouble();
            b = System.Math.Round(b, 2);
            dList.Add(b);
            textBox2.Text = b.ToString("0.00");
            isNumeric = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isNumeric == false && dList.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            else
            {
                Console.Write("Array intArray contains: ");

                String value = textBox3.Text;

                

                if (isNumeric == true)
                {
                    int val = Int32.Parse(value);


                    var q = DisplayArray(intList, val); // pass an int array argument

                    if (q == 0)
                    {
                        q = -1;
                    }
                    else
                    {
                        q = q - 1;
                    }
                    textBox4.Text = q.ToString();

                }
                else
                {
                    //Debug.WriteLine(dList);
                    double dval = Convert.ToDouble(value);
                    var t = DisplayArray(dList, dval); // pass a double array argument
                    Console.Write("Array charArray contains: ");
                    if (t == 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = t - 1;
                    }
                    textBox4.Text = t.ToString("0.00");
                }
            }
        }
            

             private static T DisplayArray<T>(List<T> inputArray, T value) where T : IComparable<T>
            {
            int count = 0;
            foreach (var element in inputArray)
            {
                count++;
                if (element.CompareTo(value) == 0)
                {

                    return (T)Convert.ChangeType(count, typeof(T));
                }

            }

            return default(T);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNumeric == true)
            {
                listBox1.DataSource = null;
                listBox1.DataSource = intList;
            }
            else
            {
                listBox1.DataSource = null;
                listBox1.DataSource = dList;

            }
        }

        private void Ex03_Load(object sender, EventArgs e)
        {

        }
    }
    }

