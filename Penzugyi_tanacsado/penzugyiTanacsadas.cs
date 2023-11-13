using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Penzugyi_tanacsado
{
    public partial class penzugyiTanacsadas : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=HERNADI;Initial Catalog=tanacsado;Integrated Security=True");

        public penzugyiTanacsadas()
        {
            InitializeComponent();
        }

        private void Pénzügyi_tanácsadás_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tanacsadoDataSet.szakterulet' table. You can move, or remove it, as needed.
            this.szakteruletTableAdapter.Fill(this.tanacsadoDataSet.szakterulet);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);
            Size = new Size(1000, 500);
        }

        private void Szűrésbe_Click_1(object sender, EventArgs e)
        {
            int alsoH = (int)Convert.ToUInt32(alsoHatar.Value);
            int felsoH = (int)Convert.ToUInt32(felsoHatar.Value);

            if (alsoH < felsoH && alsoH % 1000 == 0 && felsoH % 1000 == 0)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM AllData WHERE (TanácsadóÓradíja BETWEEN ('" + this.alsoHatar.Value + "') AND ('" + this.felsoHatar.Value + "')) AND (SzakterületMegnevezése = ('" + Szakterulet.SelectedValue+"')) ORDER BY SzakterületMegnevezése, TanácsadóNeve, TalálkozóDátuma DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                
            }
            else if (alsoH > felsoH)
            {
                MessageBox.Show("Az alsó határ nagyobb mint a felső határ!");
            }
            else if (alsoH % 1000 != 0 || felsoH % 1000 != 0)
            {
                MessageBox.Show("Az alsó és felső határ csak 1000-rel osztható szám lehet!");
            }

        }

        private void Szűréski_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM AllData ORDER BY SzakterületMegnevezése, TanácsadóNeve, TalálkozóDátuma DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ExportAllData_Click(object sender, EventArgs e)
        {
            int alsoH = (int)Convert.ToUInt32(alsoHatar.Value);
            int felsoH = (int)Convert.ToUInt32(felsoHatar.Value);
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = Path.Combine(folderBrowserDialog1.SelectedPath, $"tanacsadok_{Szakterulet.SelectedValue}_({alsoH}-{felsoH} Ft)_{DateTime.Now:yyyy-MM-dd}.csv");
            File.WriteAllLines(fileName, 
                tanacsadoDataSet.AllData.Select(x => string.Join(";", x.ItemArray))
                );
        }

        private void UjTalalkozoFelvetele_Click(object sender, EventArgs e)
        {
            Új_találkozó_felvétele uj = new Új_találkozó_felvétele();
            uj.ShowDialog();
        }

        private void Bezaras_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
