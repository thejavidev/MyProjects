using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers
{
    public partial class Form1 : Form
    {

        int turno = 0;
        bool moveExtra = false;
        PictureBox seleccionado = null;
        List<PictureBox> azules = new List<PictureBox>();
        List<PictureBox> rojas = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            cargarListas();
        }
        private void cargarListas()
        {
            azules.Add(azul1);
            azules.Add(azul2);
            azules.Add(azul3);
            azules.Add(azul4);
            azules.Add(azul5);
            azules.Add(azul6);
            azules.Add(azul7);
            azules.Add(azul8);
            azules.Add(azul9);
            azules.Add(azul10);
            azules.Add(azul11);
            azules.Add(azul12);

            rojas.Add(roja1);
            rojas.Add(roja2);
            rojas.Add(roja3);
            rojas.Add(roja4);
            rojas.Add(roja5);
            rojas.Add(roja6);
            rojas.Add(roja7);
            rojas.Add(roja8);
            rojas.Add(roja9);
            rojas.Add(roja10);
            rojas.Add(roja11);
            rojas.Add(roja12);

        }
        public void seleccion (object objeto)
        {
            if (!moveExtra )
            {try { seleccionado.BackColor = Color.Black; }
             catch (Exception) { }
            PictureBox finca = (PictureBox)objeto;
            seleccionado = finca;
            seleccionado.BackColor = Color.Lime;
            }
        }
        private void cuadroClick(object sender, MouseEventArgs e)
        {
            movimento((PictureBox)sender);
        }

        private void movimento(PictureBox cuadro)
        {
            if (seleccionado != null)
            {
                string color = seleccionado.Name.ToString().Substring(0, 4);
                if (validacion(seleccionado,cuadro,color))
                {
                   
                    Point anterior = seleccionado.Location;
                    seleccionado.Location = cuadro.Location;
                    int avance = anterior.Y - cuadro.Location.Y;

                    if (!movimientosExtras (color)| Math .Abs (avance )==50)
                    {
                        ifqueen(color);
                        turno++;
                        seleccionado.BackColor = Color.Black;
                        seleccionado = null;
                        moveExtra = false;
                    }
                    else {
                         moveExtra = true;
                         }
                }
            }
        }

        private bool movimientosExtras (string color)
        {
            List<PictureBox> bandoContario = color == "roja" ? azules : rojas;
            List<Point> posiciones = new List<Point>();
            int sigPosicion = color == "roja" ? -100 : 100;

            posiciones.Add(new Point(seleccionado.Location.X + 100, seleccionado.Location.Y + sigPosicion));
            posiciones.Add(new Point(seleccionado.Location.X - 100, seleccionado.Location.Y + sigPosicion));
            if (seleccionado .Tag =="queen")
            {
                posiciones.Add(new Point(seleccionado.Location.X + 100, seleccionado.Location.Y - sigPosicion));
                posiciones.Add(new Point(seleccionado.Location.X - 100, seleccionado.Location.Y - sigPosicion));
            }
            bool resultado = false;
            for (int i = 0; i < posiciones.Count ; i++)
            {
                if (posiciones [i].X >=50 &&posiciones [i].X <=400 &&posiciones [i].Y >=50 &&posiciones[i].Y <=400)
                {
                    if (!ocupado (posiciones [i],rojas) && !ocupado(posiciones[i],azules ))
                    {
                        Point puntoMedio = new Point(promedio(posiciones[i].X, seleccionado.Location.X), promedio(posiciones[i].Y, seleccionado.Location.Y));
                        if (ocupado (puntoMedio ,bandoContario ))
                        {
                            resultado = true;
                        }

                    }
                }
            }
            return resultado;
        }
        private bool ocupado(Point punto,List<PictureBox >bando)
        {
            for (int i = 0; i < bando .Count ; i++)
            {
                if (punto ==bando[i].Location )
                {
                    return true;
                }
            }
            return false;
        }

        private int promedio(int n1,int n2)
        {
            int resultado = n1 + n2;
            resultado = resultado / 2;
            return Math.Abs(resultado);

        }


        private bool validacion(PictureBox origen,PictureBox destino,string color)
        {
            Point puntoOrgen = origen.Location;
            Point puntoDestino = destino.Location;
            int avance = puntoOrgen.Y - puntoDestino.Y;
            avance = color == "roja" ? avance : (avance * -1);
            avance = seleccionado.Tag == "queen" ? Math.Abs(avance) : avance;
            if (avance ==50)
            {
                return true;
            }else if(avance ==100)
            {
                Point puntoMedio = new Point(promedio(puntoDestino.X, puntoOrgen.X), promedio(puntoDestino.Y, puntoOrgen.Y));
                List<PictureBox> bandoContrario = color == "roja" ? azules : rojas;
                for (int i = 0; i < bandoContrario.Count; i++)
                {
                   if( bandoContrario[i].Location ==puntoMedio )
                    {
                        bandoContrario[i].Location = new Point(0, 0);
                        bandoContrario[i].Visible = false;
                        return true;
                    }
                }

            }
            return false;

        }
        private void ifqueen (string color)
            {
            if (color =="azul"&&seleccionado .Location .Y==400)
              {
                seleccionado.BackgroundImage = Properties.Resources.reinaRoja_gif;
                seleccionado.Tag = "queen";
              }
            else if (color == "roja" && seleccionado.Location.Y == 50)
            {
                seleccionado.BackgroundImage = Properties.Resources.azulRoja_gif;
                seleccionado.Tag = "queen";
            }
        }
        

        private void seleccionAzul(object sender, EventArgs e)
        {
            if (turno % 2 == 1)
            {
                seleccion(sender);
            }
            else
            {
                MessageBox.Show("Reqibin sirasidir");
            }
            
        }

        private void seleccionRoje(object sender, EventArgs e)
        {
            if(turno % 2 == 0)
            {
                seleccion(sender);
            }
            else
            {
                MessageBox.Show("Reqibin sirasidir");
            }
           
        }

        private void cuadroClick(object sender, EventArgs e)
        {
            movimento((PictureBox)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
