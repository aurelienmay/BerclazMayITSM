namespace WindowsFormsTestWebService
{
    partial class Form1
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
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(127, 48);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(14, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(148, 48);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(127, 74);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 0;
            this.labelB.Text = "B";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(148, 74);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(110, 106);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(191, 106);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "Sub";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(110, 135);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 23);
            this.buttonMult.TabIndex = 2;
            this.buttonMult.Text = "Mult";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(191, 135);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 2;
            this.buttonDiv.Text = "Div";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(148, 175);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 275);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

