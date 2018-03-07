namespace JustePrix
{
    partial class RPGameView
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
            this.tbxPriceEstimated = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblItemToEvaluate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPriceEstimated
            // 
            this.tbxPriceEstimated.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriceEstimated.Location = new System.Drawing.Point(66, 98);
            this.tbxPriceEstimated.Name = "tbxPriceEstimated";
            this.tbxPriceEstimated.Size = new System.Drawing.Size(150, 23);
            this.tbxPriceEstimated.TabIndex = 0;
            this.tbxPriceEstimated.TextChanged += new System.EventHandler(this.tbxPriceEstimated_TextChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(66, 124);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 28);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Proposer";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblItemToEvaluate
            // 
            this.lblItemToEvaluate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemToEvaluate.Location = new System.Drawing.Point(12, 9);
            this.lblItemToEvaluate.Name = "lblItemToEvaluate";
            this.lblItemToEvaluate.Size = new System.Drawing.Size(260, 86);
            this.lblItemToEvaluate.TabIndex = 2;
            this.lblItemToEvaluate.Text = "Article à evaluer";
            this.lblItemToEvaluate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(66, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 22);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Info prix";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.Location = new System.Drawing.Point(12, 218);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(52, 18);
            this.lblAttempts.TabIndex = 4;
            this.lblAttempts.Text = "essais";
            this.lblAttempts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RPGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblItemToEvaluate);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbxPriceEstimated);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPGameView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Le Juste prix - Jeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPriceEstimated;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblItemToEvaluate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAttempts;
    }
}