namespace Asrfly0.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutPut = new Button();
            buttonAddUser = new Button();
            buttonAddProject = new Button();
            buttonAddSupplier = new Button();
            buttonAddCustomer = new Button();
            buttonAddCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            labelCompanyName = new Label();
            pictureBoxLogo = new PictureBox();
            labelWellcome = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 242);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icons8_smart_96px_2;
            pictureBox1.Location = new Point(609, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutPut);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new Point(205, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1230, 99);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "أضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.Image = Properties.Resources.icons8_receive_cash_32px;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(8, 32);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(165, 55);
            buttonAddInput.TabIndex = 9;
            buttonAddInput.Text = "    قبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutPut
            // 
            buttonAddOutPut.Image = Properties.Resources.icons8_Recieve_32px;
            buttonAddOutPut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutPut.Location = new Point(183, 32);
            buttonAddOutPut.Margin = new Padding(5);
            buttonAddOutPut.Name = "buttonAddOutPut";
            buttonAddOutPut.Size = new Size(165, 55);
            buttonAddOutPut.TabIndex = 8;
            buttonAddOutPut.Text = "    صرف";
            buttonAddOutPut.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Image = Properties.Resources.icons8_staff_32px;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(358, 32);
            buttonAddUser.Margin = new Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(165, 55);
            buttonAddUser.TabIndex = 7;
            buttonAddUser.Text = "    مستخدم";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Image = Properties.Resources.icons8_flipboard_32px;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(533, 32);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(165, 55);
            buttonAddProject.TabIndex = 6;
            buttonAddProject.Text = "    مشروع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.Image = Properties.Resources.icons8_manager_32px;
            buttonAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new Point(708, 32);
            buttonAddSupplier.Margin = new Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new Size(165, 55);
            buttonAddSupplier.TabIndex = 5;
            buttonAddSupplier.Text = "    مورد";
            buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Image = Properties.Resources.icons8_customer_32px;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(883, 32);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(165, 55);
            buttonAddCustomer.TabIndex = 4;
            buttonAddCustomer.Text = "    عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Image = Properties.Resources.icons8_Scorecard_32px;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(1058, 32);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(165, 55);
            buttonAddCategory.TabIndex = 3;
            buttonAddCategory.Text = "    صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(668, 33);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new Point(521, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 100);
            panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(3, 23);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(348, 37);
            labelCompanyName.TabIndex = 7;
            labelCompanyName.Text = "أفق المستقبل للحلول البرمجية";
            labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxLogo.Image = Properties.Resources.icons8_smart_96px_2;
            pictureBoxLogo.Location = new Point(351, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(78, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // labelWellcome
            // 
            labelWellcome.AutoSize = true;
            labelWellcome.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWellcome.Location = new Point(53, 102);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(234, 46);
            labelWellcome.TabIndex = 8;
            labelWellcome.Text = "مرحبا بك مجددا";
            labelWellcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelWellcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1604, 616);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddCustomer;
        private Button buttonAddSupplier;
        private Button buttonAddProject;
        private Button buttonAddUser;
        private Button buttonAddInput;
        private Button buttonAddOutPut;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Label labelCompanyName;
        private Label labelWellcome;
    }
}
