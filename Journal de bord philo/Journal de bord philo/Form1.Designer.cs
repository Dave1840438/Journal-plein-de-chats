namespace Journal_de_bord_philo
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
            this.Label_Texte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Texte
            // 
            this.Label_Texte.Location = new System.Drawing.Point(51, 45);
            this.Label_Texte.Name = "Label_Texte";
            this.Label_Texte.Size = new System.Drawing.Size(431, 214);
            this.Label_Texte.TabIndex = 0;
            this.Label_Texte.Text = "bonjour je voudrais savoir comment toi, label, tu gères le texte";
            this.Label_Texte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 622);
            this.Controls.Add(this.Label_Texte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Texte;
    }
}

