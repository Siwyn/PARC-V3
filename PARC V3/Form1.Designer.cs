namespace PARC_V3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableauParc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableauParc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableauParc
            // 
            this.tableauParc.AllowUserToAddRows = false;
            this.tableauParc.AllowUserToDeleteRows = false;
            this.tableauParc.AllowUserToResizeRows = false;
            this.tableauParc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauParc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauParc.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableauParc.Location = new System.Drawing.Point(12, 272);
            this.tableauParc.MultiSelect = false;
            this.tableauParc.Name = "tableauParc";
            this.tableauParc.ReadOnly = true;
            this.tableauParc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableauParc.Size = new System.Drawing.Size(877, 362);
            this.tableauParc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 646);
            this.Controls.Add(this.tableauParc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableauParc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableauParc;
    }
}

