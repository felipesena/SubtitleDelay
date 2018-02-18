namespace Legenda
{
    partial class frmLegenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegenda));
            this.txbArquivo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lbDelay = new System.Windows.Forms.Label();
            this.rbAtrasada = new System.Windows.Forms.RadioButton();
            this.rbAdiantada = new System.Windows.Forms.RadioButton();
            this.txbDelay = new System.Windows.Forms.MaskedTextBox();
            this.txbFala = new System.Windows.Forms.TextBox();
            this.lbInicio = new System.Windows.Forms.Label();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.lbAPartirDe = new System.Windows.Forms.Label();
            this.lbFala = new System.Windows.Forms.Label();
            this.cbFalas = new System.Windows.Forms.ComboBox();
            this.lbLegendaStatus = new System.Windows.Forms.Label();
            this.btnProcurarFala = new System.Windows.Forms.Button();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.lbLegenda = new System.Windows.Forms.Label();
            this.lbFalas = new System.Windows.Forms.Label();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbArquivo
            // 
            this.txbArquivo.Enabled = false;
            this.txbArquivo.Location = new System.Drawing.Point(75, 12);
            this.txbArquivo.Name = "txbArquivo";
            this.txbArquivo.ReadOnly = true;
            this.txbArquivo.Size = new System.Drawing.Size(149, 20);
            this.txbArquivo.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(230, 11);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "&Procurar...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lbDelay
            // 
            this.lbDelay.AutoSize = true;
            this.lbDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelay.Location = new System.Drawing.Point(3, 160);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(103, 13);
            this.lbDelay.TabIndex = 2;
            this.lbDelay.Text = "Tempo de Delay:";
            // 
            // rbAtrasada
            // 
            this.rbAtrasada.AutoSize = true;
            this.rbAtrasada.Checked = true;
            this.rbAtrasada.Location = new System.Drawing.Point(3, 59);
            this.rbAtrasada.Name = "rbAtrasada";
            this.rbAtrasada.Size = new System.Drawing.Size(67, 17);
            this.rbAtrasada.TabIndex = 7;
            this.rbAtrasada.TabStop = true;
            this.rbAtrasada.Text = "Atrasada";
            this.rbAtrasada.UseVisualStyleBackColor = true;
            // 
            // rbAdiantada
            // 
            this.rbAdiantada.AutoSize = true;
            this.rbAdiantada.Location = new System.Drawing.Point(3, 94);
            this.rbAdiantada.Name = "rbAdiantada";
            this.rbAdiantada.Size = new System.Drawing.Size(73, 17);
            this.rbAdiantada.TabIndex = 8;
            this.rbAdiantada.Text = "Adiantada";
            this.rbAdiantada.UseVisualStyleBackColor = true;
            // 
            // txbDelay
            // 
            this.txbDelay.Location = new System.Drawing.Point(110, 157);
            this.txbDelay.Mask = "00.000 s";
            this.txbDelay.Name = "txbDelay";
            this.txbDelay.Size = new System.Drawing.Size(86, 20);
            this.txbDelay.TabIndex = 9;
            this.txbDelay.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txbFala
            // 
            this.txbFala.Location = new System.Drawing.Point(217, 67);
            this.txbFala.Name = "txbFala";
            this.txbFala.Size = new System.Drawing.Size(106, 20);
            this.txbFala.TabIndex = 10;
            this.txbFala.Visible = false;
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(120, 70);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(91, 13);
            this.lbInicio.TabIndex = 11;
            this.lbInicio.Text = "Pesquisar fala:";
            this.lbInicio.Visible = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.lbFalas);
            this.pnPrincipal.Controls.Add(this.lbAPartirDe);
            this.pnPrincipal.Controls.Add(this.lbFala);
            this.pnPrincipal.Controls.Add(this.cbFalas);
            this.pnPrincipal.Controls.Add(this.lbLegendaStatus);
            this.pnPrincipal.Controls.Add(this.btnProcurarFala);
            this.pnPrincipal.Controls.Add(this.btnSincronizar);
            this.pnPrincipal.Controls.Add(this.rbAtrasada);
            this.pnPrincipal.Controls.Add(this.txbDelay);
            this.pnPrincipal.Controls.Add(this.lbDelay);
            this.pnPrincipal.Controls.Add(this.txbFala);
            this.pnPrincipal.Controls.Add(this.lbInicio);
            this.pnPrincipal.Controls.Add(this.rbAdiantada);
            this.pnPrincipal.Location = new System.Drawing.Point(15, 41);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(440, 190);
            this.pnPrincipal.TabIndex = 12;
            // 
            // lbAPartirDe
            // 
            this.lbAPartirDe.AutoSize = true;
            this.lbAPartirDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAPartirDe.Location = new System.Drawing.Point(182, 108);
            this.lbAPartirDe.Name = "lbAPartirDe";
            this.lbAPartirDe.Size = new System.Drawing.Size(95, 13);
            this.lbAPartirDe.TabIndex = 19;
            this.lbAPartirDe.Text = "A partir da fala:";
            this.lbAPartirDe.Visible = false;
            // 
            // lbFala
            // 
            this.lbFala.AutoSize = true;
            this.lbFala.Location = new System.Drawing.Point(292, 108);
            this.lbFala.Name = "lbFala";
            this.lbFala.Size = new System.Drawing.Size(0, 13);
            this.lbFala.TabIndex = 18;
            this.lbFala.Visible = false;
            // 
            // cbFalas
            // 
            this.cbFalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFalas.FormattingEnabled = true;
            this.cbFalas.Items.AddRange(new object[] {
            "Todas as falas",
            "A partir de uma fala específica"});
            this.cbFalas.Location = new System.Drawing.Point(217, 32);
            this.cbFalas.Name = "cbFalas";
            this.cbFalas.Size = new System.Drawing.Size(166, 21);
            this.cbFalas.TabIndex = 13;
            this.cbFalas.Visible = false;
            this.cbFalas.SelectedIndexChanged += new System.EventHandler(this.cbFalas_SelectedIndexChanged);
            // 
            // lbLegendaStatus
            // 
            this.lbLegendaStatus.AutoSize = true;
            this.lbLegendaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLegendaStatus.Location = new System.Drawing.Point(3, 32);
            this.lbLegendaStatus.Name = "lbLegendaStatus";
            this.lbLegendaStatus.Size = new System.Drawing.Size(88, 13);
            this.lbLegendaStatus.TabIndex = 17;
            this.lbLegendaStatus.Text = "Legenda está:";
            // 
            // btnProcurarFala
            // 
            this.btnProcurarFala.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcurarFala.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarFala.Image")));
            this.btnProcurarFala.Location = new System.Drawing.Point(329, 65);
            this.btnProcurarFala.Name = "btnProcurarFala";
            this.btnProcurarFala.Size = new System.Drawing.Size(29, 23);
            this.btnProcurarFala.TabIndex = 16;
            this.btnProcurarFala.UseVisualStyleBackColor = true;
            this.btnProcurarFala.Visible = false;
            this.btnProcurarFala.Click += new System.EventHandler(this.btnProcurarFala_Click);
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Location = new System.Drawing.Point(202, 155);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(75, 23);
            this.btnSincronizar.TabIndex = 15;
            this.btnSincronizar.Text = "&Sincronizar";
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // lbLegenda
            // 
            this.lbLegenda.AutoSize = true;
            this.lbLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLegenda.Location = new System.Drawing.Point(15, 14);
            this.lbLegenda.Name = "lbLegenda";
            this.lbLegenda.Size = new System.Drawing.Size(60, 13);
            this.lbLegenda.TabIndex = 13;
            this.lbLegenda.Text = "Legenda:";
            // 
            // lbFalas
            // 
            this.lbFalas.AutoSize = true;
            this.lbFalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFalas.Location = new System.Drawing.Point(170, 35);
            this.lbFalas.Name = "lbFalas";
            this.lbFalas.Size = new System.Drawing.Size(41, 13);
            this.lbFalas.TabIndex = 20;
            this.lbFalas.Text = "Falas:";
            this.lbFalas.Visible = false;
            // 
            // frmLegenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 243);
            this.Controls.Add(this.lbLegenda);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txbArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLegenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legenda";
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbArquivo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lbDelay;
        private System.Windows.Forms.RadioButton rbAtrasada;
        private System.Windows.Forms.RadioButton rbAdiantada;
        private System.Windows.Forms.MaskedTextBox txbDelay;
        private System.Windows.Forms.TextBox txbFala;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Button btnProcurarFala;
        private System.Windows.Forms.Label lbLegendaStatus;
        private System.Windows.Forms.ComboBox cbFalas;
        private System.Windows.Forms.Label lbFala;
        private System.Windows.Forms.Label lbAPartirDe;
        private System.Windows.Forms.Label lbLegenda;
        private System.Windows.Forms.Label lbFalas;
    }
}

