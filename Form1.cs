namespace Registro_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text.Trim();
            string telefono = txt_Telefono.Text.Trim();
            string correo = txt_Correo.Text.Trim();
            
            if (nombre == "")
        {
        MessageBox.Show("El nombre es obligatorio.");
        return;
        }

        if (telefono == "")
        {
        MessageBox.Show("El teléfono es obligatorio.");
        return;
        }

        if (correo == "")
        {
        MessageBox.Show("El correo es obligatorio.");
        return;
         }
         
            string nuevoElemento = txt_Nombre.Text + " , " + txt_Telefono.Text + " ," + txt_Correo.Text;
            list_Clientes.Items.Add(nuevoElemento);

           
            txt_Nombre.Text = "";
            txt_Telefono.Text = "";
            txt_Correo.Text = "";

        }

        private void list_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
