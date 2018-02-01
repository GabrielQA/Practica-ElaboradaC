using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        String nombre;
        String residencia;
        int cedula;
        String fecha;


        public Form1()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM estudiantes", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    R.Items.Add(dr.GetString(0));
                }
            }
            conexion.Close();


        }

        public void GestionarDatos(int tipoOperacion)
        {
            cedula = Convert.ToInt32(txtCedula.Text);
            nombre = txtNombre.Text;
            fecha = txtfecha.Text;
            residencia = txtresidencia.Text;


        }
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            int clave = 123;
            string baseDatos = "postgres";

            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntInsertar_Click(object sender, EventArgs e)
        {
            InsertarDatos(cedula, nombre, fecha, residencia);
            txtCedula.Clear();
            txtNombre.Clear();

            txtresidencia.Clear();


        }

        public void InsertarDatos(int cedula, string nombre, string fecha, string residencia)
        {
            cedula = Convert.ToInt32(txtCedula.Text);
            fecha = txtfecha.Text;
            nombre = txtNombre.Text;
            residencia = txtresidencia.Text;

            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO estudiantes (cedula, nombre, fecha, residencia) VALUES ('" + cedula + "', '" + nombre + "', '" + fecha + "', '" + residencia + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public List<object> ConsultarDatos(int cedula)
        {
            Conexion();
            conexion.Open();
            List<object> lista = new List<object>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula,nombre,fecha,residencia FROM estudiantes WHERE cedula = '" + cedula + "'", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lista.Add(dr.GetString(0));
                    lista.Add(dr.GetString(1));
                    lista.Add(dr.GetString(2));
                }
            }
            conexion.Close();

            return lista;
        }

        private void R_SelectedIndexChanged(object sender, EventArgs e)
        {


            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula,nombre,fecha,residencia FROM estudiantes WHERE nombre = '" + R.SelectedItem + "'", conexion);
            NpgsqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    TXT1.Text = leer.GetString(0);
                    TXT2.Text = leer.GetString(1);
                    TXT3.Value = leer.GetDateTime(2);
                    TXT4.Text = leer.GetString(3);


                }

                conexion.Close();



            }
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
           
            ConsultarDatos(cedula);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Mous(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTM(object sender, EventArgs e)
        {
           pictureBox1.ImageLocation = "C:/Users/gabri/Pictures";
        }
    }
}

