namespace WindowsFormsApp2
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
            this.UsernameUID = new System.Windows.Forms.TextBox();
            this.radioButtonUsername = new System.Windows.Forms.RadioButton();
            this.radioButtonUID = new System.Windows.Forms.RadioButton();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonShowBalance = new System.Windows.Forms.Button();
            this.buttonAddCash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameUID
            // 
            this.UsernameUID.Location = new System.Drawing.Point(233, 70);
            this.UsernameUID.Name = "UsernameUID";
            this.UsernameUID.Size = new System.Drawing.Size(100, 22);
            this.UsernameUID.TabIndex = 0;
            this.UsernameUID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonUsername
            // 
            this.radioButtonUsername.AutoSize = true;
            this.radioButtonUsername.Location = new System.Drawing.Point(123, 47);
            this.radioButtonUsername.Name = "radioButtonUsername";
            this.radioButtonUsername.Size = new System.Drawing.Size(89, 20);
            this.radioButtonUsername.TabIndex = 1;
            this.radioButtonUsername.TabStop = true;
            this.radioButtonUsername.Text = "Username";
            this.radioButtonUsername.UseVisualStyleBackColor = true;
            // 
            // radioButtonUID
            // 
            this.radioButtonUID.AutoSize = true;
            this.radioButtonUID.Location = new System.Drawing.Point(123, 87);
            this.radioButtonUID.Name = "radioButtonUID";
            this.radioButtonUID.Size = new System.Drawing.Size(49, 20);
            this.radioButtonUID.TabIndex = 2;
            this.radioButtonUID.TabStop = true;
            this.radioButtonUID.Text = "UID";
            this.radioButtonUID.UseVisualStyleBackColor = true;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(178, 188);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 3;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(108, 191);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(53, 16);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount";
            this.labelAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(175, 282);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 16);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(44, 315);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(307, 22);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonShowBalance
            // 
            this.buttonShowBalance.Location = new System.Drawing.Point(168, 134);
            this.buttonShowBalance.Name = "buttonShowBalance";
            this.buttonShowBalance.Size = new System.Drawing.Size(121, 23);
            this.buttonShowBalance.TabIndex = 7;
            this.buttonShowBalance.Text = "Show balance";
            this.buttonShowBalance.UseVisualStyleBackColor = true;
            // 
            // buttonAddCash
            // 
            this.buttonAddCash.Location = new System.Drawing.Point(153, 232);
            this.buttonAddCash.Name = "buttonAddCash";
            this.buttonAddCash.Size = new System.Drawing.Size(121, 23);
            this.buttonAddCash.TabIndex = 8;
            this.buttonAddCash.Text = "Add cash";
            this.buttonAddCash.UseVisualStyleBackColor = true;
            this.buttonAddCash.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 409);
            this.Controls.Add(this.buttonAddCash);
            this.Controls.Add(this.buttonShowBalance);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.radioButtonUID);
            this.Controls.Add(this.radioButtonUsername);
            this.Controls.Add(this.UsernameUID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameUID;
        private System.Windows.Forms.RadioButton radioButtonUsername;
        private System.Windows.Forms.RadioButton radioButtonUID;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonShowBalance;
        private System.Windows.Forms.Button buttonAddCash;
    }
}

