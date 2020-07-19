using System;
using System.Windows.Forms;

/*IDENTACION:     El código deberá tener sangría, llaves, bloques de código 
                  para una mejor legibilidad*/
/*COMENTARIOS:    Son una parte fundamental de un buen código fuente, 
                  con ellos se puede explicar esa parte del código que se ha escrito,
                  ayudará en un futuro a un compañero que tenga que revisar el código a 
                  entender más fácilmente lo que se quería conseguir.*/

namespace NumeroPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numero = numero a ingresar
            //n = Contador
            //

            int n, i, numero, num = 0;
            numero = Convert.ToInt32(txtnumero.Text);
            n = 2;
            while (n <= numero)
            {
                for (i = 2; n % i != 0; i++) ;
                if (i == n)
                {
                    lbox.Items.Add(n);
                    if (++num % 10 == 0) { 
                        lbox.Items.Add(n);
                    }
                }
                n++;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            lbox.Items.Clear();
        }
    }
}
