using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Penzugyi_tanacsado
{
    public partial class Új_találkozó_felvétele : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=HERNADI;Initial Catalog=tanacsado;Integrated Security=True");
        SqlCommand comTanacsado = new SqlCommand();
        SqlCommand comUgyfel = new SqlCommand();
        SqlCommand comTalalkozo = new SqlCommand();

        public Új_találkozó_felvétele()
        {
            InitializeComponent();
        }

        private void Új_találkozó_felvétele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tanacsadoDataSet.ugyfel' table. You can move, or remove it, as needed.
            this.ugyfelTableAdapter.Fill(this.tanacsadoDataSet.ugyfel);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.tanacsado' table. You can move, or remove it, as needed.
            this.tanacsadoTableAdapter.Fill(this.tanacsadoDataSet.tanacsado);

        }

        private void Felvétel_Click(object sender, EventArgs e)
        {
            comTanacsado.Connection = connection;
            comUgyfel.Connection = connection;
            comTalalkozo.Connection = connection;

            connection.Open();

            comTanacsado.CommandText = @"INSERT INTO tanacsado (nev) VALUES (@tnev)";
            comTanacsado.Parameters.AddWithValue("@tnev", tanacsadoNeve.SelectedValue);
            comTanacsado.ExecuteNonQuery();

            comUgyfel.CommandText = @"INSERT INTO ugyfel (nev) VALUES (@unev)";
            comUgyfel.Parameters.AddWithValue("@unev", ugyfelNeve.SelectedValue);
            comUgyfel.ExecuteNonQuery();

            comTalalkozo.CommandText = @"INSERT INTO talalkozo (datum, idopont, idotartam) VALUES (@datum, @idopont, @idotartam)";
            comTalalkozo.Parameters.AddWithValue("@datum", this.talalkozoDatuma.Value.Date);
            comTalalkozo.Parameters.AddWithValue("@idopont", $"{this.talalkozoIdeje.Value.TimeOfDay.Hours}:{this.talalkozoIdeje.Value.TimeOfDay.Minutes}");
            comTalalkozo.Parameters.AddWithValue("@idotartam", this.talalkozoIdotartama.Value);
            comTalalkozo.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Az adatok sikeresen elmentve!");
            this.Close();
        }

        private void Mégse_Click(object sender, EventArgs e)
        {
            Form ujTalalkozo = new Form();
            this.Close();
        }
    }
}
