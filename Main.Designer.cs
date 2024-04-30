namespace AssetPackCreatorUtilities
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdRenameProject = new Button();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmdRenameProject
            // 
            cmdRenameProject.Location = new Point(12, 71);
            cmdRenameProject.Name = "cmdRenameProject";
            cmdRenameProject.Size = new Size(217, 34);
            cmdRenameProject.TabIndex = 0;
            cmdRenameProject.Text = "Apply Renaming";
            cmdRenameProject.UseVisualStyleBackColor = true;
            cmdRenameProject.Click += cmdRenameProject_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 2;
            label1.Text = "Please enter the name of your mod:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 113);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmdRenameProject);
            Name = "Main";
            Text = "Asset Pack Creator Utilities";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdRenameProject;
        private TextBox txtName;
        private Label label1;
    }
}
