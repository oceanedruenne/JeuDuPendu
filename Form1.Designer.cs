﻿namespace JeuDuPendu
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
            this.lblProposition.Location = new System.Drawing.Point(469, 50);
            this.lblProposition.Name = "lblProposition";
            this.lblProposition.Size = new System.Drawing.Size(156, 22);
            this.lblProposition.TabIndex = 1;
            this.lblProposition.Text = "Votre proposition :";
            // 
            // txtProposition
            // 
            this.txtProposition.Location = new System.Drawing.Point(642, 52);
            this.txtProposition.Name = "txtProposition";
            this.txtProposition.Size = new System.Drawing.Size(100, 20);
            this.txtProposition.TabIndex = 2;
            // 
            // pnlMot
            // 
            this.pnlMot.Location = new System.Drawing.Point(46, 138);
            this.pnlMot.Name = "pnlMot";
            this.pnlMot.Size = new System.Drawing.Size(696, 100);
            this.pnlMot.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMot);
            this.Controls.Add(this.txtProposition);
            this.Controls.Add(this.lblProposition);
            this.Controls.Add(this.lblMotATrouver);
            this.Name = "Form1";
            this.Text = "Jeu du pendu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMotATrouver;
        private System.Windows.Forms.Label lblProposition;
        private System.Windows.Forms.TextBox txtProposition;
        private System.Windows.Forms.Panel pnlMot;
    }
}
