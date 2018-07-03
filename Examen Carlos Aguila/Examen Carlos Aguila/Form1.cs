using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Examen_Carlos_Aguila
{
    public partial class PACMAN : Form
    {
        bool irarriba;
        bool irabajo;
        bool irizquierda;
        bool irderecha;
        int speed = 6;
        int scrore;
        int ghost1 = 8;
        int ghost2 = 8;
        int ghost3x = 8;
        int ghost3y = 8;
        
        public PACMAN()
        {
            InitializeComponent();
            int ayuda = 0;
            MessageBox.Show("BIENVENIDO!");
            barra1.Tag = "wall";
            barra2.Tag = "wall";
            barra3.Tag = "wall";
            redghost.Tag = "ghost";
            pinkghost.Tag = "ghost";
            pera.Tag = "fruta";
            cherry.Tag = "fruta";
            List<int> puntajes = new List<int>();
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter ree = new BinaryFormatter();
            ree.Serialize(fs, puntajes);
            fs.Close();
        }
        public enum flechas : int
        {
            Arriba = 1,
            Abajo = 2,
            Izquierda = 3,
            Derecha = 4

        }
        flechas flecha;
        private void PACMAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                flecha = flechas.Arriba;
            }
            else if (e.KeyCode == Keys.Down)
            {
                flecha = flechas.Abajo;
            }
            else if (e.KeyCode == Keys.Left)
            {
                flecha = flechas.Izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                flecha = flechas.Derecha;
            }
        }
        

       

        private void PACMAN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                irizquierda = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                irderecha = false;

            }
            if (e.KeyCode == Keys.Up)
            {
                irarriba = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                irabajo = false;

            }
        }
       

        private void tmrpacman_Tick(object sender, EventArgs e)
        {
            switch (flecha)
            {
                case flechas.Arriba:
                    if (pictureBox1.Location.Y>pictureBox1.Height)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);
                        


                    }

                    else
	                {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, this.Height);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);



                    }
                    break;
                case flechas.Abajo:
                    if (pictureBox1.Location.Y < this.Height)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    else
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, -pictureBox1.Height);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    break;
                case flechas.Izquierda:
                    if (pictureBox1.Location.X > -pictureBox1.Width)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X-10, pictureBox1.Location.Y);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    else
                    {
                        pictureBox1.Location = new Point(this.Width, pictureBox1.Location.Y);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    break;
                case flechas.Derecha:
                    if (pictureBox1.Location.X <this.Width)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                        pinkghost.Location = new Point(pinkghost.Location.X + ((  (pictureBox1.Location.X)- (pinkghost.Location.X)))/10, pinkghost.Location.Y + ((pictureBox1.Location.Y) - (pinkghost.Location.Y)) / 10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    else
                    {
                        pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                        pinkghost.Location = new Point(pinkghost.Location.X + (((pictureBox1.Location.X) - (pinkghost.Location.X)))/10, pinkghost.Location.Y+ ((pictureBox1.Location.Y)-(pinkghost.Location.Y))/10);
                        redghost.Location = new Point(redghost.Location.X + (((pictureBox1.Location.X) - (redghost.Location.X))) / 9, redghost.Location.Y + ((pictureBox1.Location.Y) - (redghost.Location.Y)) / 9);

                    }
                    break;



            }
            int ayuda = 1;

            if (pictureBox1.Bounds.IntersectsWith(barra1.Bounds))
            {
                lblnombre.Text = "GAME OVER \nKILLED BY: WALL";
                lblscore.Visible = true;
                FileStream fss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter reee = new BinaryFormatter();
                List<int> puntajes = reee.Deserialize(fss) as List<int>;
                fss.Close();
                puntajes.Add(scrore);
                puntajes.Sort();
                string amostrar = "MAXIMAS PUNTUACIONES " + "\n";
                int posicion = 10;
                foreach (int item in puntajes)
                {
                    amostrar += posicion.ToString() + "     " + "\n";
                    amostrar += item.ToString();
                    posicion -= 1;
                }
                FileStream fsss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                amostrar += "\n" + "MATADO POR PARED";
                BinaryFormatter reet = new BinaryFormatter();
                reet.Serialize(fsss, puntajes);
                fsss.Close();
                pictureBox1.Location = new Point(0, 0);
                redghost.Location = new Point(100, 100);
                pinkghost.Location = new Point(100, 100);
                if (puntajes.Count() < 6)
                {
                    MessageBox.Show(amostrar);
                    ayuda += 1;
                }
                pictureBox1.Location = new Point(100, 100);



            }
            if (pictureBox1.Bounds.IntersectsWith(barra2.Bounds))
            {
                lblnombre.Text = "GAME OVER \nKILLED BY: WALL";
                lblscore.Visible = true;
                FileStream fss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter reee = new BinaryFormatter();
                List<int> puntajes = reee.Deserialize(fss) as List<int>;
                fss.Close();
                puntajes.Add(scrore);
                puntajes.Sort();
                string amostrar = "MAXIMAS PUNTUACIONES " + "\n";
                int posicion = 10;
                foreach (int item in puntajes)
                {
                    amostrar += posicion.ToString() + "     " + "\n";
                    amostrar += item.ToString();
                    posicion -= 1;
                }
                FileStream fsss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                amostrar += "\n" + "MATADO POR PARED";
                BinaryFormatter reet = new BinaryFormatter();
                reet.Serialize(fsss, puntajes);
                fsss.Close();
                pictureBox1.Location = new Point(0, 0);
                redghost.Location = new Point(100, 100);
                pinkghost.Location = new Point(100, 100);
                if (puntajes.Count() < 6)
                {
                    MessageBox.Show(amostrar);
                    ayuda += 1;
                }
                pictureBox1.Location = new Point(100, 100);


            }
            if (pictureBox1.Bounds.IntersectsWith(barra3.Bounds))
            {
               
                lblnombre.Text = "GAME OVER \nKILLED BY: WALL";
                lblscore.Visible = true;
                FileStream fss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter reee = new BinaryFormatter();
                List<int> puntajes = reee.Deserialize(fss) as List<int>;
                fss.Close();
                puntajes.Add(scrore);
                puntajes.Sort();
                string amostrar = "MAXIMAS PUNTUACIONES " + "\n";
                int posicion = 10;
                foreach (int item in puntajes)
                {
                    amostrar += posicion.ToString() + "     " + "\n";
                    amostrar += item.ToString();
                    posicion -= 1;
                }
                FileStream fsss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                amostrar += "\n" + "MATADO POR PARED";
                BinaryFormatter reet = new BinaryFormatter();
                reet.Serialize(fsss, puntajes);
                fsss.Close();
                pictureBox1.Location = new Point(0, 0);
                redghost.Location = new Point(100, 100);
                pinkghost.Location = new Point(100, 100);
                if (puntajes.Count() < 6)
                {
                    MessageBox.Show(amostrar);
                    ayuda += 1;
                }
                pictureBox1.Location = new Point(100, 100);


            }
            if (pictureBox1.Bounds.IntersectsWith(pinkghost.Bounds))
            {
                lblnombre.Text = "GAME OVER \nKILLED BY: PINKGHOST";
                lblscore.Visible = true;
                FileStream fss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter reee = new BinaryFormatter();
                List<int> puntajes = reee.Deserialize(fss) as List<int>;
                fss.Close();
                puntajes.Add(scrore);
                puntajes.Sort();
                string amostrar = "MAXIMAS PUNTUACIONES " + "\n";
                int posicion = 10;
                foreach (int item in puntajes)
                {
                    amostrar += posicion.ToString() + "     " + "\n";
                    amostrar += item.ToString();
                    posicion -= 1;
                }
                FileStream fsss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                amostrar += "\n" + "MATADO POR FANTASMA ROSADO";
                BinaryFormatter reet = new BinaryFormatter();
                reet.Serialize(fsss, puntajes);
                fsss.Close();
                pictureBox1.Location = new Point(0, 0);
                redghost.Location = new Point(100, 100);
                pinkghost.Location = new Point(100, 100);
                if (puntajes.Count() < 6)
                {
                    MessageBox.Show(amostrar);
                    ayuda += 1;
                }
                pictureBox1.Location = new Point(100, 100);


            }

            if (pictureBox1.Bounds.IntersectsWith(redghost.Bounds))
            {
                if (true)
                {

                    lblnombre.Text = "GAME OVER \nKILLED BY : REDGHOST";
                    lblscore.Visible = true;
                    FileStream fss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                    BinaryFormatter reee = new BinaryFormatter();
                    List<int> puntajes = reee.Deserialize(fss) as List<int>;
                    fss.Close();
                    puntajes.Add(scrore);
                    puntajes.Sort();
                    string amostrar = "MAXIMAS PUNTUACIONES " + "\n";
                    int posicion = 10;
                    foreach (int item in puntajes)
                    {
                        amostrar += posicion.ToString() + "     " + "\n";
                        amostrar += item.ToString();
                        posicion -= 1;
                    }
                    FileStream fsss = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                    amostrar += "\n" + "MATADO POR FANTASMA ROJO";
                    BinaryFormatter reet = new BinaryFormatter();
                    reet.Serialize(fsss, puntajes);
                    fsss.Close();
                    pictureBox1.Location = new Point(0, 0);
                    redghost.Location = new Point(100, 100);
                    pinkghost.Location = new Point(100, 100);
                    if (puntajes.Count()<6)
                    {                       
                        MessageBox.Show(amostrar);
                        ayuda += 1;
                    }
                    pictureBox1.Location = new Point(100, 100);
                    
                }
                
                
                

            }
            if (pictureBox1.Bounds.IntersectsWith(cherry.Bounds))
            {
                Random random = new Random();
                scrore += 10;
                label1.Text = scrore.ToString();
                lblscore.Visible = true;
                cherry.Location = new Point(0, 0);
               
                cherry.Location = new Point(random.Next(0, 200), random.Next(0, 200));


            }
            if (pictureBox1.Bounds.IntersectsWith(pera.Bounds))
            {
                Random random = new Random();
                scrore += 15;
                label1.Text = scrore.ToString();
                lblscore.Visible = true;
                pera.Location = new Point(0, 0);
                
                pera.Location = new Point(random.Next(0,200), random.Next(0,200));


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(txtnombre.Text, 0);
            txtnombre.Visible = false;
            button1.Visible = false;
        }
    }
}
