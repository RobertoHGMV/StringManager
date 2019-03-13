namespace StringManager.UI
{
    partial class StringManagerForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringManagerForm));
            this.splitContainerSidebar = new System.Windows.Forms.SplitContainer();
            this.radioNone = new MetroFramework.Controls.MetroRadioButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnConverter = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtEndWith = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStartWith = new MetroFramework.Controls.MetroTextBox();
            this.chkSplitByLine = new MetroFramework.Controls.MetroCheckBox();
            this.radioFirstUpper = new MetroFramework.Controls.MetroRadioButton();
            this.radioLower = new MetroFramework.Controls.MetroRadioButton();
            this.radioUpper = new MetroFramework.Controls.MetroRadioButton();
            this.splitContainerViews = new System.Windows.Forms.SplitContainer();
            this.txtStrSource = new MetroFramework.Controls.MetroTextBox();
            this.txtStrDest = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSidebar)).BeginInit();
            this.splitContainerSidebar.Panel1.SuspendLayout();
            this.splitContainerSidebar.Panel2.SuspendLayout();
            this.splitContainerSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViews)).BeginInit();
            this.splitContainerViews.Panel1.SuspendLayout();
            this.splitContainerViews.Panel2.SuspendLayout();
            this.splitContainerViews.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerSidebar
            // 
            this.splitContainerSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSidebar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerSidebar.Location = new System.Drawing.Point(20, 60);
            this.splitContainerSidebar.Name = "splitContainerSidebar";
            // 
            // splitContainerSidebar.Panel1
            // 
            this.splitContainerSidebar.Panel1.AutoScroll = true;
            this.splitContainerSidebar.Panel1.Controls.Add(this.radioNone);
            this.splitContainerSidebar.Panel1.Controls.Add(this.btnClear);
            this.splitContainerSidebar.Panel1.Controls.Add(this.btnConverter);
            this.splitContainerSidebar.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainerSidebar.Panel1.Controls.Add(this.txtEndWith);
            this.splitContainerSidebar.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainerSidebar.Panel1.Controls.Add(this.txtStartWith);
            this.splitContainerSidebar.Panel1.Controls.Add(this.chkSplitByLine);
            this.splitContainerSidebar.Panel1.Controls.Add(this.radioFirstUpper);
            this.splitContainerSidebar.Panel1.Controls.Add(this.radioLower);
            this.splitContainerSidebar.Panel1.Controls.Add(this.radioUpper);
            // 
            // splitContainerSidebar.Panel2
            // 
            this.splitContainerSidebar.Panel2.Controls.Add(this.splitContainerViews);
            this.splitContainerSidebar.Size = new System.Drawing.Size(1018, 493);
            this.splitContainerSidebar.SplitterDistance = 191;
            this.splitContainerSidebar.TabIndex = 0;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioNone.Location = new System.Drawing.Point(14, 10);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(78, 19);
            this.radioNone.TabIndex = 18;
            this.radioNone.Text = "Nenhum";
            this.radioNone.UseSelectable = true;
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(14, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnClear.UseSelectable = true;
            // 
            // btnConverter
            // 
            this.btnConverter.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConverter.Location = new System.Drawing.Point(14, 230);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(159, 30);
            this.btnConverter.TabIndex = 7;
            this.btnConverter.Text = "Converter";
            this.btnConverter.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConverter.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Termina com";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEndWith
            // 
            // 
            // 
            // 
            this.txtEndWith.CustomButton.Image = null;
            this.txtEndWith.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtEndWith.CustomButton.Name = "";
            this.txtEndWith.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEndWith.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndWith.CustomButton.TabIndex = 1;
            this.txtEndWith.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndWith.CustomButton.UseSelectable = true;
            this.txtEndWith.CustomButton.Visible = false;
            this.txtEndWith.Lines = new string[0];
            this.txtEndWith.Location = new System.Drawing.Point(14, 192);
            this.txtEndWith.MaxLength = 32767;
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.PasswordChar = '\0';
            this.txtEndWith.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndWith.SelectedText = "";
            this.txtEndWith.SelectionLength = 0;
            this.txtEndWith.SelectionStart = 0;
            this.txtEndWith.ShortcutsEnabled = true;
            this.txtEndWith.Size = new System.Drawing.Size(159, 23);
            this.txtEndWith.TabIndex = 6;
            this.txtEndWith.UseSelectable = true;
            this.txtEndWith.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndWith.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Começa com";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartWith
            // 
            // 
            // 
            // 
            this.txtStartWith.CustomButton.Image = null;
            this.txtStartWith.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtStartWith.CustomButton.Name = "";
            this.txtStartWith.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStartWith.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStartWith.CustomButton.TabIndex = 1;
            this.txtStartWith.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStartWith.CustomButton.UseSelectable = true;
            this.txtStartWith.CustomButton.Visible = false;
            this.txtStartWith.Lines = new string[0];
            this.txtStartWith.Location = new System.Drawing.Point(14, 142);
            this.txtStartWith.MaxLength = 32767;
            this.txtStartWith.Name = "txtStartWith";
            this.txtStartWith.PasswordChar = '\0';
            this.txtStartWith.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStartWith.SelectedText = "";
            this.txtStartWith.SelectionLength = 0;
            this.txtStartWith.SelectionStart = 0;
            this.txtStartWith.ShortcutsEnabled = true;
            this.txtStartWith.Size = new System.Drawing.Size(159, 23);
            this.txtStartWith.TabIndex = 5;
            this.txtStartWith.UseSelectable = true;
            this.txtStartWith.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStartWith.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkSplitByLine
            // 
            this.chkSplitByLine.AutoSize = true;
            this.chkSplitByLine.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSplitByLine.Location = new System.Drawing.Point(14, 97);
            this.chkSplitByLine.Name = "chkSplitByLine";
            this.chkSplitByLine.Size = new System.Drawing.Size(129, 19);
            this.chkSplitByLine.TabIndex = 4;
            this.chkSplitByLine.Text = "Separar por linha";
            this.chkSplitByLine.UseSelectable = true;
            // 
            // radioFirstUpper
            // 
            this.radioFirstUpper.AutoSize = true;
            this.radioFirstUpper.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioFirstUpper.Location = new System.Drawing.Point(14, 75);
            this.radioFirstUpper.Name = "radioFirstUpper";
            this.radioFirstUpper.Size = new System.Drawing.Size(133, 19);
            this.radioFirstUpper.TabIndex = 3;
            this.radioFirstUpper.Text = "1ª letra maiúscula";
            this.radioFirstUpper.UseSelectable = true;
            // 
            // radioLower
            // 
            this.radioLower.AutoSize = true;
            this.radioLower.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioLower.Location = new System.Drawing.Point(14, 53);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(88, 19);
            this.radioLower.TabIndex = 2;
            this.radioLower.Text = "Minúsculo";
            this.radioLower.UseSelectable = true;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioUpper.Location = new System.Drawing.Point(14, 31);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(87, 19);
            this.radioUpper.TabIndex = 1;
            this.radioUpper.Text = "Maiúsculo";
            this.radioUpper.UseSelectable = true;
            // 
            // splitContainerViews
            // 
            this.splitContainerViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerViews.Location = new System.Drawing.Point(0, 0);
            this.splitContainerViews.Name = "splitContainerViews";
            this.splitContainerViews.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerViews.Panel1
            // 
            this.splitContainerViews.Panel1.Controls.Add(this.txtStrSource);
            // 
            // splitContainerViews.Panel2
            // 
            this.splitContainerViews.Panel2.Controls.Add(this.txtStrDest);
            this.splitContainerViews.Size = new System.Drawing.Size(821, 491);
            this.splitContainerViews.SplitterDistance = 221;
            this.splitContainerViews.TabIndex = 0;
            // 
            // txtStrSource
            // 
            // 
            // 
            // 
            this.txtStrSource.CustomButton.Image = null;
            this.txtStrSource.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtStrSource.CustomButton.Name = "";
            this.txtStrSource.CustomButton.Size = new System.Drawing.Size(219, 219);
            this.txtStrSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStrSource.CustomButton.TabIndex = 1;
            this.txtStrSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStrSource.CustomButton.UseSelectable = true;
            this.txtStrSource.CustomButton.Visible = false;
            this.txtStrSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStrSource.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtStrSource.Lines = new string[0];
            this.txtStrSource.Location = new System.Drawing.Point(0, 0);
            this.txtStrSource.MaxLength = 32767;
            this.txtStrSource.Multiline = true;
            this.txtStrSource.Name = "txtStrSource";
            this.txtStrSource.PasswordChar = '\0';
            this.txtStrSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStrSource.SelectedText = "";
            this.txtStrSource.SelectionLength = 0;
            this.txtStrSource.SelectionStart = 0;
            this.txtStrSource.ShortcutsEnabled = true;
            this.txtStrSource.Size = new System.Drawing.Size(821, 221);
            this.txtStrSource.TabIndex = 9;
            this.txtStrSource.UseSelectable = true;
            this.txtStrSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStrSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStrDest
            // 
            // 
            // 
            // 
            this.txtStrDest.CustomButton.Image = null;
            this.txtStrDest.CustomButton.Location = new System.Drawing.Point(557, 2);
            this.txtStrDest.CustomButton.Name = "";
            this.txtStrDest.CustomButton.Size = new System.Drawing.Size(261, 261);
            this.txtStrDest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStrDest.CustomButton.TabIndex = 1;
            this.txtStrDest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStrDest.CustomButton.UseSelectable = true;
            this.txtStrDest.CustomButton.Visible = false;
            this.txtStrDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStrDest.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtStrDest.Lines = new string[0];
            this.txtStrDest.Location = new System.Drawing.Point(0, 0);
            this.txtStrDest.MaxLength = 32767;
            this.txtStrDest.Multiline = true;
            this.txtStrDest.Name = "txtStrDest";
            this.txtStrDest.PasswordChar = '\0';
            this.txtStrDest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStrDest.SelectedText = "";
            this.txtStrDest.SelectionLength = 0;
            this.txtStrDest.SelectionStart = 0;
            this.txtStrDest.ShortcutsEnabled = true;
            this.txtStrDest.Size = new System.Drawing.Size(821, 266);
            this.txtStrDest.TabIndex = 10;
            this.txtStrDest.UseSelectable = true;
            this.txtStrDest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStrDest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StringManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 573);
            this.Controls.Add(this.splitContainerSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StringManagerForm";
            this.Text = "Adm. de Strings";
            this.splitContainerSidebar.Panel1.ResumeLayout(false);
            this.splitContainerSidebar.Panel1.PerformLayout();
            this.splitContainerSidebar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSidebar)).EndInit();
            this.splitContainerSidebar.ResumeLayout(false);
            this.splitContainerViews.Panel1.ResumeLayout(false);
            this.splitContainerViews.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerViews)).EndInit();
            this.splitContainerViews.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerSidebar;
        private MetroFramework.Controls.MetroButton btnConverter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtEndWith;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStartWith;
        private MetroFramework.Controls.MetroCheckBox chkSplitByLine;
        private MetroFramework.Controls.MetroRadioButton radioFirstUpper;
        private MetroFramework.Controls.MetroRadioButton radioLower;
        private MetroFramework.Controls.MetroRadioButton radioUpper;
        private System.Windows.Forms.SplitContainer splitContainerViews;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroRadioButton radioNone;
        private MetroFramework.Controls.MetroTextBox txtStrSource;
        private MetroFramework.Controls.MetroTextBox txtStrDest;
    }
}

