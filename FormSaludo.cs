
namespace WinFormSaludo_2027_I
{
    internal partial class FormSaludo:Form
    {
        public FormSaludo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e )
        {
            MessageBox.Show($" Hola {this.txtbNombre.Text} ");
        }
    }
}
