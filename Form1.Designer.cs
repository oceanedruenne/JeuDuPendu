namespace JeuDuPendu
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
            this.lblMotATrouver = new System.Windows.Forms.Label();
            this.lblProposition = new System.Windows.Forms.Label();
            this.txtProposition = new System.Windows.Forms.TextBox();
            this.pnlMot = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMotATrouver
            // 
            this.lblMotATrouver.AutoSize = true;
            this.lblMotATrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblMotATrouver.Location = new System.Drawing.Point(42, 50);
            this.lblMotATrouver.Name = "lblMotATrouver";
            this.lblMotATrouver.Size = new System.Drawing.Size(150, 22);
            this.lblMotATrouver.TabIndex = 0;
            this.lblMotATrouver.Text = "Le mot à trouver..";
            // 
            // lblProposition
            // 
            this.lblProposition.AutoSize = true;
            this.lblProposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblProposition.Location = new System.Drawing.Point(685, 50);
            this.lblProposition.Name = "lblProposition";
            this.lblProposition.Size = new System.Drawing.Size(156, 22);
            this.lblProposition.TabIndex = 1;
            this.lblProposition.Text = "Votre proposition :";
            // 
            // txtProposition
            // 
            this.txtProposition.Location = new System.Drawing.Point(847, 52);
            this.txtProposition.Name = "txtProposition";
            this.txtProposition.Size = new System.Drawing.Size(100, 20);
            this.txtProposition.TabIndex = 2;
            this.txtProposition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProposition_KeyPress);
            // 
            // pnlMot
            // 
            this.pnlMot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMot.Location = new System.Drawing.Point(46, 138);
            this.pnlMot.Name = "pnlMot";
            this.pnlMot.Size = new System.Drawing.Size(901, 100);
            this.pnlMot.TabIndex = 3;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(872, 415);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(763, 415);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(103, 23);
            this.btnRecommencer.TabIndex = 5;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.btnRecommencer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pnlMot);
            this.Controls.Add(this.txtProposition);
            this.Controls.Add(this.lblProposition);
            this.Controls.Add(this.lblMotATrouver);
            this.Name = "Form1";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotATrouver;
        private System.Windows.Forms.Label lblProposition;
        private System.Windows.Forms.TextBox txtProposition;
        private System.Windows.Forms.Panel pnlMot;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRecommencer;
    }
}

