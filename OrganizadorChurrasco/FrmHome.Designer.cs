namespace OrganizadorChurrasco
{
    partial class FrmHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbUnidMedida = new System.Windows.Forms.ComboBox();
            this.NudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.BtnAdicionarItem = new System.Windows.Forms.Button();
            this.BtnRemoverItem = new System.Windows.Forms.Button();
            this.MtcData = new System.Windows.Forms.MonthCalendar();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpHora = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.LblDiasRestantes = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LblQtdeItensPendentes = new System.Windows.Forms.Label();
            this.TltMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.opçõesDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDiasChurrasco = new System.Windows.Forms.ToolStripMenuItem();
            this.miCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.convidadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCadastrarConvidado = new System.Windows.Forms.ToolStripMenuItem();
            this.miPesquisarConvidados = new System.Windows.Forms.ToolStripMenuItem();
            this.miQtdeConvidados = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSobreSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.MsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(37)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORGANIZADOR DE CHURRASCO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(79, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programador de Sistemas Senac - v2.0";
            // 
            // TxtItem
            // 
            this.TxtItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.Location = new System.Drawing.Point(12, 156);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(652, 26);
            this.TxtItem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição do Item: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unid. Medida:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(850, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Qtde:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preço:";
            // 
            // CmbUnidMedida
            // 
            this.CmbUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbUnidMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUnidMedida.FormattingEnabled = true;
            this.CmbUnidMedida.Items.AddRange(new object[] {
            "Unidade",
            "Pacote",
            "Quilo",
            "Grama",
            "Litro"});
            this.CmbUnidMedida.Location = new System.Drawing.Point(682, 155);
            this.CmbUnidMedida.Name = "CmbUnidMedida";
            this.CmbUnidMedida.Size = new System.Drawing.Size(152, 28);
            this.CmbUnidMedida.TabIndex = 8;
            // 
            // NudQuantidade
            // 
            this.NudQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudQuantidade.Location = new System.Drawing.Point(853, 156);
            this.NudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantidade.Name = "NudQuantidade";
            this.NudQuantidade.Size = new System.Drawing.Size(62, 26);
            this.NudQuantidade.TabIndex = 9;
            this.NudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtPreco
            // 
            this.TxtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreco.Location = new System.Drawing.Point(930, 156);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(111, 26);
            this.TxtPreco.TabIndex = 10;
            this.TxtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPreco_KeyDown);
            // 
            // BtnAdicionarItem
            // 
            this.BtnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(37)))), ((int)(((byte)(81)))));
            this.BtnAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdicionarItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnAdicionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.BtnAdicionarItem.Location = new System.Drawing.Point(983, 203);
            this.BtnAdicionarItem.Name = "BtnAdicionarItem";
            this.BtnAdicionarItem.Size = new System.Drawing.Size(26, 27);
            this.BtnAdicionarItem.TabIndex = 11;
            this.BtnAdicionarItem.Text = "+";
            this.TltMensagem.SetToolTip(this.BtnAdicionarItem, "Clique aqui para ADICIONAR o item na lista!");
            this.BtnAdicionarItem.UseVisualStyleBackColor = false;
            this.BtnAdicionarItem.Click += new System.EventHandler(this.BtnAdicionarItem_Click);
            // 
            // BtnRemoverItem
            // 
            this.BtnRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoverItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(37)))), ((int)(((byte)(81)))));
            this.BtnRemoverItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoverItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnRemoverItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.BtnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.BtnRemoverItem.Location = new System.Drawing.Point(1015, 203);
            this.BtnRemoverItem.Name = "BtnRemoverItem";
            this.BtnRemoverItem.Size = new System.Drawing.Size(26, 27);
            this.BtnRemoverItem.TabIndex = 12;
            this.BtnRemoverItem.Text = "-";
            this.TltMensagem.SetToolTip(this.BtnRemoverItem, "Clique aqui para REMOVER o item da lista!");
            this.BtnRemoverItem.UseVisualStyleBackColor = false;
            this.BtnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // MtcData
            // 
            this.MtcData.Location = new System.Drawing.Point(13, 227);
            this.MtcData.MaxSelectionCount = 1;
            this.MtcData.Name = "MtcData";
            this.MtcData.ShowToday = false;
            this.MtcData.TabIndex = 14;
            this.MtcData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MtcData_DateChanged);
            // 
            // DgvItems
            // 
            this.DgvItems.AllowUserToAddRows = false;
            this.DgvItems.AllowUserToDeleteRows = false;
            this.DgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvItems.BackgroundColor = System.Drawing.Color.White;
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.item,
            this.unidmedida,
            this.quantidade,
            this.preco,
            this.total,
            this.status});
            this.DgvItems.Location = new System.Drawing.Point(252, 236);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.ReadOnly = true;
            this.DgvItems.RowHeadersVisible = false;
            this.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItems.Size = new System.Drawing.Size(789, 267);
            this.DgvItems.TabIndex = 15;
            this.DgvItems.DoubleClick += new System.EventHandler(this.DgvItems_DoubleClick);
            this.DgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvItems_KeyDown);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // unidmedida
            // 
            this.unidmedida.HeaderText = "Unidade de Medida";
            this.unidmedida.Name = "unidmedida";
            this.unidmedida.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lista de Items do Churrasco:";
            // 
            // DtpHora
            // 
            this.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHora.Location = new System.Drawing.Point(15, 413);
            this.DtpHora.Name = "DtpHora";
            this.DtpHora.ShowUpDown = true;
            this.DtpHora.Size = new System.Drawing.Size(225, 20);
            this.DtpHora.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Horário do Churrasco:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(37)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LblDiasRestantes);
            this.panel1.Location = new System.Drawing.Point(15, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 75);
            this.panel1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.label11.Location = new System.Drawing.Point(42, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "para o churrasco rolar!";
            // 
            // LblDiasRestantes
            // 
            this.LblDiasRestantes.AutoSize = true;
            this.LblDiasRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiasRestantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.LblDiasRestantes.Location = new System.Drawing.Point(40, 18);
            this.LblDiasRestantes.Name = "LblDiasRestantes";
            this.LblDiasRestantes.Size = new System.Drawing.Size(144, 24);
            this.LblDiasRestantes.TabIndex = 20;
            this.LblDiasRestantes.Text = "Faltam 00 dias";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(37)))), ((int)(((byte)(81)))));
            this.TxtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(15)))));
            this.TxtValorTotal.Location = new System.Drawing.Point(896, 514);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.ReadOnly = true;
            this.TxtValorTotal.Size = new System.Drawing.Size(145, 31);
            this.TxtValorTotal.TabIndex = 21;
            this.TxtValorTotal.Text = "R$ 0,00";
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.label12.Location = new System.Drawing.Point(829, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "TOTAL:";
            // 
            // LblQtdeItensPendentes
            // 
            this.LblQtdeItensPendentes.AutoSize = true;
            this.LblQtdeItensPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtdeItensPendentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(144)))), ((int)(((byte)(35)))));
            this.LblQtdeItensPendentes.Location = new System.Drawing.Point(20, 6);
            this.LblQtdeItensPendentes.Name = "LblQtdeItensPendentes";
            this.LblQtdeItensPendentes.Size = new System.Drawing.Size(117, 16);
            this.LblQtdeItensPendentes.TabIndex = 22;
            this.LblQtdeItensPendentes.Text = "0 items pendentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Data do Churrasco:";
            // 
            // MsMenu
            // 
            this.MsMenu.BackColor = System.Drawing.Color.Transparent;
            this.MsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesDoSistemaToolStripMenuItem,
            this.convidadosToolStripMenuItem,
            this.miSobreSistema});
            this.MsMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MsMenu.Size = new System.Drawing.Size(1028, 28);
            this.MsMenu.TabIndex = 24;
            this.MsMenu.Text = "menuStrip1";
            // 
            // opçõesDoSistemaToolStripMenuItem
            // 
            this.opçõesDoSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDiasChurrasco,
            this.miCalculadora,
            this.toolStripSeparator1,
            this.miSairSistema});
            this.opçõesDoSistemaToolStripMenuItem.Image = global::OrganizadorChurrasco.Properties.Resources.wrench;
            this.opçõesDoSistemaToolStripMenuItem.Name = "opçõesDoSistemaToolStripMenuItem";
            this.opçõesDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.opçõesDoSistemaToolStripMenuItem.Text = "Opções do Sistema";
            // 
            // miDiasChurrasco
            // 
            this.miDiasChurrasco.Image = global::OrganizadorChurrasco.Properties.Resources.date_go;
            this.miDiasChurrasco.Name = "miDiasChurrasco";
            this.miDiasChurrasco.Size = new System.Drawing.Size(188, 22);
            this.miDiasChurrasco.Text = "Dias para o churrasco";
            this.miDiasChurrasco.Click += new System.EventHandler(this.miDiasChurrasco_Click);
            // 
            // miCalculadora
            // 
            this.miCalculadora.Image = global::OrganizadorChurrasco.Properties.Resources.calculator;
            this.miCalculadora.Name = "miCalculadora";
            this.miCalculadora.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.miCalculadora.Size = new System.Drawing.Size(188, 22);
            this.miCalculadora.Text = "Calculadora";
            this.miCalculadora.Click += new System.EventHandler(this.miCalculadora_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // miSairSistema
            // 
            this.miSairSistema.Image = global::OrganizadorChurrasco.Properties.Resources.door_out;
            this.miSairSistema.Name = "miSairSistema";
            this.miSairSistema.Size = new System.Drawing.Size(188, 22);
            this.miSairSistema.Text = "&Sair do Sistema";
            this.miSairSistema.Click += new System.EventHandler(this.miSairSistema_Click);
            // 
            // convidadosToolStripMenuItem
            // 
            this.convidadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCadastrarConvidado,
            this.miPesquisarConvidados,
            this.miQtdeConvidados,
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem});
            this.convidadosToolStripMenuItem.Image = global::OrganizadorChurrasco.Properties.Resources.user;
            this.convidadosToolStripMenuItem.Name = "convidadosToolStripMenuItem";
            this.convidadosToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.convidadosToolStripMenuItem.Text = "Convidados";
            // 
            // miCadastrarConvidado
            // 
            this.miCadastrarConvidado.Image = global::OrganizadorChurrasco.Properties.Resources.user_add;
            this.miCadastrarConvidado.Name = "miCadastrarConvidado";
            this.miCadastrarConvidado.Size = new System.Drawing.Size(290, 22);
            this.miCadastrarConvidado.Text = "Cadastrar convidado";
            this.miCadastrarConvidado.Click += new System.EventHandler(this.miCadastrarConvidado_Click);
            // 
            // miPesquisarConvidados
            // 
            this.miPesquisarConvidados.Image = global::OrganizadorChurrasco.Properties.Resources.magnifier;
            this.miPesquisarConvidados.Name = "miPesquisarConvidados";
            this.miPesquisarConvidados.Size = new System.Drawing.Size(290, 22);
            this.miPesquisarConvidados.Text = "Pesquisar convidados";
            this.miPesquisarConvidados.Click += new System.EventHandler(this.miPesquisarConvidados_Click);
            // 
            // miQtdeConvidados
            // 
            this.miQtdeConvidados.Image = global::OrganizadorChurrasco.Properties.Resources.user_comment;
            this.miQtdeConvidados.Name = "miQtdeConvidados";
            this.miQtdeConvidados.Size = new System.Drawing.Size(290, 22);
            this.miQtdeConvidados.Text = "Quantidade Total de Convidados";
            this.miQtdeConvidados.Click += new System.EventHandler(this.miQtdeConvidados_Click);
            // 
            // miQuantidadeDeConvidadosConfirmadosToolStripMenuItem
            // 
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem.Image = global::OrganizadorChurrasco.Properties.Resources.user_go;
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem.Name = "miQuantidadeDeConvidadosConfirmadosToolStripMenuItem";
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem.Text = "Quantidade de Convidados Confirmados";
            this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem.Click += new System.EventHandler(this.miQuantidadeDeConvidadosConfirmadosToolStripMenuItem_Click);
            // 
            // miSobreSistema
            // 
            this.miSobreSistema.Image = global::OrganizadorChurrasco.Properties.Resources.information;
            this.miSobreSistema.Name = "miSobreSistema";
            this.miSobreSistema.Size = new System.Drawing.Size(123, 24);
            this.miSobreSistema.Text = "Sobre o Sistema";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OrganizadorChurrasco.Properties.Resources.bell;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 24);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OrganizadorChurrasco.Properties.Resources.sausage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.LblQtdeItensPendentes);
            this.panel2.Location = new System.Drawing.Point(904, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 27);
            this.panel2.TabIndex = 26;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvItems);
            this.Controls.Add(this.MtcData);
            this.Controls.Add(this.BtnRemoverItem);
            this.Controls.Add(this.BtnAdicionarItem);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.NudQuantidade);
            this.Controls.Add(this.CmbUnidMedida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsMenu;
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizador de Churrasco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbUnidMedida;
        private System.Windows.Forms.NumericUpDown NudQuantidade;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Button BtnAdicionarItem;
        private System.Windows.Forms.Button BtnRemoverItem;
        private System.Windows.Forms.MonthCalendar MtcData;
        private System.Windows.Forms.DataGridView DgvItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblDiasRestantes;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblQtdeItensPendentes;
        private System.Windows.Forms.ToolTip TltMensagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem opçõesDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDiasChurrasco;
        private System.Windows.Forms.ToolStripMenuItem miCalculadora;
        private System.Windows.Forms.ToolStripMenuItem miSairSistema;
        private System.Windows.Forms.ToolStripMenuItem convidadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCadastrarConvidado;
        private System.Windows.Forms.ToolStripMenuItem miSobreSistema;
        private System.Windows.Forms.ToolStripMenuItem miQtdeConvidados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miQuantidadeDeConvidadosConfirmadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem miPesquisarConvidados;
        private System.Windows.Forms.Panel panel2;
    }
}

