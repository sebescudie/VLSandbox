namespace VSForms
{
    partial class VSForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggle = new System.Windows.Forms.CheckBox();
            this.bangButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numeric);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.bangButton);
            this.panel1.Controls.Add(this.toggle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dropdown);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 195);
            this.panel1.TabIndex = 0;
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.Location = new System.Drawing.Point(6, 109);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(59, 17);
            this.toggle.TabIndex = 0;
            this.toggle.Text = "Toggle";
            this.toggle.UseVisualStyleBackColor = true;
            // 
            // bangButton
            // 
            this.bangButton.Location = new System.Drawing.Point(6, 160);
            this.bangButton.Name = "bangButton";
            this.bangButton.Size = new System.Drawing.Size(153, 28);
            this.bangButton.TabIndex = 3;
            this.bangButton.Text = "Color Dialog";
            this.bangButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slider";
            // 
            // slider
            // 
            this.slider.LargeChange = 1;
            this.slider.Location = new System.Drawing.Point(47, 65);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(117, 45);
            this.slider.TabIndex = 1;
            this.slider.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dropdown";
            // 
            // dropdown
            // 
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(65, 36);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(94, 21);
            this.dropdown.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(122, 20);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 134);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(153, 20);
            this.datePicker.TabIndex = 5;
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(78, 108);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(81, 20);
            this.numeric.TabIndex = 7;
            // 
            // VSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 217);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VSForm";
            this.Text = "VSForm";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox toggle;
        private System.Windows.Forms.Button bangButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

