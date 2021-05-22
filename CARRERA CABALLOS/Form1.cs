using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARRERA_CABALLOS
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Thread hilo;
        Thread hilo2;
        Thread hilo3;
        Thread hilo4;
        Thread hilo5;
        int x;
        int o;
        int v;
        int z;
        int u;
        int velocidadchida;
        int velocidadchida2;
        int velocidadchida3;
        int velocidadchida4;
        int velocidadchida5;
        int posicion=1;
        bool vivo = true;
        bool vivo2 = true;
        bool vivo3 = true;
        bool vivo4 = true;
        bool vivo5 = true;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(caballo1);
            pictureBox1.Controls.Add(caballo2);
            pictureBox1.Controls.Add(caballo3);
            pictureBox1.Controls.Add(caballo4);
            pictureBox1.Controls.Add(caballo5);
            caballo1.Location = new Point(20, 100);
            caballo2.Location = new Point(20, 150);
            caballo3.Location = new Point(20, 200);
            caballo4.Location = new Point(20, 250);
            caballo5.Location = new Point(20, 300);
            caballo1.BackColor = Color.Transparent;
            caballo2.BackColor = Color.Transparent;
            caballo3.BackColor = Color.Transparent;
            caballo4.BackColor = Color.Transparent;
            caballo5.BackColor = Color.Transparent;
            hilo = new Thread(caballo11);
            CheckForIllegalCrossThreadCalls = false;
            hilo2 = new Thread(caballo22);
            CheckForIllegalCrossThreadCalls = false;
            hilo3 = new Thread(caballo33);
            CheckForIllegalCrossThreadCalls = false;
            hilo4 = new Thread(caballo44);
            CheckForIllegalCrossThreadCalls = false;
            hilo5 = new Thread(caballo55);
            CheckForIllegalCrossThreadCalls = false;

        }
        void caballo11()
        {
            
            int y = caballo1.Top;
            x = caballo1.Left;
            int limite = 1180;
            for (x = caballo1.Left; x < limite; x++)
            {
                velocidadchida = random.Next(0, 2);
                caballo1.Location = new Point(x, y);
                caballo1.Refresh();
                Thread.Sleep(velocidadchida);
                if (x == limite-120)
                {
                    dataGridView1.Rows.Add();
                    int cantidad = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cantidad].Value = "Caballo 1";
                    dataGridView1[1, cantidad].Value = posicion;
                    posicion++;
                    vivo = false;
                }
                if (x == limite - 1)
                {
                    hilo.Suspend();
                }
            }
        }
        void caballo22()
        {
            int y = caballo2.Top;
            z = caballo2.Left;
            int limite = 1180;
            for (z= caballo2.Left; z < limite; z++)
            {
                velocidadchida2 = random.Next(0, 2);
                caballo2.Location = new Point(z, y);
                caballo2.Refresh();
                Thread.Sleep(velocidadchida2);
                if (z == limite-120)
                {
                    dataGridView1.Rows.Add();
                    int cantidad = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cantidad].Value = "Caballo 2";
                    dataGridView1[1, cantidad].Value = posicion;
                    posicion++;
                    vivo2 = false;
                }
                if (z == limite - 1)
                {
                    hilo2.Suspend();
                }
            }

        }
        void caballo33()
        {
            int y = caballo3.Top;
            u = caballo3.Left;
            int limite = 1180;
            for (u = caballo3.Left; u < limite; u++)
            {
            velocidadchida3 = random.Next(0, 2);
                caballo3.Location = new Point(u, y);
                caballo3.Refresh();
                Thread.Sleep(velocidadchida3);
                if (u == limite-120)
                {
                    dataGridView1.Rows.Add();
                    int cantidad = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cantidad].Value = "Caballo 3";
                    dataGridView1[1, cantidad].Value = posicion;
                    posicion++;
                    vivo3 = false;
                }
                if (u == limite - 1)
                {
                    hilo3.Suspend();
                }
            }

        }
        void caballo44()
        {
            int y = caballo4.Top;
            v = caballo4.Left;
            int limite = 1180;
            for (v = caballo4.Left; v < limite; v++)
            {
            velocidadchida4 = random.Next(0, 2);
                caballo4.Location = new Point(v, y);
                caballo4.Refresh();
                Thread.Sleep(velocidadchida4);
                if (v == limite-120)
                {
                    dataGridView1.Rows.Add();
                    int cantidad = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cantidad].Value = "Caballo 4";
                    dataGridView1[1, cantidad].Value = posicion;
                    posicion++;
                    vivo4 = false;
                }
                if (v == limite - 1)
                {
                    hilo4.Suspend();
                }
            }

        }
        void caballo55()
        {
            int y = caballo5.Top;
            o = caballo5.Left;
            int limite = 1180;
            for (o = caballo5.Left; o < limite; o++)
            {
            velocidadchida5 = random.Next(0, 2);
                caballo5.Location = new Point(o, y);
                caballo5.Refresh();
                Thread.Sleep(velocidadchida5);
                if (o == limite-120)
                {
                    dataGridView1.Rows.Add();
                    int cantidad = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cantidad].Value = "Caballo 5";
                    dataGridView1[1, cantidad].Value = posicion;
                    posicion++;
                    vivo5 = false;
                }
                if (o == limite - 1)
                {
                    hilo5.Suspend();
                }
            }

        }
        /*
        void pista(PictureBox caballo, int velocidad)
        {
            int y = caballo.Top;
            int limite = 1180;
            for (; caballo.Left < limite; caballo.Left++)
            {
                caballo.Location = new Point(caballo.Left, y);
                caballo.Refresh();
                Thread.Sleep(velocidad);
            }

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            hilo.Start();
            hilo2.Start();
            hilo3.Start();
            hilo4.Start();
            hilo5.Start();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(vivo == false)
            {
                caballo1.Top = 100;
                caballo1.Left = 20;
                x = caballo1.Left;
                velocidadchida = random.Next(0, 2);
                hilo.Resume();
                vivo = true;
            }
            if (vivo2 == false)
            {
                caballo2.Top = 150;
                caballo2.Left = 20;
                z = caballo2.Left;
                velocidadchida2 = random.Next(0, 2);              
                hilo2.Resume();
                vivo2 = true;
            }
            if (vivo3 == false)
            {
                caballo3.Top = 200;
                caballo3.Left = 20;
                u = caballo3.Left;
                velocidadchida3 = random.Next(0, 2);
                hilo3.Resume();
                vivo3 = true;
            }
            if (vivo4 == false)
            {
                caballo4.Top = 250;
                caballo4.Left = 20;
                v = caballo4.Left;
                velocidadchida4 = random.Next(0, 2);
                hilo4.Resume();
                vivo4 = true;
            }
            if (vivo5 == false)
            {
                caballo5.Top = 300;
                caballo5.Left = 20;
                o = caballo5.Left;
                velocidadchida5 = random.Next(0, 2);
                hilo5.Resume();
                vivo5 = true;
            }
            hilo.Suspend();
            caballo1.Top = 100;
            caballo1.Left = 20;
            x = caballo1.Left;
            velocidadchida = random.Next(0, 2);
            hilo2.Suspend();
            caballo2.Top = 150;
            caballo2.Left = 20;
            z = caballo2.Left;
            velocidadchida2 = random.Next(0, 2);
            hilo3.Suspend();
            caballo3.Top = 200;
            caballo3.Left = 20;
            u = caballo3.Left;
            velocidadchida3 = random.Next(0, 2);
            hilo4.Suspend();
            caballo4.Top = 250;
            caballo4.Left = 20;
            v = caballo4.Left;
            velocidadchida4 = random.Next(0, 2);
            hilo5.Suspend();
            caballo5.Top = 300;
            caballo5.Left = 20;
            o = caballo5.Left;
            velocidadchida5 = random.Next(0, 2);
            pictureBox1.Refresh();
            caballo1.Refresh();
            caballo2.Refresh();
            caballo3.Refresh();
            caballo4.Refresh();
            caballo5.Refresh();
            posicion = 1;
            hilo.Resume();
            hilo2.Resume();
            hilo3.Resume();
            hilo4.Resume();
            hilo5.Resume();
        }
    }
}
