namespace GravitySimulator
{
    partial class ControlPanel
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
            components = new System.ComponentModel.Container();
            removeForm = new Button();
            simulateGravity = new CheckBox();
            addForm = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            centerMouse = new CheckBox();
            SuspendLayout();
            // 
            // removeForm
            // 
            removeForm.Location = new Point(12, 41);
            removeForm.Name = "removeForm";
            removeForm.Size = new Size(145, 23);
            removeForm.TabIndex = 0;
            removeForm.Text = "Remove Form";
            removeForm.UseVisualStyleBackColor = true;
            removeForm.Click += removeForm_Click;
            // 
            // simulateGravity
            // 
            simulateGravity.AutoSize = true;
            simulateGravity.Location = new Point(163, 15);
            simulateGravity.Name = "simulateGravity";
            simulateGravity.Size = new Size(72, 19);
            simulateGravity.TabIndex = 1;
            simulateGravity.Text = "Simulate";
            simulateGravity.UseVisualStyleBackColor = true;
            simulateGravity.CheckedChanged += simulateGravity_CheckedChanged;
            // 
            // addForm
            // 
            addForm.Location = new Point(12, 12);
            addForm.Name = "addForm";
            addForm.Size = new Size(145, 23);
            addForm.TabIndex = 2;
            addForm.Text = "Add Form";
            addForm.UseVisualStyleBackColor = true;
            addForm.Click += addForm_Click;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // centerMouse
            // 
            centerMouse.AutoSize = true;
            centerMouse.Location = new Point(163, 46);
            centerMouse.Name = "centerMouse";
            centerMouse.Size = new Size(100, 19);
            centerMouse.TabIndex = 3;
            centerMouse.Text = "Center Mouse";
            centerMouse.UseVisualStyleBackColor = true;
            centerMouse.CheckedChanged += centerMouse_CheckedChanged;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 77);
            Controls.Add(centerMouse);
            Controls.Add(addForm);
            Controls.Add(simulateGravity);
            Controls.Add(removeForm);
            Name = "ControlPanel";
            Text = "Form1";
            Load += ControlPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeForm;
        private CheckBox simulateGravity;
        private Button addForm;
        private System.Windows.Forms.Timer timer1;
        private CheckBox centerMouse;
    }
}
