namespace TPOpenHouseAdminConsole
{
    partial class AddRewards
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudPointsRequired = new System.Windows.Forms.NumericUpDown();
            this.nudTotalAvailable = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(713, 415);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points Required: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Rewards: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(386, 20);
            this.txtName.TabIndex = 5;
            // 
            // nudPointsRequired
            // 
            this.nudPointsRequired.Location = new System.Drawing.Point(118, 121);
            this.nudPointsRequired.Name = "nudPointsRequired";
            this.nudPointsRequired.Size = new System.Drawing.Size(101, 20);
            this.nudPointsRequired.TabIndex = 6;
            // 
            // nudTotalAvailable
            // 
            this.nudTotalAvailable.Location = new System.Drawing.Point(118, 182);
            this.nudTotalAvailable.Name = "nudTotalAvailable";
            this.nudTotalAvailable.Size = new System.Drawing.Size(101, 20);
            this.nudTotalAvailable.TabIndex = 7;
            // 
            // AddRewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudTotalAvailable);
            this.Controls.Add(this.nudPointsRequired);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBack);
            this.Name = "AddRewards";
            this.Text = "Add Rewards";
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudPointsRequired;
        private System.Windows.Forms.NumericUpDown nudTotalAvailable;
    }
}