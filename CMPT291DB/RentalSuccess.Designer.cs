namespace CMPT291DB
{
    partial class RentalSuccess
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
            label1 = new Label();
            RentalSuccessFinishButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 20);
            label1.TabIndex = 0;
            label1.Text = "Success! Your rental has been confirmed.";
            // 
            // RentalSuccessFinishButton
            // 
            RentalSuccessFinishButton.Location = new Point(101, 32);
            RentalSuccessFinishButton.Name = "RentalSuccessFinishButton";
            RentalSuccessFinishButton.Size = new Size(94, 29);
            RentalSuccessFinishButton.TabIndex = 1;
            RentalSuccessFinishButton.Text = "Finish";
            RentalSuccessFinishButton.UseVisualStyleBackColor = true;
            RentalSuccessFinishButton.Click += RentalSuccessFinishButton_Click;
            // 
            // RentalSuccess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 69);
            Controls.Add(RentalSuccessFinishButton);
            Controls.Add(label1);
            Name = "RentalSuccess";
            Text = "Success";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button RentalSuccessFinishButton;
    }
}