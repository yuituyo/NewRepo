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
        //Randoms
        Random numeropares = new Random(Environment.ProcessorCount);

        Timer temporizador = new Timer();

        public Button boton1, boton2, botonbot2, botonbot3, botonbot4, botonbot5;

        TextBox datosprogramado = new TextBox()
        {

            Text = "Ivan Antonio Siqueiros Valdes",
            Location = new Point(100,100),

        };

        bool generar = false;

        botontymovimiento[] botones = new botontymovimiento[200]; 
        public int cantidaddebotones=0;
        public int cantidaddebotoneslimite = 5;


        int numeroboton = 0;

        int boton1num, boton2num;

        bool botonesbot = false;

        //variables para el movimiento del boton

        int movimientox = 1, movimientoy = 1;
        int movimientox2 = 1, movimientoy2 = 1;

        //variables de los bots
        


        System.Drawing.Color[] coloraleatorio = { Color.SeaShell, Color.Silver, Color.Coral, Color.AliceBlue, Color.AntiqueWhite, Color.Aquamarine, Color.MintCream, Color.DarkGoldenrod, Color.Gainsboro };

        Form1()
        {

            this.Text = "Practica 3";

            Random random_boton = new Random(Environment.ProcessorCount);
            Random random_boton2 = new Random(Environment.TickCount);
            Random numerospares = new Random(Environment.TickCount);

            //Boton1
            this.WindowState = FormWindowState.Normal; ;
            boton1 = new Button();
            boton1.Size = new Size(100, 50);
            boton1.Location = new Point(random_boton.Next(10, this.Width-110), random_boton2.Next(10, this.Height-90));
            boton1.BackColor = Color.White;
            

            boton1.Click += new EventHandler(boton1_click);

            //Boton2
            boton2 = new Button();
            boton2.Size = new Size(100, 50);
            boton2.Location = new Point(random_boton2.Next(1, this.Width), random_boton2.Next(1, this.Height));
            boton2.Text = "2";
            boton2.BackColor = Color.White;



            this.Controls.Add(boton1);
            this.Controls.Add(boton2);


            Button button = new Button();


            temporizador.Interval = 1;
            temporizador.Tick += boton1_Mover; //restart.Tick += (object s, EventArgs a) => restart_Tick(s, a, rows, cols);
            temporizador.Tick += boton2_Mover; //void restart_Tick(object sender, EventArgs e,int rows, int cols)
            temporizador.Tick += (object sender, EventArgs e) => generarbotonesymover(botones);
            temporizador.Start();
    

        }

        public void generarbotonesymover(botontymovimiento[] botones) 
        {
            Random movimientobot = new Random(Environment.TickCount);

            if (generar == true)
            while (cantidaddebotones < cantidaddebotoneslimite)
            {
                botones[cantidaddebotones].boton = new Button() { Text = "bot" };
                botones[cantidaddebotones].boton.Location = new Point(movimientobot.Next(1, this.Width-110), movimientobot.Next(1, this.Height-90));
                botones[cantidaddebotones].movimientoy = 1;
                botones[cantidaddebotones].movimientox = 1;
                this.Controls.Add(botones[cantidaddebotones].boton); 
                cantidaddebotones++;
            }

            if(generar == true)
            cantidaddebotoneslimite = cantidaddebotoneslimite + 5;


            for (int i = 0; i < cantidaddebotones; i++)
            {
                Random aletoriedadmovimientobot = new Random(Environment.CurrentManagedThreadId);

                if (botones[i].boton.Location.X > this.Width - 117)
                {
                    botones[i].movimientox = aletoriedadmovimientobot.Next(-5, -1);

                }
                if (botones[i].boton.Location.X < 1)
                {
                    botones[i].movimientox =  aletoriedadmovimientobot.Next(1, 5);
                    
                }
                if (botones[i].boton.Location.Y > this.Height - 90)
                {
                    botones[i].movimientoy = aletoriedadmovimientobot.Next(-5, -1);
                    
                }
                if (botones[i].boton.Location.Y < 1)
                {
                    botones[i].movimientoy = aletoriedadmovimientobot.Next(1, 5);
                    

                }

                botones[i].boton.Location = new Point(botones[i].boton.Location.X + botones[i].movimientox, botones[i].boton.Location.Y + botones[i].movimientoy);

            }

        }
        

        private void boton1_click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola, este es un mensaje, y ya");


            
            Random randomlocation = new Random(Environment.TickCount);

            Button botonbot = new Button();
            botonbot.Text = "UwU";
            botonbot.Size = new Size(50, 50);

            botonbot.Location = new Point(randomlocation.Next(1, this.Width), randomlocation.Next(1, this.Height));

            botonbot.Visible = true;
            


            
            for (int i = 0; i < 4; i++)
            {
                Generar_Botones(randomlocation.Next());
            }
            
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
            Random movimientoboton1= new Random(Environment.ProcessorCount);
            Random colorboton1 = new Random(Environment.TickCount);

            if (boton1.Location.X > this.Width - 117)
            {
                movimientox = movimientoboton1.Next(-5, -1);
                this.Controls.Add(datosprogramado);
            }
            if (boton1.Location.X < 1)
            {
                movimientox = movimientoboton1.Next(4, 5);
                boton1.BackColor = coloraleatorio[colorboton1.Next(0, 9)]; ;
            }
            if (boton1.Location.Y > this.Height - 90)
            {
                movimientoy = movimientoboton1.Next(-5, -1);
                

                generar = true;
                generarbotonesymover(botones);
                generar = false;

            }
            if (boton1.Location.Y < 1)
            {
                movimientoy = movimientoboton1.Next(4, 5);
                this.BackColor = coloraleatorio[colorboton1.Next(0, 9)];

            }


            boton1.Location = new Point(boton1.Location.X + movimientox, boton1.Location.Y + movimientoy);

            int n = numeropares.Next(2, 8);
            int par = n * (n + 1);
            boton1.Text = n.ToString();

        }

        private void boton2_Mover(Object sender, EventArgs e)
        {
            //boton2

            Random movimientoboton2 = new Random(Environment.ProcessorCount);
            Random colorboton2 = new Random(Environment.ProcessorCount);
            Random numerosimpar = new Random(Environment.TickCount);

            if (boton2.Location.X > this.Width - 117)
            {
                movimientox2 = movimientoboton2.Next(-5, -1);

            }
            if (boton2.Location.X < 1)
            {
                movimientox2 = movimientoboton2.Next(3, 5);
                this.BackColor = coloraleatorio[colorboton2.Next(1,9)];
                if(datosprogramado.Enabled)
                this.Controls.Remove(datosprogramado);
            }
            if (boton2.Location.Y > this.Height - 90)
            {
                movimientoy2 = movimientoboton2.Next(-5, -1);

                int botonremovido = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (botones[i].boton != null)
                    {
                        this.Controls.Remove(botones[i].boton);
                        botonremovido++;
                    }
                    if (botonremovido == 3)
                        i = 100;
                }

            }
            if (boton2.Location.Y < 1)
            {
                movimientoy2 = movimientoboton2.Next(3, 5);
                
            }

            boton2.Location = new Point(boton2.Location.X + movimientox2, boton2.Location.Y + movimientoy2);

            int n = numerosimpar.Next(1,20);
            if (n % 2 !=0)
            {
                boton2.Text =n.ToString();
            }


        }

        public struct botontymovimiento 
        {

            public int movimientox;
            public int movimientoy;
            public Button boton;
            
        
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());


        }
    }
}
