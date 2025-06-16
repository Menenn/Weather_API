namespace Qualit_Weather
{
    partial class Main
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTop = new Wisej.Web.Panel();
            this.btnLogin = new Wisej.Web.Button();
            this.btnRegistrar = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.pnlSubTop = new Wisej.Web.Panel();
            this.cb5Dias = new Wisej.Web.CheckBox();
            this.cbEstado = new Wisej.Web.ComboBox();
            this.btnPesquisar = new Wisej.Web.Button();
            this.txtNomeCidade = new Wisej.Web.TextBox();
            this.pnlMain = new Wisej.Web.Panel();
            this.btnFavoritarCidade = new Wisej.Web.Button();
            this.htmlMain = new Wisej.Web.HtmlPanel();
            this.pnlFavoritos = new Wisej.Web.Panel();
            this.pnlFavMain = new Wisej.Web.Panel();
            this.dtFavoritos = new Wisej.Web.DataRepeater();
            this.btnDeletarCidadeFav = new Wisej.Web.Button();
            this.btnPesquisarCidadeFav = new Wisej.Web.Button();
            this.picCity = new Wisej.Web.PictureBox();
            this.txtCidade = new Wisej.Web.Label();
            this.pnlFavTop = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.pnlTop.SuspendLayout();
            this.pnlSubTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFavoritos.SuspendLayout();
            this.pnlFavMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFavoritos)).BeginInit();
            this.dtFavoritos.ItemTemplate.SuspendLayout();
            this.dtFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).BeginInit();
            this.pnlFavTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.pnlTop.Controls.Add(this.btnLogin);
            this.pnlTop.Controls.Add(this.btnRegistrar);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = Wisej.Web.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1516, 64);
            this.pnlTop.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromName("@primary");
            this.btnLogin.ForeColor = System.Drawing.Color.FromName("@window");
            this.btnLogin.Location = new System.Drawing.Point(1425, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromName("@window");
            this.btnRegistrar.Location = new System.Drawing.Point(1333, 16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(77, 37);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromName("@table-row-selected");
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clima";
            // 
            // pnlSubTop
            // 
            this.pnlSubTop.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlSubTop.Controls.Add(this.cb5Dias);
            this.pnlSubTop.Controls.Add(this.cbEstado);
            this.pnlSubTop.Controls.Add(this.btnPesquisar);
            this.pnlSubTop.Controls.Add(this.txtNomeCidade);
            this.pnlSubTop.CssStyle = "border-radius: 0px;\r\nborder-top: 0px;\r\nborder-left: 0px;\r\nborder-right: 0px;";
            this.pnlSubTop.Dock = Wisej.Web.DockStyle.Top;
            this.pnlSubTop.Location = new System.Drawing.Point(0, 64);
            this.pnlSubTop.Name = "pnlSubTop";
            this.pnlSubTop.Size = new System.Drawing.Size(1516, 48);
            this.pnlSubTop.TabIndex = 3;
            // 
            // cb5Dias
            // 
            this.cb5Dias.Location = new System.Drawing.Point(432, 16);
            this.cb5Dias.Name = "cb5Dias";
            this.cb5Dias.Size = new System.Drawing.Size(149, 23);
            this.cb5Dias.TabIndex = 3;
            this.cb5Dias.Text = "Previsão para 5 dias";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cbEstado.Items.AddRange(new object[] {
            "AC - Acre",
            "AL - Alagoas",
            "AP - Amapá",
            "AM - Amazonas",
            "BA - Bahia",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MT - Mato Grosso",
            "MS - Mato Grosso do Sul",
            "MG - Minas Gerais",
            "PA - Pará",
            "PB - Paraíba",
            "PR - Paraná",
            "PE - Pernambuco",
            "PI - Piauí",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RS - Rio Grande do Sul",
            "RO - Rondônia",
            "RR - Roraima",
            "SC - Santa Catarina",
            "SP - São Paulo",
            "SE - Sergipe",
            "TO - Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(221, 9);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(159, 30);
            this.cbEstado.TabIndex = 2;
            this.cbEstado.Watermark = "Estado";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.btnPesquisar.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.btnPesquisar.BackgroundImageSource = "Imagens/Icones/icons8-search-96.png";
            this.btnPesquisar.Location = new System.Drawing.Point(386, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.CssStyle = "border-radius: 4px;";
            this.txtNomeCidade.Location = new System.Drawing.Point(11, 9);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(204, 30);
            this.txtNomeCidade.TabIndex = 0;
            this.txtNomeCidade.Watermark = "Nome Cidade";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnFavoritarCidade);
            this.pnlMain.Controls.Add(this.htmlMain);
            this.pnlMain.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 112);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1184, 716);
            this.pnlMain.TabIndex = 4;
            // 
            // btnFavoritarCidade
            // 
            this.btnFavoritarCidade.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnFavoritarCidade.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.btnFavoritarCidade.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.btnFavoritarCidade.BackgroundImageSource = "Imagens/Icones/icons8-add-to-favorites-100.png";
            this.btnFavoritarCidade.Location = new System.Drawing.Point(1135, 17);
            this.btnFavoritarCidade.Name = "btnFavoritarCidade";
            this.btnFavoritarCidade.Size = new System.Drawing.Size(30, 30);
            this.btnFavoritarCidade.TabIndex = 2;
            this.btnFavoritarCidade.ToolTipText = "Favoritar Cidade";
            this.btnFavoritarCidade.Visible = false;
            this.btnFavoritarCidade.Click += new System.EventHandler(this.btnFavoritarCidade_Click);
            // 
            // htmlMain
            // 
            this.htmlMain.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlMain.Focusable = false;
            this.htmlMain.Html = resources.GetString("htmlMain.Html");
            this.htmlMain.Location = new System.Drawing.Point(0, 0);
            this.htmlMain.Name = "htmlMain";
            this.htmlMain.Size = new System.Drawing.Size(1184, 716);
            this.htmlMain.TabIndex = 3;
            this.htmlMain.TabStop = false;
            // 
            // pnlFavoritos
            // 
            this.pnlFavoritos.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pnlFavoritos.Controls.Add(this.pnlFavMain);
            this.pnlFavoritos.Controls.Add(this.pnlFavTop);
            this.pnlFavoritos.CssStyle = "border-radius: 0px;\r\nborder-top: 0px;\r\nborder-bottom: 0px;\r\nborder-right: 0px;";
            this.pnlFavoritos.Dock = Wisej.Web.DockStyle.Right;
            this.pnlFavoritos.Location = new System.Drawing.Point(1184, 112);
            this.pnlFavoritos.Name = "pnlFavoritos";
            this.pnlFavoritos.Size = new System.Drawing.Size(332, 716);
            this.pnlFavoritos.TabIndex = 5;
            this.pnlFavoritos.Visible = false;
            // 
            // pnlFavMain
            // 
            this.pnlFavMain.Controls.Add(this.dtFavoritos);
            this.pnlFavMain.Dock = Wisej.Web.DockStyle.Fill;
            this.pnlFavMain.Location = new System.Drawing.Point(0, 47);
            this.pnlFavMain.Name = "pnlFavMain";
            this.pnlFavMain.Size = new System.Drawing.Size(330, 667);
            this.pnlFavMain.TabIndex = 3;
            // 
            // dtFavoritos
            // 
            this.dtFavoritos.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dtFavoritos.Dock = Wisej.Web.DockStyle.Fill;
            this.dtFavoritos.ItemHeaderVisible = false;
            this.dtFavoritos.ItemSize = new System.Drawing.Size(200, 45);
            // 
            // dtFavoritos.ItemTemplate
            // 
            this.dtFavoritos.ItemTemplate.Controls.Add(this.btnDeletarCidadeFav);
            this.dtFavoritos.ItemTemplate.Controls.Add(this.btnPesquisarCidadeFav);
            this.dtFavoritos.ItemTemplate.Controls.Add(this.picCity);
            this.dtFavoritos.ItemTemplate.Controls.Add(this.txtCidade);
            this.dtFavoritos.ItemTemplate.Size = new System.Drawing.Size(330, 45);
            this.dtFavoritos.Location = new System.Drawing.Point(0, 0);
            this.dtFavoritos.Name = "dtFavoritos";
            this.dtFavoritos.Size = new System.Drawing.Size(330, 667);
            this.dtFavoritos.TabIndex = 0;
            this.dtFavoritos.Text = "dataRepeater1";
            this.dtFavoritos.ItemUpdate += new Wisej.Web.DataRepeaterItemEventHandler(this.dtFavoritos_ItemUpdate);
            // 
            // btnDeletarCidadeFav
            // 
            this.btnDeletarCidadeFav.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.btnDeletarCidadeFav.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.btnDeletarCidadeFav.BackgroundImageSource = "Imagens/Icones/icons8-close-window-100-2.png";
            this.btnDeletarCidadeFav.Location = new System.Drawing.Point(300, 10);
            this.btnDeletarCidadeFav.Name = "btnDeletarCidadeFav";
            this.btnDeletarCidadeFav.Size = new System.Drawing.Size(25, 25);
            this.btnDeletarCidadeFav.TabIndex = 5;
            this.btnDeletarCidadeFav.Click += new System.EventHandler(this.btnDeletarCidadeFav_Click);
            // 
            // btnPesquisarCidadeFav
            // 
            this.btnPesquisarCidadeFav.BackColor = System.Drawing.Color.FromName("@table-row-background-selected");
            this.btnPesquisarCidadeFav.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.btnPesquisarCidadeFav.BackgroundImageSource = "Imagens/Icones/icons8-search-96.png";
            this.btnPesquisarCidadeFav.Location = new System.Drawing.Point(269, 10);
            this.btnPesquisarCidadeFav.Name = "btnPesquisarCidadeFav";
            this.btnPesquisarCidadeFav.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisarCidadeFav.TabIndex = 4;
            this.btnPesquisarCidadeFav.Click += new System.EventHandler(this.btnPesquisarCidadeFav_Click);
            // 
            // picCity
            // 
            this.picCity.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.picCity.BackgroundImageSource = "Imagens/Icones/icons8-cityscape-96.png";
            this.picCity.Location = new System.Drawing.Point(5, 8);
            this.picCity.Name = "picCity";
            this.picCity.Size = new System.Drawing.Size(30, 30);
            // 
            // txtCidade
            // 
            this.txtCidade.AutoSize = true;
            this.txtCidade.Font = new System.Drawing.Font("Helvetica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.ForeColor = System.Drawing.Color.FromName("@table-row-selected");
            this.txtCidade.Location = new System.Drawing.Point(39, 15);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 18);
            this.txtCidade.TabIndex = 2;
            this.txtCidade.Text = "Cidade Cidade - Estado";
            // 
            // pnlFavTop
            // 
            this.pnlFavTop.Controls.Add(this.label2);
            this.pnlFavTop.Dock = Wisej.Web.DockStyle.Top;
            this.pnlFavTop.Location = new System.Drawing.Point(0, 0);
            this.pnlFavTop.Name = "pnlFavTop";
            this.pnlFavTop.Size = new System.Drawing.Size(330, 47);
            this.pnlFavTop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@table-row-selected");
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Favoritos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFavoritos);
            this.Controls.Add(this.pnlSubTop);
            this.Controls.Add(this.pnlTop);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1516, 828);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSubTop.ResumeLayout(false);
            this.pnlSubTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlFavoritos.ResumeLayout(false);
            this.pnlFavMain.ResumeLayout(false);
            this.dtFavoritos.ItemTemplate.ResumeLayout(false);
            this.dtFavoritos.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFavoritos)).EndInit();
            this.dtFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCity)).EndInit();
            this.pnlFavTop.ResumeLayout(false);
            this.pnlFavTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Wisej.Web.Panel pnlTop;
        private Wisej.Web.Panel pnlSubTop;
        private Wisej.Web.TextBox txtNomeCidade;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button btnPesquisar;
        private Wisej.Web.ComboBox cbEstado;
        private Wisej.Web.Panel pnlMain;
        private Wisej.Web.Panel pnlFavoritos;
        private Wisej.Web.Button btnFavoritarCidade;
        private Wisej.Web.Label label2;
        private Wisej.Web.Panel pnlFavTop;
        private Wisej.Web.Panel pnlFavMain;
        private Wisej.Web.CheckBox cb5Dias;
        private Wisej.Web.HtmlPanel htmlMain;
        private Wisej.Web.Button btnRegistrar;
        private Wisej.Web.Button btnLogin;
        private Wisej.Web.DataRepeater dtFavoritos;
        private Wisej.Web.Label txtCidade;
        private Wisej.Web.PictureBox picCity;
        private Wisej.Web.Button btnPesquisarCidadeFav;
        private Wisej.Web.Button btnDeletarCidadeFav;
    }
}
