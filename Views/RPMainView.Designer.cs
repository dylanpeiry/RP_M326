namespace JustePrix
{
    partial class RPMainView
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
            this.btnAddItems = new System.Windows.Forms.Button();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.lblInfoScores = new System.Windows.Forms.Label();
            this.pnlScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(12, 82);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(132, 23);
            this.btnAddItems.TabIndex = 0;
            this.btnAddItems.Text = "Ajouter des articles";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayerName.Location = new System.Drawing.Point(12, 27);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(132, 21);
            this.tbxPlayerName.TabIndex = 1;
            this.tbxPlayerName.TextChanged += new System.EventHandler(this.tbxPlayerName_TextChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(9, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(103, 15);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Nom du joueur";
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(12, 53);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(132, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlScores
            // 
            this.pnlScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScores.Controls.Add(this.lblInfoScores);
            this.pnlScores.Location = new System.Drawing.Point(160, -2);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(168, 315);
            this.pnlScores.TabIndex = 4;
            // 
            // lblInfoScores
            // 
            this.lblInfoScores.AutoSize = true;
            this.lblInfoScores.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoScores.Location = new System.Drawing.Point(7, 10);
            this.lblInfoScores.Name = "lblInfoScores";
            this.lblInfoScores.Size = new System.Drawing.Size(49, 15);
            this.lblInfoScores.TabIndex = 5;
            this.lblInfoScores.Text = "Scores";
            // 
            // RPMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 310);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.btnAddItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le Juste prix - Accueil";
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Label lblInfoScores;
    }
}

