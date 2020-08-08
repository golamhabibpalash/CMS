namespace ClinicManagementSystemApp
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.backButtonPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.left_Panel = new System.Windows.Forms.Panel();
            this.right_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.backButtonPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.userNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.leftPanel.Controls.Add(this.left_Panel);
            this.leftPanel.Controls.Add(this.backButtonPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(240, 519);
            this.leftPanel.TabIndex = 0;
            // 
            // backButtonPanel
            // 
            this.backButtonPanel.Controls.Add(this.backBtn);
            this.backButtonPanel.Controls.Add(this.label1);
            this.backButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.backButtonPanel.Name = "backButtonPanel";
            this.backButtonPanel.Size = new System.Drawing.Size(240, 40);
            this.backButtonPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.right_Panel);
            this.rightPanel.Controls.Add(this.userNamePanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.rightPanel.Location = new System.Drawing.Point(240, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(693, 519);
            this.rightPanel.TabIndex = 2;
            // 
            // userNamePanel
            // 
            this.userNamePanel.Controls.Add(this.label2);
            this.userNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNamePanel.Location = new System.Drawing.Point(0, 0);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(693, 40);
            this.userNamePanel.TabIndex = 1;
            // 
            // left_Panel
            // 
            this.left_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_Panel.Location = new System.Drawing.Point(0, 40);
            this.left_Panel.Name = "left_Panel";
            this.left_Panel.Size = new System.Drawing.Size(240, 479);
            this.left_Panel.TabIndex = 2;
            // 
            // right_Panel
            // 
            this.right_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_Panel.Location = new System.Drawing.Point(0, 40);
            this.right_Panel.Name = "right_Panel";
            this.right_Panel.Size = new System.Drawing.Size(693, 479);
            this.right_Panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::ClinicManagementSystemApp.Properties.Resources.back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 33);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample";
            this.leftPanel.ResumeLayout(false);
            this.backButtonPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.userNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Panel backButtonPanel;
        protected System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Panel left_Panel;
        protected System.Windows.Forms.Panel right_Panel;
        protected System.Windows.Forms.Panel userNamePanel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button backBtn;
        protected System.Windows.Forms.Label label2;
    }
}

