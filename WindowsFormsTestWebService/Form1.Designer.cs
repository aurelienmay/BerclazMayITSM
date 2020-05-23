namespace WindowsFormsTestWebservice
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
            this.radioButtonUID = new System.Windows.Forms.RadioButton();
            this.radioButtonUsername = new System.Windows.Forms.RadioButton();
            this.textBoxUIDUsername = new System.Windows.Forms.TextBox();
            this.buttonShowBalance = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAmount = new System.Windows.Forms.Button();
            this.labelQuotas = new System.Windows.Forms.Label();
            this.textBoxQuotas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonUID
            // 
            this.radioButtonUID.AutoSize = true;
            this.radioButtonUID.Location = new System.Drawing.Point(74, 54);
            this.radioButtonUID.Name = "radioButtonUID";
            this.radioButtonUID.Size = new System.Drawing.Size(52, 21);
            this.radioButtonUID.TabIndex = 0;
            this.radioButtonUID.TabStop = true;
            this.radioButtonUID.Text = "UID";
            this.radioButtonUID.UseVisualStyleBackColor = true;
            this.radioButtonUID.CheckedChanged += new System.EventHandler(this.radioButtonUID_CheckedChanged);
            // 
            // radioButtonUsername
            // 
            this.radioButtonUsername.AutoSize = true;
            this.radioButtonUsername.Location = new System.Drawing.Point(74, 92);
            this.radioButtonUsername.Name = "radioButtonUsername";
            this.radioButtonUsername.Size = new System.Drawing.Size(94, 21);
            this.radioButtonUsername.TabIndex = 1;
            this.radioButtonUsername.TabStop = true;
            this.radioButtonUsername.Text = "Username";
            this.radioButtonUsername.UseVisualStyleBackColor = true;
            this.radioButtonUsername.CheckedChanged += new System.EventHandler(this.radioButtonUsername_CheckedChanged);
            // 
            // textBoxUIDUsername
            // 
            this.textBoxUIDUsername.Location = new System.Drawing.Point(205, 74);
            this.textBoxUIDUsername.Name = "textBoxUIDUsername";
            this.textBoxUIDUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUIDUsername.TabIndex = 2;
            this.textBoxUIDUsername.TextChanged += new System.EventHandler(this.textBoxUIDUsername_TextChanged);
            // 
            // buttonShowBalance
            // 
            this.buttonShowBalance.Location = new System.Drawing.Point(128, 145);
            this.buttonShowBalance.Name = "buttonShowBalance";
            this.buttonShowBalance.Size = new System.Drawing.Size(118, 23);
            this.buttonShowBalance.TabIndex = 3;
            this.buttonShowBalance.Text = "Show balance";
            this.buttonShowBalance.UseVisualStyleBackColor = true;
            this.buttonShowBalance.Click += new System.EventHandler(this.buttonShowBalance_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(174, 215);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(94, 218);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(56, 17);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(158, 341);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 17);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 369);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(349, 22);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonAmount
            // 
            this.buttonAmount.Location = new System.Drawing.Point(147, 281);
            this.buttonAmount.Name = "buttonAmount";
            this.buttonAmount.Size = new System.Drawing.Size(75, 23);
            this.buttonAmount.TabIndex = 8;
            this.buttonAmount.Text = "Add cash";
            this.buttonAmount.UseVisualStyleBackColor = true;
            this.buttonAmount.Click += new System.EventHandler(this.buttonAmount_Click);
            // 
            // labelQuotas
            // 
            this.labelQuotas.AutoSize = true;
            this.labelQuotas.Location = new System.Drawing.Point(94, 419);
            this.labelQuotas.Name = "labelQuotas";
            this.labelQuotas.Size = new System.Drawing.Size(196, 17);
            this.labelQuotas.TabIndex = 9;
            this.labelQuotas.Text = "Quotas (number of A4 pages)";
            // 
            // textBoxQuotas
            // 
            this.textBoxQuotas.Location = new System.Drawing.Point(147, 448);
            this.textBoxQuotas.Name = "textBoxQuotas";
            this.textBoxQuotas.Size = new System.Drawing.Size(75, 22);
            this.textBoxQuotas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 497);
            this.Controls.Add(this.textBoxQuotas);
            this.Controls.Add(this.labelQuotas);
            this.Controls.Add(this.buttonAmount);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonShowBalance);
            this.Controls.Add(this.textBoxUIDUsername);
            this.Controls.Add(this.radioButtonUsername);
            this.Controls.Add(this.radioButtonUID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonUID;
        private System.Windows.Forms.RadioButton radioButtonUsername;
        private System.Windows.Forms.TextBox textBoxUIDUsername;
        private System.Windows.Forms.Button buttonShowBalance;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonAmount;
        private System.Windows.Forms.Label labelQuotas;
        private System.Windows.Forms.TextBox textBoxQuotas;
    }
}

