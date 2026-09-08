using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormSaludo_2027_I
{
    internal partial class FormSaludo: Form
    {
        private Label lbIntroNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;

        private Button btnLimpiar;


        private void InitializeComponent()
        {
            this.Text = "Formulario de Saludo";
            this.Size = new Size(500, 300);
            // Instanciando el label y sus propiedades
            this.lbIntroNombre = new Label();
            this.lbIntroNombre.Text = "Ingresa tu nombre:";
            this.lbIntroNombre.Size = new Size(200, 30);
            this.lbIntroNombre.Location = new Point(20, 20);

            // Instanciando el textbox y sus propiedades
            this.txtbNombre = new TextBox();
            this.txtbNombre.Size = new Size(300, 30);
            this.txtbNombre.Location = new Point(20, 70);

            // Instanciando el Button y sus propiedades
            this.btnAceptar = new Button();
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Size = new Size(100, 40);
            this.btnAceptar.Location = new Point(40, 120);
            this.btnAceptar.Click += btnAceptar_Click; 

            // Instanciando el Button Limpiar y sus propiedades
            this.btnLimpiar = new Button();
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Size = new Size(100, 40);
            this.btnLimpiar.Location = new Point(180, 120);

            this.Controls.Add(this.lbIntroNombre);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);

        }
      
    }
}
