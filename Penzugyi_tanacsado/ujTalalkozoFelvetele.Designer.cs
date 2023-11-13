namespace Penzugyi_tanacsado
{
    partial class Új_találkozó_felvétele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Új_találkozó_felvétele));
            this.szuksegesAdatok = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ügyfél_neve = new System.Windows.Forms.Label();
            this.Találkozó_dátuma = new System.Windows.Forms.Label();
            this.Találkozó_ideje = new System.Windows.Forms.Label();
            this.Találkozó_idotartama = new System.Windows.Forms.Label();
            this.talalkozoDatuma = new System.Windows.Forms.DateTimePicker();
            this.talalkozoIdotartama = new System.Windows.Forms.NumericUpDown();
            this.Tanácsadó_neve = new System.Windows.Forms.Label();
            this.talalkozoIdeje = new System.Windows.Forms.DateTimePicker();
            this.Mégse = new System.Windows.Forms.Button();
            this.Felvétel = new System.Windows.Forms.Button();
            this.tanacsadoNeve = new System.Windows.Forms.ComboBox();
            this.tanacsadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanacsadoDataSet = new Penzugyi_tanacsado.tanacsadoDataSet();
            this.ugyfelNeve = new System.Windows.Forms.ComboBox();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanacsadoTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.tanacsadoTableAdapter();
            this.ugyfelTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.ugyfelTableAdapter();
            this.szuksegesAdatok.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talalkozoIdotartama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // szuksegesAdatok
            // 
            this.szuksegesAdatok.AutoSize = true;
            this.szuksegesAdatok.Controls.Add(this.tableLayoutPanel1);
            this.szuksegesAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szuksegesAdatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szuksegesAdatok.Location = new System.Drawing.Point(0, 0);
            this.szuksegesAdatok.Margin = new System.Windows.Forms.Padding(4);
            this.szuksegesAdatok.Name = "szuksegesAdatok";
            this.szuksegesAdatok.Padding = new System.Windows.Forms.Padding(4);
            this.szuksegesAdatok.Size = new System.Drawing.Size(1283, 953);
            this.szuksegesAdatok.TabIndex = 0;
            this.szuksegesAdatok.TabStop = false;
            this.szuksegesAdatok.Text = "Szükséges adatok:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Ügyfél_neve, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Találkozó_dátuma, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Találkozó_ideje, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Találkozó_idotartama, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.talalkozoDatuma, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.talalkozoIdotartama, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Tanácsadó_neve, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.talalkozoIdeje, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Mégse, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Felvétel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tanacsadoNeve, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ugyfelNeve, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6632F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 910);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Ügyfél_neve
            // 
            this.Ügyfél_neve.AutoSize = true;
            this.Ügyfél_neve.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ügyfél_neve.Location = new System.Drawing.Point(4, 151);
            this.Ügyfél_neve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ügyfél_neve.Name = "Ügyfél_neve";
            this.Ügyfél_neve.Size = new System.Drawing.Size(186, 151);
            this.Ügyfél_neve.TabIndex = 1;
            this.Ügyfél_neve.Text = "Ügyfél neve:";
            // 
            // Találkozó_dátuma
            // 
            this.Találkozó_dátuma.AutoSize = true;
            this.Találkozó_dátuma.Dock = System.Windows.Forms.DockStyle.Left;
            this.Találkozó_dátuma.Location = new System.Drawing.Point(4, 302);
            this.Találkozó_dátuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Találkozó_dátuma.Name = "Találkozó_dátuma";
            this.Találkozó_dátuma.Size = new System.Drawing.Size(267, 151);
            this.Találkozó_dátuma.TabIndex = 2;
            this.Találkozó_dátuma.Text = "Találkozó dátuma:";
            // 
            // Találkozó_ideje
            // 
            this.Találkozó_ideje.AutoSize = true;
            this.Találkozó_ideje.Dock = System.Windows.Forms.DockStyle.Left;
            this.Találkozó_ideje.Location = new System.Drawing.Point(4, 453);
            this.Találkozó_ideje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Találkozó_ideje.Name = "Találkozó_ideje";
            this.Találkozó_ideje.Size = new System.Drawing.Size(230, 151);
            this.Találkozó_ideje.TabIndex = 3;
            this.Találkozó_ideje.Text = "Találkozó ideje:";
            // 
            // Találkozó_idotartama
            // 
            this.Találkozó_idotartama.AutoSize = true;
            this.Találkozó_idotartama.Dock = System.Windows.Forms.DockStyle.Left;
            this.Találkozó_idotartama.Location = new System.Drawing.Point(4, 604);
            this.Találkozó_idotartama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Találkozó_idotartama.Name = "Találkozó_idotartama";
            this.Találkozó_idotartama.Size = new System.Drawing.Size(382, 151);
            this.Találkozó_idotartama.TabIndex = 4;
            this.Találkozó_idotartama.Text = "Találkozó időtartama (óra):";
            // 
            // talalkozoDatuma
            // 
            this.talalkozoDatuma.Dock = System.Windows.Forms.DockStyle.Top;
            this.talalkozoDatuma.Location = new System.Drawing.Point(428, 306);
            this.talalkozoDatuma.Margin = new System.Windows.Forms.Padding(4);
            this.talalkozoDatuma.Name = "talalkozoDatuma";
            this.talalkozoDatuma.Size = new System.Drawing.Size(628, 42);
            this.talalkozoDatuma.TabIndex = 7;
            // 
            // talalkozoIdotartama
            // 
            this.talalkozoIdotartama.CausesValidation = false;
            this.talalkozoIdotartama.DecimalPlaces = 1;
            this.talalkozoIdotartama.Dock = System.Windows.Forms.DockStyle.Left;
            this.talalkozoIdotartama.Location = new System.Drawing.Point(428, 608);
            this.talalkozoIdotartama.Margin = new System.Windows.Forms.Padding(4);
            this.talalkozoIdotartama.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.talalkozoIdotartama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.talalkozoIdotartama.Name = "talalkozoIdotartama";
            this.talalkozoIdotartama.Size = new System.Drawing.Size(318, 42);
            this.talalkozoIdotartama.TabIndex = 9;
            this.talalkozoIdotartama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tanácsadó_neve
            // 
            this.Tanácsadó_neve.AutoSize = true;
            this.Tanácsadó_neve.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tanácsadó_neve.Location = new System.Drawing.Point(4, 0);
            this.Tanácsadó_neve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tanácsadó_neve.Name = "Tanácsadó_neve";
            this.Tanácsadó_neve.Size = new System.Drawing.Size(252, 151);
            this.Tanácsadó_neve.TabIndex = 0;
            this.Tanácsadó_neve.Text = "Tanácsadó neve:";
            // 
            // talalkozoIdeje
            // 
            this.talalkozoIdeje.Dock = System.Windows.Forms.DockStyle.Top;
            this.talalkozoIdeje.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.talalkozoIdeje.Location = new System.Drawing.Point(428, 457);
            this.talalkozoIdeje.Margin = new System.Windows.Forms.Padding(4);
            this.talalkozoIdeje.Name = "talalkozoIdeje";
            this.talalkozoIdeje.Size = new System.Drawing.Size(628, 42);
            this.talalkozoIdeje.TabIndex = 10;
            // 
            // Mégse
            // 
            this.Mégse.AutoSize = true;
            this.Mégse.BackColor = System.Drawing.Color.LemonChiffon;
            this.Mégse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mégse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mégse.Location = new System.Drawing.Point(1064, 759);
            this.Mégse.Margin = new System.Windows.Forms.Padding(4);
            this.Mégse.Name = "Mégse";
            this.Mégse.Size = new System.Drawing.Size(206, 82);
            this.Mégse.TabIndex = 1;
            this.Mégse.Text = "Mégse";
            this.Mégse.UseVisualStyleBackColor = false;
            this.Mégse.Click += new System.EventHandler(this.Mégse_Click);
            // 
            // Felvétel
            // 
            this.Felvétel.AutoSize = true;
            this.Felvétel.BackColor = System.Drawing.Color.LemonChiffon;
            this.Felvétel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Felvétel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Felvétel.Location = new System.Drawing.Point(428, 759);
            this.Felvétel.Margin = new System.Windows.Forms.Padding(4);
            this.Felvétel.Name = "Felvétel";
            this.Felvétel.Size = new System.Drawing.Size(234, 82);
            this.Felvétel.TabIndex = 2;
            this.Felvétel.Text = "Felvétel";
            this.Felvétel.UseVisualStyleBackColor = false;
            this.Felvétel.Click += new System.EventHandler(this.Felvétel_Click);
            // 
            // tanacsadoNeve
            // 
            this.tanacsadoNeve.DataSource = this.tanacsadoBindingSource;
            this.tanacsadoNeve.DisplayMember = "nev";
            this.tanacsadoNeve.Dock = System.Windows.Forms.DockStyle.Left;
            this.tanacsadoNeve.FormattingEnabled = true;
            this.tanacsadoNeve.Location = new System.Drawing.Point(428, 4);
            this.tanacsadoNeve.Margin = new System.Windows.Forms.Padding(4);
            this.tanacsadoNeve.Name = "tanacsadoNeve";
            this.tanacsadoNeve.Size = new System.Drawing.Size(324, 43);
            this.tanacsadoNeve.TabIndex = 11;
            this.tanacsadoNeve.ValueMember = "nev";
            // 
            // tanacsadoBindingSource
            // 
            this.tanacsadoBindingSource.DataMember = "tanacsado";
            this.tanacsadoBindingSource.DataSource = this.tanacsadoDataSet;
            // 
            // tanacsadoDataSet
            // 
            this.tanacsadoDataSet.DataSetName = "tanacsadoDataSet";
            this.tanacsadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ugyfelNeve
            // 
            this.ugyfelNeve.DataSource = this.ugyfelBindingSource;
            this.ugyfelNeve.DisplayMember = "nev";
            this.ugyfelNeve.Dock = System.Windows.Forms.DockStyle.Left;
            this.ugyfelNeve.FormattingEnabled = true;
            this.ugyfelNeve.Location = new System.Drawing.Point(428, 155);
            this.ugyfelNeve.Margin = new System.Windows.Forms.Padding(4);
            this.ugyfelNeve.Name = "ugyfelNeve";
            this.ugyfelNeve.Size = new System.Drawing.Size(317, 43);
            this.ugyfelNeve.TabIndex = 12;
            this.ugyfelNeve.ValueMember = "nev";
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataMember = "ugyfel";
            this.ugyfelBindingSource.DataSource = this.tanacsadoDataSet;
            // 
            // tanacsadoTableAdapter
            // 
            this.tanacsadoTableAdapter.ClearBeforeFill = true;
            // 
            // ugyfelTableAdapter
            // 
            this.ugyfelTableAdapter.ClearBeforeFill = true;
            // 
            // Új_találkozó_felvétele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1283, 953);
            this.Controls.Add(this.szuksegesAdatok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Új_találkozó_felvétele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Új találkozó felvétele";
            this.Load += new System.EventHandler(this.Új_találkozó_felvétele_Load);
            this.szuksegesAdatok.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.talalkozoIdotartama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox szuksegesAdatok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Tanácsadó_neve;
        private System.Windows.Forms.Label Ügyfél_neve;
        private System.Windows.Forms.Label Találkozó_dátuma;
        private System.Windows.Forms.Label Találkozó_ideje;
        private System.Windows.Forms.Label Találkozó_idotartama;
        private System.Windows.Forms.DateTimePicker talalkozoDatuma;
        private System.Windows.Forms.NumericUpDown talalkozoIdotartama;
        private System.Windows.Forms.Button Mégse;
        private System.Windows.Forms.Button Felvétel;
        private System.Windows.Forms.DateTimePicker talalkozoIdeje;
        private System.Windows.Forms.ComboBox tanacsadoNeve;
        private tanacsadoDataSet tanacsadoDataSet;
        private System.Windows.Forms.BindingSource tanacsadoBindingSource;
        private tanacsadoDataSetTableAdapters.tanacsadoTableAdapter tanacsadoTableAdapter;
        private System.Windows.Forms.ComboBox ugyfelNeve;
        private System.Windows.Forms.BindingSource ugyfelBindingSource;
        private tanacsadoDataSetTableAdapters.ugyfelTableAdapter ugyfelTableAdapter;
    }
}