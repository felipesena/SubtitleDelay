namespace Legenda
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.listViewLegendas = new System.Windows.Forms.ListView();
            this.columnTempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLegendas
            // 
            this.listViewLegendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTempo,
            this.columnFala});
            this.listViewLegendas.Location = new System.Drawing.Point(12, 12);
            this.listViewLegendas.MultiSelect = false;
            this.listViewLegendas.Name = "listViewLegendas";
            this.listViewLegendas.Size = new System.Drawing.Size(349, 203);
            this.listViewLegendas.TabIndex = 0;
            this.listViewLegendas.UseCompatibleStateImageBehavior = false;
            this.listViewLegendas.View = System.Windows.Forms.View.Details;
            this.listViewLegendas.DoubleClick += new System.EventHandler(this.btnOK_Click);
            // 
            // columnTempo
            // 
            this.columnTempo.Text = "Tempo";
            this.columnTempo.Width = 80;
            // 
            // columnFala
            // 
            this.columnFala.Text = "Fala";
            this.columnFala.Width = 232;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(131, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 250);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listViewLegendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewLegendas;
        private System.Windows.Forms.ColumnHeader columnTempo;
        private System.Windows.Forms.ColumnHeader columnFala;
        private System.Windows.Forms.Button btnOK;
    }
}