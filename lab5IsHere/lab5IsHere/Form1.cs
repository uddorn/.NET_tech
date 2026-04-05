using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab5IsHere
{
    [Serializable]
    public class Rhombus
    {
        public float A { get; set; }
        public float B { get; set; }

        public Rhombus()
        {
            A = 0;
            B = 0;
        }

        public Rhombus(float a, float b)
        {
            A = a;
            B = b;
        }

        public void Draw(Graphics g, float width, float height)
        {
            g.Clear(Color.White);

            if (A <= 0 || B <= 0) return;

            float centerX = width / 2;
            float centerY = height / 2;

            PointF[] points = {
                new PointF(centerX, centerY - B / 2),
                new PointF(centerX + A / 2, centerY),
                new PointF(centerX, centerY + B / 2),
                new PointF(centerX - A / 2, centerY)
            };

            Pen pen = new Pen(Color.Blue, 2);
            g.DrawPolygon(pen, points);

            g.DrawLine(Pens.Gray, centerX - A / 2, centerY, centerX + A / 2, centerY);
            g.DrawLine(Pens.Gray, centerX, centerY - B / 2, centerX, centerY + B / 2);
        }
    }

    public partial class Form1 : Form
    {
        Rhombus myRhombus = new Rhombus();

        public Form1()
        {
            InitializeComponent();

            btnSaveXML.Click += BtnSaveXML_Click;
            btnLoadXML.Click += BtnLoadXML_Click;
            btnSaveBinary.Click += BtnSaveBinary_Click;
            btnLoadBinary.Click += BtnLoadBinary_Click;
            btnDraw.Click += BtnDraw_Click;
            btnReflect.Click += BtnReflect_Click;
        }

        private void UpdateObject()
        {
            float a, b;
            float.TryParse(txtA.Text, out a);
            float.TryParse(txtB.Text, out b);
            myRhombus = new Rhombus(a, b);
        }

        private void UpdateUI()
        {
            txtA.Text = myRhombus.A.ToString();
            txtB.Text = myRhombus.B.ToString();
        }

        private void BtnSaveXML_Click(object sender, EventArgs e)
        {
            UpdateObject();

            XmlSerializer formatter = new XmlSerializer(typeof(Rhombus));
            using (FileStream fs = new FileStream("rhombus.xml", FileMode.Create))
            {
                formatter.Serialize(fs, myRhombus);
            }

            MessageBox.Show("Збережено в XML!");
        }

        private void BtnLoadXML_Click(object sender, EventArgs e)
        {
            if (File.Exists("rhombus.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Rhombus));
                using (FileStream fs = new FileStream("rhombus.xml", FileMode.Open))
                {
                    myRhombus = (Rhombus)formatter.Deserialize(fs);
                }
                UpdateUI();
                MessageBox.Show("Завантажено з XML!");
            }
        }

        private void BtnSaveBinary_Click(object sender, EventArgs e)
        {
            UpdateObject();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("rhombus.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, myRhombus);
            }
            MessageBox.Show("Збережено в Binary!");
        }

        private void BtnLoadBinary_Click(object sender, EventArgs e)
        {
            if (File.Exists("rhombus.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("rhombus.dat", FileMode.Open))
                {
                    myRhombus = (Rhombus)formatter.Deserialize(fs);
                }
                UpdateUI();
                MessageBox.Show("Завантажено з Binary!");
            }
        }

        private void BtnReflect_Click(object sender, EventArgs e)
        {
            txtReflection.Clear();
            Type t = typeof(Rhombus);

            txtReflection.AppendText($"Інформація про клас {t.Name} \r\n\r\n");

            txtReflection.AppendText("Властивості\r\n");
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo p in props)
            {
                txtReflection.AppendText($"{p.PropertyType.Name} {p.Name}\r\n");
            }

            txtReflection.AppendText("\r\nМетоди \r\n");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo m in methods)
            {
                txtReflection.AppendText($"{m.ReturnType.Name} {m.Name}(...)\r\n");
            }

            txtReflection.AppendText("\r\nКонструктори\r\n");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo c in constructors)
            {
                txtReflection.AppendText($"{c.ToString()}\r\n");
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            UpdateObject();

            Graphics g = pictureBox1.CreateGraphics();
            myRhombus.Draw(g, pictureBox1.Width, pictureBox1.Height);
        }
    }
}