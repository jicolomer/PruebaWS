using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              

            Prueba.WS_IntegrAR p = new Prueba.WS_IntegrAR();

            try
            {
                System.Net.NetworkCredential cr = new NetworkCredential("", "");
                System.Net.WebProxy prop = new WebProxy("proxysanidad.salud.madrid.org", 8080);

                prop.Credentials = cr;
                p.Proxy = prop;



                String a = p.HolaMundo();
                textBox1.Text="OK";
            }
            catch (Exception ex)
            {

                textBox1.Text = ex.Message;
            }


        }
    }
}
