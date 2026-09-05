using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormSaludo_2027_I
{
    internal class FormSaludo: Form
    {
        private Label lbIntroNombre;

        public FormSaludo()
        {
            this.Text = "Formulario de Saludo";
            this.Size = new Size(500,300);


            // Instanciando el label y sus propiedades
            this.lbIntroNombre = new Label();
            this.lbIntroNombre.Text = "Ingresa tu nombre:";
            this.lbIntroNombre.Size = new Size(200, 30);
            this.lbIntroNombre.Location = new Point(20,20);


            this.Controls.Add(this.lbIntroNombre);

        }

    }
}
