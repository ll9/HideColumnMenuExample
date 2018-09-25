namespace HideColumnExample
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.HideBox = new System.Windows.Forms.ListBox();
            this.ShowBox = new System.Windows.Forms.ListBox();
            this.ToShowButton = new System.Windows.Forms.Button();
            this.ToHideButton = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HideBox
            // 
            this.HideBox.FormattingEnabled = true;
            this.HideBox.Items.AddRange(new object[] {
            "sdjfkkjdl",
            "dsfjkldskfkjldskfjl",
            "sdfkljsdklfkjlsdkfdkldfkldkljs"});
            this.HideBox.Location = new System.Drawing.Point(12, 109);
            this.HideBox.Name = "HideBox";
            this.HideBox.Size = new System.Drawing.Size(226, 147);
            this.HideBox.TabIndex = 3;
            // 
            // ShowBox
            // 
            this.ShowBox.FormattingEnabled = true;
            this.ShowBox.Items.AddRange(new object[] {
            "Item1",
            "Item2"});
            this.ShowBox.Location = new System.Drawing.Point(446, 106);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(232, 160);
            this.ShowBox.TabIndex = 4;
            // 
            // ToShowButton
            // 
            this.ToShowButton.Location = new System.Drawing.Point(287, 117);
            this.ToShowButton.Name = "ToShowButton";
            this.ToShowButton.Size = new System.Drawing.Size(110, 37);
            this.ToShowButton.TabIndex = 5;
            this.ToShowButton.Text = "->";
            this.ToShowButton.UseVisualStyleBackColor = true;
            this.ToShowButton.Click += new System.EventHandler(this.ToShowButton_Click);
            // 
            // ToHideButton
            // 
            this.ToHideButton.Location = new System.Drawing.Point(287, 192);
            this.ToHideButton.Name = "ToHideButton";
            this.ToHideButton.Size = new System.Drawing.Size(111, 40);
            this.ToHideButton.TabIndex = 6;
            this.ToHideButton.Text = "<-";
            this.ToHideButton.UseVisualStyleBackColor = true;
            this.ToHideButton.Click += new System.EventHandler(this.ToHideButton_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(HideColumnExample.Person);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToHideButton);
            this.Controls.Add(this.ToShowButton);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.HideBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ListBox HideBox;
        private System.Windows.Forms.ListBox ShowBox;
        private System.Windows.Forms.Button ToShowButton;
        private System.Windows.Forms.Button ToHideButton;
    }
}