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
