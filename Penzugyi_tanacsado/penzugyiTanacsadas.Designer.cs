namespace Penzugyi_tanacsado
{
    partial class penzugyiTanacsadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penzugyiTanacsadas));
            this.bindingSourceAllDataForTable = new System.Windows.Forms.BindingSource(this.components);
            this.tanacsadoDataSet = new Penzugyi_tanacsado.tanacsadoDataSet();
            this.allDataTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.AllDataTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.találkozóDátumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ügyfélNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanácsadóNeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szakterületMegnevezéseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóIdőtartamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szűrők = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Szűrésbe = new System.Windows.Forms.Button();
            this.Szűréski = new System.Windows.Forms.Button();
            this.Óradíj_felső_határa = new System.Windows.Forms.Label();
            this.Szakterulet = new System.Windows.Forms.ComboBox();
            this.szakteruletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Óradíj_alsó_határa = new System.Windows.Forms.Label();
            this.Szakterület = new System.Windows.Forms.Label();
            this.alsoHatar = new System.Windows.Forms.NumericUpDown();
            this.felsoHatar = new System.Windows.Forms.NumericUpDown();
            this.Adatok_exportálása = new System.Windows.Forms.Label();
            this.Új_találkozó_felvétele = new System.Windows.Forms.Label();
            this.UjTalalkozoFelvetele = new System.Windows.Forms.Button();
            this.Bezárás = new System.Windows.Forms.Label();
            this.ExportAllData = new System.Windows.Forms.Button();
            this.Bezaras = new System.Windows.Forms.Button();
            this.szakteruletTableAdapter = new Penzugyi_tanacsado.tanacsadoDataSetTableAdapters.szakteruletTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Szűrők.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakteruletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alsoHatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felsoHatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceAllDataForTable
            // 
            this.bindingSourceAllDataForTable.DataMember = "AllData";
            this.bindingSourceAllDataForTable.DataSource = this.tanacsadoDataSet;
            this.bindingSourceAllDataForTable.Sort = "SzakterületMegnevezése, TanácsadóNeve, TalálkozóDátuma DESC";
            // 
            // tanacsadoDataSet
            // 
            this.tanacsadoDataSet.DataSetName = "tanacsadoDataSet";
            this.tanacsadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDataTableAdapter
            // 
            this.allDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Szűrők, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Adatok_exportálása, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Új_találkozó_felvétele, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.UjTalalkozoFelvetele, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Bezárás, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.ExportAllData, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Bezaras, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1544, 906);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.találkozóDátumaDataGridViewTextBoxColumn,
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn,
            this.ügyfélNeveDataGridViewTextBoxColumn,
            this.tanácsadóNeveDataGridViewTextBoxColumn,
            this.szakterületMegnevezéseDataGridViewTextBoxColumn,
            this.találkozóIdőtartamaDataGridViewTextBoxColumn,
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn,
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceAllDataForTable;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 892);
            this.dataGridView1.TabIndex = 1;
            // 
            // találkozóDátumaDataGridViewTextBoxColumn
            // 
            this.találkozóDátumaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóDátuma";
            this.találkozóDátumaDataGridViewTextBoxColumn.HeaderText = "Találkozó dátuma";
            this.találkozóDátumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.találkozóDátumaDataGridViewTextBoxColumn.Name = "találkozóDátumaDataGridViewTextBoxColumn";
            this.találkozóDátumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.találkozóDátumaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn
            // 
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóKezdésiIdőpontja";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.HeaderText = "Találkozó kezdési időpontja";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.Name = "találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn";
            this.találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ügyfélNeveDataGridViewTextBoxColumn
            // 
            this.ügyfélNeveDataGridViewTextBoxColumn.DataPropertyName = "ÜgyfélNeve";
            this.ügyfélNeveDataGridViewTextBoxColumn.HeaderText = "Ügyfél neve";
            this.ügyfélNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ügyfélNeveDataGridViewTextBoxColumn.Name = "ügyfélNeveDataGridViewTextBoxColumn";
            this.ügyfélNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanácsadóNeveDataGridViewTextBoxColumn
            // 
            this.tanácsadóNeveDataGridViewTextBoxColumn.DataPropertyName = "TanácsadóNeve";
            this.tanácsadóNeveDataGridViewTextBoxColumn.HeaderText = "Tanácsadó neve";
            this.tanácsadóNeveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanácsadóNeveDataGridViewTextBoxColumn.Name = "tanácsadóNeveDataGridViewTextBoxColumn";
            this.tanácsadóNeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szakterületMegnevezéseDataGridViewTextBoxColumn
            // 
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.DataPropertyName = "SzakterületMegnevezése";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.HeaderText = "Szakterület megnevezése";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.Name = "szakterületMegnevezéseDataGridViewTextBoxColumn";
            this.szakterületMegnevezéseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // találkozóIdőtartamaDataGridViewTextBoxColumn
            // 
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóIdőtartama";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.HeaderText = "Találkozó időtartama";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.Name = "találkozóIdőtartamaDataGridViewTextBoxColumn";
            this.találkozóIdőtartamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanácsadóÓradíjaDataGridViewTextBoxColumn
            // 
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.DataPropertyName = "TanácsadóÓradíja";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.HeaderText = "Tanácsadó óradíja";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.Name = "tanácsadóÓradíjaDataGridViewTextBoxColumn";
            this.tanácsadóÓradíjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // találkozóértFizetendőÖsszegDataGridViewTextBoxColumn
            // 
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.DataPropertyName = "TalálkozóértFizetendőÖsszeg";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.HeaderText = "Találkozóért fizetendő összeg";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.Name = "találkozóértFizetendőÖsszegDataGridViewTextBoxColumn";
            this.találkozóértFizetendőÖsszegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Szűrők
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Szűrők, 2);
            this.Szűrők.Controls.Add(this.tableLayoutPanel2);
            this.Szűrők.Dock = System.Windows.Forms.DockStyle.Top;
            this.Szűrők.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Szűrők.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szűrők.Location = new System.Drawing.Point(692, 173);
            this.Szűrők.Margin = new System.Windows.Forms.Padding(7);
            this.Szűrők.Name = "Szűrők";
            this.Szűrők.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.SetRowSpan(this.Szűrők, 3);
            this.Szűrők.Size = new System.Drawing.Size(845, 468);
            this.Szűrők.TabIndex = 9;
            this.Szűrők.TabStop = false;
            this.Szűrők.Text = "Szűrők";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Controls.Add(this.Szűrésbe, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Szűréski, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.Óradíj_felső_határa, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Szakterulet, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Óradíj_alsó_határa, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Szakterület, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.alsoHatar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.felsoHatar, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 41);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(831, 420);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Szűrésbe
            // 
            this.Szűrésbe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Szűrésbe.BackColor = System.Drawing.Color.LemonChiffon;
            this.Szűrésbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szűrésbe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Szűrésbe.Location = new System.Drawing.Point(7, 319);
            this.Szűrésbe.Margin = new System.Windows.Forms.Padding(7);
            this.Szűrésbe.Name = "Szűrésbe";
            this.Szűrésbe.Size = new System.Drawing.Size(401, 97);
            this.Szűrésbe.TabIndex = 0;
            this.Szűrésbe.Text = "Szűrés be";
            this.Szűrésbe.UseVisualStyleBackColor = false;
            this.Szűrésbe.Click += new System.EventHandler(this.Szűrésbe_Click_1);
            // 
            // Szűréski
            // 
            this.Szűréski.AutoSize = true;
            this.Szűréski.BackColor = System.Drawing.Color.LemonChiffon;
            this.Szűréski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szűréski.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Szűréski.Location = new System.Drawing.Point(422, 319);
            this.Szűréski.Margin = new System.Windows.Forms.Padding(7);
            this.Szűréski.Name = "Szűréski";
            this.Szűréski.Size = new System.Drawing.Size(402, 97);
            this.Szűréski.TabIndex = 3;
            this.Szűréski.Text = "Szűrés ki";
            this.Szűréski.UseVisualStyleBackColor = false;
            this.Szűréski.Click += new System.EventHandler(this.Szűréski_Click);
            // 
            // Óradíj_felső_határa
            // 
            this.Óradíj_felső_határa.AutoSize = true;
            this.Óradíj_felső_határa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Óradíj_felső_határa.Location = new System.Drawing.Point(7, 223);
            this.Óradíj_felső_határa.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Óradíj_felső_határa.Name = "Óradíj_felső_határa";
            this.Óradíj_felső_határa.Size = new System.Drawing.Size(401, 89);
            this.Óradíj_felső_határa.TabIndex = 6;
            this.Óradíj_felső_határa.Text = "Óradíj felső határa: ";
            // 
            // Szakterulet
            // 
            this.Szakterulet.BackColor = System.Drawing.SystemColors.Info;
            this.Szakterulet.DataSource = this.szakteruletBindingSource;
            this.Szakterulet.DisplayMember = "megnevezes";
            this.Szakterulet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szakterulet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Szakterulet.FormattingEnabled = true;
            this.Szakterulet.Location = new System.Drawing.Point(422, 52);
            this.Szakterulet.Margin = new System.Windows.Forms.Padding(7);
            this.Szakterulet.Name = "Szakterulet";
            this.Szakterulet.Size = new System.Drawing.Size(402, 41);
            this.Szakterulet.TabIndex = 2;
            this.Szakterulet.ValueMember = "megnevezes";
            // 
            // szakteruletBindingSource
            // 
            this.szakteruletBindingSource.DataMember = "szakterulet";
            this.szakteruletBindingSource.DataSource = this.tanacsadoDataSet;
            // 
            // Óradíj_alsó_határa
            // 
            this.Óradíj_alsó_határa.AutoSize = true;
            this.Óradíj_alsó_határa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Óradíj_alsó_határa.Location = new System.Drawing.Point(7, 134);
            this.Óradíj_alsó_határa.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Óradíj_alsó_határa.Name = "Óradíj_alsó_határa";
            this.Óradíj_alsó_határa.Size = new System.Drawing.Size(401, 89);
            this.Óradíj_alsó_határa.TabIndex = 5;
            this.Óradíj_alsó_határa.Text = "Óradíj alsó határa:";
            // 
            // Szakterület
            // 
            this.Szakterület.AutoSize = true;
            this.Szakterület.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Szakterület.Location = new System.Drawing.Point(7, 45);
            this.Szakterület.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Szakterület.Name = "Szakterület";
            this.Szakterület.Size = new System.Drawing.Size(401, 89);
            this.Szakterület.TabIndex = 9;
            this.Szakterület.Text = "Szakterület:";
            // 
            // alsoHatar
            // 
            this.alsoHatar.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alsoHatar.Location = new System.Drawing.Point(419, 138);
            this.alsoHatar.Margin = new System.Windows.Forms.Padding(4);
            this.alsoHatar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alsoHatar.Name = "alsoHatar";
            this.alsoHatar.Size = new System.Drawing.Size(331, 41);
            this.alsoHatar.TabIndex = 10;
            this.alsoHatar.ThousandsSeparator = true;
            // 
            // felsoHatar
            // 
            this.felsoHatar.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.felsoHatar.Location = new System.Drawing.Point(419, 227);
            this.felsoHatar.Margin = new System.Windows.Forms.Padding(4);
            this.felsoHatar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.felsoHatar.Name = "felsoHatar";
            this.felsoHatar.Size = new System.Drawing.Size(331, 41);
            this.felsoHatar.TabIndex = 11;
            this.felsoHatar.ThousandsSeparator = true;
            // 
            // Adatok_exportálása
            // 
            this.Adatok_exportálása.AutoSize = true;
            this.Adatok_exportálása.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adatok_exportálása.Location = new System.Drawing.Point(692, 664);
            this.Adatok_exportálása.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Adatok_exportálása.Name = "Adatok_exportálása";
            this.Adatok_exportálása.Size = new System.Drawing.Size(278, 36);
            this.Adatok_exportálása.TabIndex = 10;
            this.Adatok_exportálása.Text = "Adatok exportálása:";
            // 
            // Új_találkozó_felvétele
            // 
            this.Új_találkozó_felvétele.AutoSize = true;
            this.Új_találkozó_felvétele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Új_találkozó_felvétele.Location = new System.Drawing.Point(689, 744);
            this.Új_találkozó_felvétele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Új_találkozó_felvétele.Name = "Új_találkozó_felvétele";
            this.Új_találkozó_felvétele.Size = new System.Drawing.Size(308, 35);
            this.Új_találkozó_felvétele.TabIndex = 11;
            this.Új_találkozó_felvétele.Text = "Új találkozó felvétele:";
            // 
            // UjTalalkozoFelvetele
            // 
            this.UjTalalkozoFelvetele.AutoSize = true;
            this.UjTalalkozoFelvetele.BackColor = System.Drawing.Color.LemonChiffon;
            this.UjTalalkozoFelvetele.Dock = System.Windows.Forms.DockStyle.Left;
            this.UjTalalkozoFelvetele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UjTalalkozoFelvetele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UjTalalkozoFelvetele.Location = new System.Drawing.Point(1008, 751);
            this.UjTalalkozoFelvetele.Margin = new System.Windows.Forms.Padding(7);
            this.UjTalalkozoFelvetele.Name = "UjTalalkozoFelvetele";
            this.UjTalalkozoFelvetele.Size = new System.Drawing.Size(234, 66);
            this.UjTalalkozoFelvetele.TabIndex = 4;
            this.UjTalalkozoFelvetele.Text = "Felvétel";
            this.UjTalalkozoFelvetele.UseVisualStyleBackColor = false;
            this.UjTalalkozoFelvetele.Click += new System.EventHandler(this.UjTalalkozoFelvetele_Click);
            // 
            // Bezárás
            // 
            this.Bezárás.AutoSize = true;
            this.Bezárás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bezárás.Location = new System.Drawing.Point(689, 824);
            this.Bezárás.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bezárás.Name = "Bezárás";
            this.Bezárás.Size = new System.Drawing.Size(138, 35);
            this.Bezárás.TabIndex = 13;
            this.Bezárás.Text = "Bezárás:";
            // 
            // ExportAllData
            // 
            this.ExportAllData.AutoSize = true;
            this.ExportAllData.BackColor = System.Drawing.Color.LemonChiffon;
            this.ExportAllData.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExportAllData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportAllData.Location = new System.Drawing.Point(1008, 671);
            this.ExportAllData.Margin = new System.Windows.Forms.Padding(7);
            this.ExportAllData.Name = "ExportAllData";
            this.ExportAllData.Size = new System.Drawing.Size(299, 66);
            this.ExportAllData.TabIndex = 4;
            this.ExportAllData.Text = "Exportálás";
            this.ExportAllData.UseVisualStyleBackColor = false;
            this.ExportAllData.Click += new System.EventHandler(this.ExportAllData_Click);
            // 
            // Bezaras
            // 
            this.Bezaras.AutoSize = true;
            this.Bezaras.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bezaras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bezaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bezaras.Location = new System.Drawing.Point(1008, 831);
            this.Bezaras.Margin = new System.Windows.Forms.Padding(7);
            this.Bezaras.Name = "Bezaras";
            this.Bezaras.Size = new System.Drawing.Size(243, 67);
            this.Bezaras.TabIndex = 14;
            this.Bezaras.Text = "Bezárás";
            this.Bezaras.UseVisualStyleBackColor = false;
            this.Bezaras.Click += new System.EventHandler(this.Bezaras_Click);
            // 
            // szakteruletTableAdapter
            // 
            this.szakteruletTableAdapter.ClearBeforeFill = true;
            // 
            // penzugyiTanacsadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1544, 906);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "penzugyiTanacsadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pénzügyi tanácsadó";
            this.Load += new System.EventHandler(this.Pénzügyi_tanácsadás_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllDataForTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanacsadoDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Szűrők.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.szakteruletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alsoHatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felsoHatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAllDataForTable;
        private tanacsadoDataSet tanacsadoDataSet;
        private tanacsadoDataSetTableAdapters.AllDataTableAdapter allDataTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Szűrésbe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Szakterulet;
        private System.Windows.Forms.BindingSource szakteruletBindingSource;
        private tanacsadoDataSetTableAdapters.szakteruletTableAdapter szakteruletTableAdapter;
        private System.Windows.Forms.Button Szűréski;
        private System.Windows.Forms.Button ExportAllData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Óradíj_alsó_határa;
        private System.Windows.Forms.Label Óradíj_felső_határa;
        private System.Windows.Forms.GroupBox Szűrők;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Szakterület;
        private System.Windows.Forms.Label Adatok_exportálása;
        private System.Windows.Forms.Label Új_találkozó_felvétele;
        private System.Windows.Forms.Button UjTalalkozoFelvetele;
        private System.Windows.Forms.Label Bezárás;
        private System.Windows.Forms.Button Bezaras;
        private System.Windows.Forms.NumericUpDown alsoHatar;
        private System.Windows.Forms.NumericUpDown felsoHatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóDátumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóKezdésiIdőpontjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ügyfélNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanácsadóNeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szakterületMegnevezéseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóIdőtartamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanácsadóÓradíjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn találkozóértFizetendőÖsszegDataGridViewTextBoxColumn;
    }
}

