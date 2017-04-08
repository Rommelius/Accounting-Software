namespace SummaryReport_Accounting
{
    partial class AddItem
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
            this._addButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._itemName = new MetroFramework.Controls.MetroTextBox();
            this._cancelBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(227, 129);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(112, 42);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Add";
            this._addButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._addButton.UseSelectable = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Item Name:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _itemName
            // 
            // 
            // 
            // 
            this._itemName.CustomButton.Image = null;
            this._itemName.CustomButton.Location = new System.Drawing.Point(153, 1);
            this._itemName.CustomButton.Name = "";
            this._itemName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this._itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._itemName.CustomButton.TabIndex = 1;
            this._itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._itemName.CustomButton.UseSelectable = true;
            this._itemName.CustomButton.Visible = false;
            this._itemName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this._itemName.Lines = new string[0];
            this._itemName.Location = new System.Drawing.Point(152, 77);
            this._itemName.MaxLength = 32767;
            this._itemName.Name = "_itemName";
            this._itemName.PasswordChar = '\0';
            this._itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._itemName.SelectedText = "";
            this._itemName.SelectionLength = 0;
            this._itemName.SelectionStart = 0;
            this._itemName.ShortcutsEnabled = true;
            this._itemName.Size = new System.Drawing.Size(187, 35);
            this._itemName.TabIndex = 3;
            this._itemName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._itemName.UseSelectable = true;
            this._itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Location = new System.Drawing.Point(23, 129);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(112, 42);
            this._cancelBtn.TabIndex = 4;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cancelBtn.UseSelectable = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 209);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._itemName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._addButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.Resizable = false;
            this.Text = "Fill in the details:";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton _addButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox _itemName;
        private MetroFramework.Controls.MetroButton _cancelBtn;
    }
}