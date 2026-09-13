namespace DnG_AdK_Mapedit
{
    partial class Map_renaming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map_renaming));
            Map_name_edit = new System.Windows.Forms.TextBox();
            Accept_button = new System.Windows.Forms.Button();
            Cancel_button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Map_name_edit
            // 
            Map_name_edit.Location = new System.Drawing.Point(12, 12);
            Map_name_edit.Name = "Map_name_edit";
            Map_name_edit.Size = new System.Drawing.Size(332, 23);
            Map_name_edit.TabIndex = 0;
            // 
            // Accept_button
            // 
            Accept_button.AutoSize = true;
            Accept_button.Location = new System.Drawing.Point(12, 41);
            Accept_button.Name = "Accept_button";
            Accept_button.Size = new System.Drawing.Size(160, 40);
            Accept_button.TabIndex = 1;
            Accept_button.Text = "Accept";
            Accept_button.UseVisualStyleBackColor = true;
            Accept_button.Click += Accept_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.AutoSize = true;
            Cancel_button.Location = new System.Drawing.Point(184, 41);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new System.Drawing.Size(160, 40);
            Cancel_button.TabIndex = 2;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // Map_renaming
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(356, 87);
            Controls.Add(Cancel_button);
            Controls.Add(Accept_button);
            Controls.Add(Map_name_edit);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Map_renaming";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Rename map";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Map_name_edit;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}