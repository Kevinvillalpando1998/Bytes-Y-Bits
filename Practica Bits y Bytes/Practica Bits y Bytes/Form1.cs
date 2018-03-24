using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Bits_y_Bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       
        private void Fecha(Int32 m) {
            string fecha="";
            Int32 a = 0,mes=0,dia=0;

            a = (m >> 17);
            //listDatos.Items.Add(a);
            mes = (m) - (a << 17);
            //listDatos.Items.Add(mes);
            mes = (mes >> 13);
            //listDatos.Items.Add(mes);

            dia = (m)-(a<<17);
            dia = (dia) - (mes << 13);
            //listDatos.Items.Add(dia);
            dia = (dia >> 8);
            //listDatos.Items.Add(dia);
              
            fecha = dia + " / " + mes + " / " + (a+1900);


            listDatos.Items.Add(fecha);
        } 
        private void UltByt(Int32 m)
        {
            Int32 sn1=0, sn2=0, nt=0, dmv=0,m2=0;
            
            m2 = (m >> 8);
            //
            m2 = (m2 << 8);
            //listDatos.Items.Add((m2));
            m -= m2;

            sn1 = (m >> 7);
            
           sn2 = (m) - (sn1 << 7);
            
            sn2 = sn2 >> 6;
          
            nt = m>>6;
            nt = nt << 6;
            nt = m - nt;
            nt = nt >> 4;

            dmv = m >> 4;
            dmv = dmv << 4;
            dmv = m-(dmv);
            dmv = dmv >> 1;
            listDatos.Items.Add((sn1));
            listDatos.Items.Add((sn2));
            listDatos.Items.Add(Vlt(nt));
            listDatos.Items.Add(dmvl(dmv));

        }
        private string dmvl(Int32 nt)
        {
            
            string nvlt="";
           switch (nt)
           {
                case 0:
                    nvlt = "N";
                    break;
                case 1:
                    nvlt = "NE";
                    break;
                case 2:
                    nvlt = "E";
                    break;
                case 3:
                    nvlt = "SE";
                    break;
                case 4:
                    nvlt = "S";
                    break;
                case 5:
                    nvlt = "SO";
                    break;
                case 6:
                    nvlt = "O";
                    break;
                case 7:
                    nvlt = "NO";
                    break;                
            }
            return nvlt;
        }
        private string Vlt(Int32 nt)
        {

            string nvlt = "";
            switch (nt)
            {
                case 0:
                    nvlt = "Nivel: Vacio";
                    break;
                case 1:
                    nvlt = "Nivel: Medio";
                    break;
                case 2:
                    nvlt = "Nivel: Lleno";
                    break;
                case 3:
                    nvlt = "Nivel: Proceso de llenado";
                    break;
                    //0-vacio, 1- nivel medio, 2-lleno, 3 - proceso de llenado
            }
            return nvlt;
        }
      
        private void btnbytes_Click(object sender, EventArgs e)
        {
            
            Int32 Bytes=0;
            Bytes = Convert.ToInt32(txtNum.Text);
            if (Bytes != 0)
            {
                Fecha(Bytes);
                UltByt(Bytes);
            }


        }

        private void ModificarFecha_Click(object sender, EventArgs e)
        {
            listDatos.Visible = false;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            int a;
            for ( a = 1900; a <= 2027; a++)
                listA_o.Items.Add(a);

            for ( a = 1; a <= 31; a++)
                lisDia.Items.Add(a);
            for ( a = 01; a <= 12; a++)
                listMes.Items.Add(a);
        }

        private void decodificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listDatos.Visible = true;
        }
        private Int32 Codificar(Int32 A,Int32 M,Int32 D)
        { Int32 Cod=0;
            A -= 1900;
            Cod = (A << 9) + (M << 5) + (D);


            return Cod;
        }

        private void btnCFecha_Click(object sender, EventArgs e)
        {
            Int32 A=0, M=0, D=0;
            A = Convert.ToInt32(listA_o.Text);
            M = Convert.ToInt32(listMes.Text);
            D = Convert.ToInt32(lisDia.Text);
            txtNum.Text = Codificar(A, M, D).ToString();

                /*string a="10";
            int b=Convert.ToInt32(a);

            txtNum.Text = b.ToString();*/
        }
    }
}
