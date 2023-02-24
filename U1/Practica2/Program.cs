using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace PRACTICA2_
{
public class Form1 : Form
{
Timer temporizador = new Timer();
public Button boton1;
int movimientox = 1, movimientoy = 1;
System.Drawing.Color[] coloraleatorio = { Color.SeaShell, Color.Silver,
Color.Coral, Color.AliceBlue, Color.AntiqueWhite, Color.Aquamarine,
Color.MintCream, Color.DarkGoldenrod, Color.Gainsboro };

Form1()
{
Random random_boton = new Random();
Random random_boton2 = new Random();
this.WindowState = FormWindowState.Normal; ;
boton1 = new Button();
boton1.Size = new Size(100, 50);
boton1.Location = new Point(random_boton.Next(10,150),
random_boton2.Next(10,150));
boton1.BackColor= Color.White;
this.Text= "Boton rebotante";
this.Icon = new
Icon("C:/Users/yuitu/source/repos/U1-TADP/Practica2/Practica2/dynoav.ico"); ;
boton1.Text = " Clickie aqui ";
this.Controls.Add(boton1);
boton1.Click += new EventHandler(boton1_click);

temporizador.Interval = 1;
temporizador.Tick += boton1_Mover;
temporizador.Start();
}
private void boton1_click(object sender, EventArgs e)
{
MessageBox.Show("Event handler se encarga de esto?");
}
private void boton1_Mover(Object sender, EventArgs e)
{
Random aletoriead = new Random();
Random color = new Random();
if (boton1.Location.X > this.Width - 117)
{
movimientox = aletoriead.Next(-5, -1);
this.BackColor= coloraleatorio[color.Next(0,9)];
}
if (boton1.Location.X <1)
{
movimientox= aletoriead.Next(1,5);
this.BackColor = coloraleatorio[color.Next(0, 9)];
}
if (boton1.Location.Y > this.Height - 90)
{
movimientoy = aletoriead.Next(-5, -1);
this.BackColor = coloraleatorio[color.Next(0, 9)];
}
if (boton1.Location.Y < 1)
{
movimientoy = aletoriead.Next(1, 5);
this.BackColor = coloraleatorio[color.Next(0, 9)];
}

boton1.Location = new Point(boton1.Location.X + movimientox,

boton1.Location.Y + movimientoy);
}

static void Main(string[] args)
{
Application.EnableVisualStyles();
Application.Run(new Form1());
}
}
}