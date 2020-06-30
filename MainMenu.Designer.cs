namespace TPOpenHouseAdminConsole
{
    partial class MainMenu
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
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnAddRewards = new System.Windows.Forms.Button();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(290, 73);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(154, 42);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnAddRewards
            // 
            this.btnAddRewards.Location = new System.Drawing.Point(290, 157);
            this.btnAddRewards.Name = "btnAddRewards";
            this.btnAddRewards.Size = new System.Drawing.Size(154, 42);
            this.btnAddRewards.TabIndex = 1;
            this.btnAddRewards.Text = "Add Rewards";
            this.btnAddRewards.UseVisualStyleBackColor = true;
            this.btnAddRewards.Click += new System.EventHandler(this.btnAddRewards_Click);
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.Location = new System.Drawing.Point(290, 248);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(154, 42);
            this.btnViewEvents.TabIndex = 2;
            this.btnViewEvents.Text = "View Events";
            this.btnViewEvents.UseVisualStyleBackColor = true;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewEvents);
            this.Controls.Add(this.btnAddRewards);
            this.Controls.Add(this.btnAddEvent);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAddRewards;
        private System.Windows.Forms.Button btnViewEvents;
    }
}

