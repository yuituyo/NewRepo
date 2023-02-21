using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Pratica3
{

    //4 horas xd tuvo chido

    public class Form1 : Form
    {
        Timer temporizador = new Timer();
        public Button boton1, boton2, botonbot1, botonbot2, botonbot3, botonbot4, botonbot5;

        int boton1num, boton2num;

        bool botonesbot = false;

        //variables para el movimiento del boton

        int movimientox = 1, movimientoy = 1;
        int movimientox2 = 1, movimientoy2 = 1;

        //variables de los bots
        int movimientobotx = 1, movimientoboty = 1;
        int movimientobotx1 = 1, movimientoboty1 = 1;
        int movimientobotx2 = 1, movimientoboty2 = 1;
        int movimientobotx3 = 1, movimientoboty3 = 1;
        int movimientobotx4 = 1, movimientoboty4 = 1;


        System.Drawing.Color[] coloraleatorio = { Color.SeaShell, Color.Silver, Color.Coral, Color.AliceBlue, Color.AntiqueWhite, Color.Aquamarine, Color.MintCream, Color.DarkGoldenrod, Color.Gainsboro };

        Form1()
        {

            this.Text = "Practica 3";

            Random random_boton = new Random(Environment.ProcessorCount);
            Random random_boton2 = new Random(Environment.TickCount);

            //Boton1
            this.WindowState = FormWindowState.Normal; ;
            boton1 = new Button();
            boton1.Size = new Size(100, 50);
            boton1.Location = new Point(random_boton.Next(10, this.Width), random_boton2.Next(10, this.Height));
            boton1.BackColor = Color.White;
            boton1.Text = "1";

            boton1.Click += new EventHandler(boton1_click);

            //Boton2
            boton2 = new Button();
            boton2.Size = new Size(100, 50);
            boton2.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            boton2.Text = "2";
            boton2.BackColor = Color.White;



            this.Controls.Add(boton1);
            this.Controls.Add(boton2);




            temporizador.Interval = 1;
            temporizador.Tick += boton1_Mover;
            temporizador.Tick += boton2_Mover;


            temporizador.Start();

            //Botonesbot

            botonbot1 = new Button();
            botonbot1.Size = new Size(100, 50);
            botonbot1.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            botonbot1.Text = "Boton bot 1";
            botonbot1.BackColor = Color.LightBlue;

            botonbot2 = new Button();
            botonbot2.Size = new Size(100, 50);
            botonbot2.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            botonbot2.Text = "Boton bot 2";
            botonbot2.BackColor = Color.LightBlue;

            botonbot3 = new Button();
            botonbot3.Size = new Size(100, 50);
            botonbot3.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            botonbot3.Text = "Boton bot 3";
            botonbot3.BackColor = Color.LightBlue;

            botonbot4 = new Button();
            botonbot4.Size = new Size(100, 50);
            botonbot4.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            botonbot4.Text = "Boton bot 4";
            botonbot4.BackColor = Color.LightBlue;

            botonbot5 = new Button();
            botonbot5.Size = new Size(100, 50);
            botonbot5.Location = new Point(random_boton2.Next(1, 150), random_boton2.Next(1, 150));
            botonbot5.Text = "Boton bot 5";
            botonbot5.BackColor = Color.LightBlue;

            temporizador.Tick += botonbot1_Mover;
            temporizador.Tick += botonbot2_Mover;
            temporizador.Tick += botonbot3_Mover;
            temporizador.Tick += botonbot4_Mover;
            temporizador.Tick += botonbot5_Mover;

        }
        private void boton1_click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola, este es un mensaje, y ya");


            /*
            Random randomlocation = new Random(Environment.TickCount);

            Button botonbot = new Button();
            botonbot.Text = "UwU";
            botonbot.Size = new Size(50, 50);

            botonbot.Location = new Point(randomlocation.Next(1, this.Width), randomlocation.Next(1, this.Height));

            botonbot.Visible = true;
            */


            /*
            for (int i = 0; i < 4; i++)
            {
                Generar_Botones(randomlocation.Next());
            }
            */
        }

        private void Generar_Botones(int rnd)
        {

            Random randomlocation = new Random(rnd);

            Button botonbot = new Button();
            botonbot.Text = "UwU";
            botonbot.Size = new Size(50, 50);

            botonbot.Location = new Point(randomlocation.Next(1, this.Width), randomlocation.Next(1, this.Height));

            botonbot.Visible = true;

            this.Controls.Add(botonbot);



        }

        private void boton1_Mover(Object sender, EventArgs e)
        {
            Random movimientoboton1 = new Random(Environment.TickCount);
            Random colorboton1 = new Random(Environment.TickCount);

            if (boton1.Location.X > this.Width - 117)
            {
                movimientox = movimientoboton1.Next(-5, -1);
                this.BackColor = coloraleatorio[colorboton1.Next(0, 9)];
            }
            if (boton1.Location.X < 1)
            {
                movimientox = movimientoboton1.Next(1, 5);
                this.BackColor = coloraleatorio[colorboton1.Next(0, 9)];
            }
            if (boton1.Location.Y > this.Height - 90)
            {
                movimientoy = movimientoboton1.Next(-5, -1);
                this.BackColor = coloraleatorio[colorboton1.Next(0, 9)];

                //agregar botones cuando toque abajo

                if (botonesbot == false)
                {
                    botonesbot = true;

                    this.Controls.Add(botonbot1);
                    this.Controls.Add(botonbot2);
                    this.Controls.Add(botonbot3);
                    this.Controls.Add(botonbot4);
                    this.Controls.Add(botonbot5);
                }
                else
                {
                    this.Controls.Remove(botonbot1);
                    this.Controls.Remove(botonbot2);
                    this.Controls.Remove(botonbot3);
                    this.Controls.Remove(botonbot4);
                    this.Controls.Remove(botonbot5);
                    botonesbot = false;
                }

            }
            if (boton1.Location.Y < 1)
            {
                movimientoy = movimientoboton1.Next(1, 5);
                this.BackColor = coloraleatorio[colorboton1.Next(0, 9)];

            }

            boton1.Location = new Point(boton1.Location.X + movimientox, boton1.Location.Y + movimientoy);


            boton1num = int.Parse(boton1.Text) + int.Parse(boton2.Text);
            string resultado = boton1num.ToString();

            if (boton1.Bounds.IntersectsWith(boton2.Bounds))
            {
                boton1.Text = resultado;
            }
        }

        private void boton2_Mover(Object sender, EventArgs e)
        {
            //boton2

            Random movimientoboton2 = new Random(Environment.ProcessorCount);
            Random colorboton2 = new Random(Environment.ProcessorCount);

            if (boton2.Location.X > this.Width - 117)
            {
                movimientox2 = movimientoboton2.Next(-5, -1);

            }
            if (boton2.Location.X < 1)
            {
                movimientox2 = movimientoboton2.Next(1, 5);

            }
            if (boton2.Location.Y > this.Height - 90)
            {
                movimientoy2 = movimientoboton2.Next(-5, -1);

            }
            if (boton2.Location.Y < 1)
            {
                movimientoy2 = movimientoboton2.Next(1, 5);

            }

            boton2.Location = new Point(boton2.Location.X + movimientox2, boton2.Location.Y + movimientoy2);


        }

        private void botonbot1_Mover(Object sender, EventArgs e)
        {
            //boton2

            Random movimientoboton = new Random(Environment.ProcessorCount);
            Random colorboton = new Random(Environment.ProcessorCount);

            if (botonbot1.Location.X > this.Width - 117)
            {
                movimientobotx = movimientoboton.Next(-5, -1);

            }
            if (botonbot1.Location.X < 1)
            {
                movimientobotx = movimientoboton.Next(1, 5);

            }
            if (botonbot1.Location.Y > this.Height - 90)
            {
                movimientoboty = movimientoboton.Next(-5, -1);

            }
            if (botonbot1.Location.Y < 1)
            {
                movimientoboty = movimientoboton.Next(1, 5);

            }

            botonbot1.Location = new Point(botonbot1.Location.X + movimientobotx, botonbot1.Location.Y + movimientoboty);


        }

        private void botonbot2_Mover(Object sender, EventArgs e)
        {
            Random movimientoboton = new Random(Environment.ProcessorCount);
            Random colorboton = new Random(Environment.ProcessorCount);

            if (botonbot2.Location.X > this.Width - 117)
            {
                movimientobotx1 = movimientoboton.Next(-5, -1);

            }
            if (botonbot2.Location.X < 1)
            {
                movimientobotx1 = movimientoboton.Next(1, 5);

            }
            if (botonbot2.Location.Y > this.Height - 90)
            {
                movimientoboty1 = movimientoboton.Next(-5, -1);

            }
            if (botonbot2.Location.Y < 1)
            {
                movimientoboty1 = movimientoboton.Next(1, 5);

            }

            botonbot2.Location = new Point(botonbot2.Location.X + movimientobotx1, botonbot2.Location.Y + movimientoboty1);


        }

        private void botonbot3_Mover(Object sender, EventArgs e)
        {
            Random movimientoboton = new Random(Environment.ProcessorCount);
            Random colorboton = new Random(Environment.ProcessorCount);

            if (botonbot3.Location.X > this.Width - 117)
            {
                movimientobotx2 = movimientoboton.Next(-5, -1);

            }
            if (botonbot3.Location.X < 1)
            {
                movimientobotx2 = movimientoboton.Next(1, 5);

            }
            if (botonbot3.Location.Y > this.Height - 90)
            {
                movimientoboty2 = movimientoboton.Next(-5, -1);

            }
            if (botonbot3.Location.Y < 1)
            {
                movimientoboty2 = movimientoboton.Next(1, 5);

            }

            botonbot3.Location = new Point(botonbot3.Location.X + movimientobotx2, botonbot3.Location.Y + movimientoboty2);


        }

        private void botonbot4_Mover(Object sender, EventArgs e)
        {
            Random movimientoboton = new Random(Environment.ProcessorCount);
            Random colorboton = new Random(Environment.ProcessorCount);

            if (botonbot4.Location.X > this.Width - 117)
            {
                movimientobotx3 = movimientoboton.Next(-5, -1);

            }
            if (botonbot4.Location.X < 1)
            {
                movimientobotx3 = movimientoboton.Next(1, 5);

            }
            if (botonbot4.Location.Y > this.Height - 90)
            {
                movimientoboty3 = movimientoboton.Next(-5, -1);

            }
            if (botonbot4.Location.Y < 1)
            {
                movimientoboty3 = movimientoboton.Next(1, 5);

            }

            botonbot4.Location = new Point(botonbot4.Location.X + movimientobotx3, botonbot4.Location.Y + movimientoboty3);


        }

        private void botonbot5_Mover(Object sender, EventArgs e)
        {
            Random movimientoboton = new Random(Environment.ProcessorCount);
            Random colorboton = new Random(Environment.ProcessorCount);

            if (botonbot5.Location.X > this.Width - 117)
            {
                movimientobotx4 = movimientoboton.Next(-5, -1);

            }
            if (botonbot5.Location.X < 1)
            {
                movimientobotx4 = movimientoboton.Next(1, 5);

            }
            if (botonbot5.Location.Y > this.Height - 90)
            {
                movimientoboty4 = movimientoboton.Next(-5, -1);

            }
            if (botonbot5.Location.Y < 1)
            {
                movimientoboty4 = movimientoboton.Next(1, 5);

            }

            botonbot5.Location = new Point(botonbot5.Location.X + movimientobotx4, botonbot5.Location.Y + movimientoboty4);


        }


        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());


        }
    }
}
