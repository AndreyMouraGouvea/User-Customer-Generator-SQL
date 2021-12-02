namespace licaods
{
    partial class frmfornecedor
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nr_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.Windows.Forms.Label sg_tipoLabel;
            System.Windows.Forms.Label ds_emailLabel;
            System.Windows.Forms.Label nm_contatoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfornecedor));
            this.cadastroDataSet = new licaods.cadastroDataSet();
            this.tbfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfornecedorTableAdapter = new licaods.cadastroDataSetTableAdapters.tbfornecedorTableAdapter();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nr_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.cd_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cd_cpfTextBox = new System.Windows.Forms.TextBox();
            this.cd_rgTextBox = new System.Windows.Forms.TextBox();
            this.cd_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.cd_ieTextBox = new System.Windows.Forms.TextBox();
            this.sg_tipoTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.nm_contatoTextBox = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nr_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            sg_tipoLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            nm_contatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(117, 35);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(59, 20);
            cd_fornecedorLabel.TabIndex = 1;
            cd_fornecedorLabel.Text = "Código";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(117, 61);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(51, 20);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(117, 87);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(78, 20);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nr_enderecoLabel
            // 
            nr_enderecoLabel.AutoSize = true;
            nr_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_enderecoLabel.Location = new System.Drawing.Point(118, 113);
            nr_enderecoLabel.Name = "nr_enderecoLabel";
            nr_enderecoLabel.Size = new System.Drawing.Size(68, 20);
            nr_enderecoLabel.TabIndex = 7;
            nr_enderecoLabel.Text = "Nº Local";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(117, 139);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(51, 20);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(117, 165);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(59, 20);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(117, 191);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(60, 20);
            sg_estadoLabel.TabIndex = 13;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(117, 217);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(41, 20);
            cd_cepLabel.TabIndex = 15;
            cd_cepLabel.Text = "CEP";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_telefoneLabel.Location = new System.Drawing.Point(117, 243);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(71, 20);
            cd_telefoneLabel.TabIndex = 17;
            cd_telefoneLabel.Text = "Telefone";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Location = new System.Drawing.Point(117, 269);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(40, 20);
            cd_cpfLabel.TabIndex = 19;
            cd_cpfLabel.Text = "CPF";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_rgLabel.Location = new System.Drawing.Point(117, 295);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(34, 20);
            cd_rgLabel.TabIndex = 21;
            cd_rgLabel.Text = "RG";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(117, 321);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(49, 20);
            cd_cnpjLabel.TabIndex = 23;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel.Location = new System.Drawing.Point(63, 347);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(140, 20);
            cd_ieLabel.TabIndex = 25;
            cd_ieLabel.Text = "Inscrição Estadual";
            cd_ieLabel.Click += new System.EventHandler(this.cd_ieLabel_Click);
            // 
            // sg_tipoLabel
            // 
            sg_tipoLabel.AutoSize = true;
            sg_tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_tipoLabel.Location = new System.Drawing.Point(117, 373);
            sg_tipoLabel.Name = "sg_tipoLabel";
            sg_tipoLabel.Size = new System.Drawing.Size(86, 20);
            sg_tipoLabel.TabIndex = 27;
            sg_tipoLabel.Text = "UF Estado";
            sg_tipoLabel.Click += new System.EventHandler(this.sg_tipoLabel_Click);
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Location = new System.Drawing.Point(117, 399);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(48, 20);
            ds_emailLabel.TabIndex = 29;
            ds_emailLabel.Text = "Email";
            ds_emailLabel.Click += new System.EventHandler(this.ds_emailLabel_Click);
            // 
            // nm_contatoLabel
            // 
            nm_contatoLabel.AutoSize = true;
            nm_contatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_contatoLabel.Location = new System.Drawing.Point(117, 425);
            nm_contatoLabel.Name = "nm_contatoLabel";
            nm_contatoLabel.Size = new System.Drawing.Size(66, 20);
            nm_contatoLabel.TabIndex = 31;
            nm_contatoLabel.Text = "Contato";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfornecedorBindingSource
            // 
            this.tbfornecedorBindingSource.DataMember = "tbfornecedor";
            this.tbfornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbfornecedorTableAdapter
            // 
            this.tbfornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(220, 29);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_fornecedorTextBox.TabIndex = 2;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(220, 55);
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(100, 26);
            this.nm_fornecedorTextBox.TabIndex = 4;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(220, 81);
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(100, 26);
            this.ds_enderecoTextBox.TabIndex = 6;
            // 
            // nr_enderecoTextBox
            // 
            this.nr_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nr_endereco", true));
            this.nr_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_enderecoTextBox.Location = new System.Drawing.Point(220, 107);
            this.nr_enderecoTextBox.Name = "nr_enderecoTextBox";
            this.nr_enderecoTextBox.Size = new System.Drawing.Size(100, 26);
            this.nr_enderecoTextBox.TabIndex = 8;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(220, 133);
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(100, 26);
            this.nm_bairroTextBox.TabIndex = 10;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(220, 159);
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(100, 26);
            this.nm_cidadeTextBox.TabIndex = 12;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(220, 185);
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(100, 26);
            this.sg_estadoTextBox.TabIndex = 14;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepTextBox.Location = new System.Drawing.Point(220, 211);
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_cepTextBox.TabIndex = 16;
            // 
            // cd_telefoneTextBox
            // 
            this.cd_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_telefone", true));
            this.cd_telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_telefoneTextBox.Location = new System.Drawing.Point(220, 237);
            this.cd_telefoneTextBox.Name = "cd_telefoneTextBox";
            this.cd_telefoneTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_telefoneTextBox.TabIndex = 18;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cpfTextBox.Location = new System.Drawing.Point(220, 263);
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_cpfTextBox.TabIndex = 20;
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_rg", true));
            this.cd_rgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_rgTextBox.Location = new System.Drawing.Point(220, 289);
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_rgTextBox.TabIndex = 22;
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(220, 315);
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_cnpjTextBox.TabIndex = 24;
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_ie", true));
            this.cd_ieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ieTextBox.Location = new System.Drawing.Point(220, 341);
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(100, 26);
            this.cd_ieTextBox.TabIndex = 26;
            // 
            // sg_tipoTextBox
            // 
            this.sg_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "sg_tipo", true));
            this.sg_tipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_tipoTextBox.Location = new System.Drawing.Point(220, 367);
            this.sg_tipoTextBox.Name = "sg_tipoTextBox";
            this.sg_tipoTextBox.Size = new System.Drawing.Size(100, 26);
            this.sg_tipoTextBox.TabIndex = 28;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "ds_email", true));
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_emailTextBox.Location = new System.Drawing.Point(220, 393);
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.ds_emailTextBox.TabIndex = 30;
            // 
            // nm_contatoTextBox
            // 
            this.nm_contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_contato", true));
            this.nm_contatoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_contatoTextBox.Location = new System.Drawing.Point(220, 419);
            this.nm_contatoTextBox.Name = "nm_contatoTextBox";
            this.nm_contatoTextBox.Size = new System.Drawing.Size(100, 26);
            this.nm_contatoTextBox.TabIndex = 32;
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(470, 514);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(100, 30);
            this.btnsair.TabIndex = 42;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.AutoSize = true;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(364, 514);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(100, 30);
            this.btnimprimir.TabIndex = 41;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.AutoSize = true;
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(258, 514);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnpesquisar.TabIndex = 40;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(152, 514);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.AutoSize = true;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(46, 514);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(100, 30);
            this.btnsalvar.TabIndex = 38;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.AutoSize = true;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(470, 478);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(100, 30);
            this.btnexcluir.TabIndex = 37;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.AutoSize = true;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(364, 478);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(100, 30);
            this.btnalterar.TabIndex = 36;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.AutoSize = true;
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Location = new System.Drawing.Point(258, 478);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(100, 30);
            this.btnnovo.TabIndex = 35;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.AutoSize = true;
            this.btnproximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproximo.Location = new System.Drawing.Point(152, 478);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(100, 30);
            this.btnproximo.TabIndex = 34;
            this.btnproximo.Text = "Proximo";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.AutoSize = true;
            this.btnanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanterior.Location = new System.Drawing.Point(46, 478);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(100, 30);
            this.btnanterior.TabIndex = 33;
            this.btnanterior.Text = "Anterior";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmfornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 601);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nr_enderecoLabel);
            this.Controls.Add(this.nr_enderecoTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(cd_telefoneLabel);
            this.Controls.Add(this.cd_telefoneTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.cd_cnpjTextBox);
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.cd_ieTextBox);
            this.Controls.Add(sg_tipoLabel);
            this.Controls.Add(this.sg_tipoTextBox);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(nm_contatoLabel);
            this.Controls.Add(this.nm_contatoTextBox);
            this.Name = "frmfornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmfornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource;
        private cadastroDataSetTableAdapters.tbfornecedorTableAdapter tbfornecedorTableAdapter;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nr_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox cd_telefoneTextBox;
        private System.Windows.Forms.TextBox cd_cpfTextBox;
        private System.Windows.Forms.TextBox cd_rgTextBox;
        private System.Windows.Forms.TextBox cd_cnpjTextBox;
        private System.Windows.Forms.TextBox cd_ieTextBox;
        private System.Windows.Forms.TextBox sg_tipoTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.TextBox nm_contatoTextBox;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Button btnanterior;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}