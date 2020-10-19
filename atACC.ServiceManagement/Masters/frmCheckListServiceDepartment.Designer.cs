namespace atACC.ServiceManagement
{
    partial class frmCheckListServiceDepartment
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
            this.pnlSearchBylist = new atACCFramework.UserControls.atPanel();
            this.rbtAll = new atACCFramework.UserControls.atRadioButton();
            this.radDepartment = new atACCFramework.UserControls.atRadioButton();
            this.atLabel3 = new atACCFramework.UserControls.atLabel();
            this.btnSeperator4 = new System.Windows.Forms.Button();
            this.pnlMain = new atACCFramework.UserControls.atPanel();
            this.txtCode = new atACCFramework.UserControls.TextBoxExt();
            this.txtName = new atACCFramework.UserControls.TextBoxExt();
            this.lblDepartmentCode = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.pnlSearchBylist.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(2, 158);
            this.pnlBottom.Size = new System.Drawing.Size(650, 43);
            // 
            // pnlSearchBylist
            // 
            this.pnlSearchBylist.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSearchBylist.Controls.Add(this.rbtAll);
            this.pnlSearchBylist.Controls.Add(this.radDepartment);
            this.pnlSearchBylist.Controls.Add(this.atLabel3);
            this.pnlSearchBylist.Controls.Add(this.btnSeperator4);
            this.pnlSearchBylist.Font = new System.Drawing.Font("Open Sans", 9F);
            this.pnlSearchBylist.Location = new System.Drawing.Point(7, 43);
            this.pnlSearchBylist.Name = "pnlSearchBylist";
            this.pnlSearchBylist.Size = new System.Drawing.Size(153, 96);
            this.pnlSearchBylist.TabIndex = 13;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.Checked = true;
            this.rbtAll.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.rbtAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtAll.Location = new System.Drawing.Point(6, 39);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(40, 22);
            this.rbtAll.TabIndex = 2;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            this.rbtAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
            // 
            // radDepartment
            // 
            this.radDepartment.AutoSize = true;
            this.radDepartment.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.radDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radDepartment.Location = new System.Drawing.Point(6, 58);
            this.radDepartment.Name = "radDepartment";
            this.radDepartment.Size = new System.Drawing.Size(130, 22);
            this.radDepartment.TabIndex = 1;
            this.radDepartment.Text = "Department Wise";
            this.radDepartment.UseVisualStyleBackColor = true;
            // 
            // atLabel3
            // 
            this.atLabel3.AutoSize = true;
            this.atLabel3.Font = new System.Drawing.Font("Open Sans", 12F);
            this.atLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.atLabel3.Location = new System.Drawing.Point(7, 6);
            this.atLabel3.Name = "atLabel3";
            this.atLabel3.RequiredField = false;
            this.atLabel3.Size = new System.Drawing.Size(84, 22);
            this.atLabel3.TabIndex = 0;
            this.atLabel3.Text = "Search By";
            // 
            // btnSeperator4
            // 
            this.btnSeperator4.BackColor = System.Drawing.Color.LightGray;
            this.btnSeperator4.FlatAppearance.BorderSize = 0;
            this.btnSeperator4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeperator4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeperator4.Location = new System.Drawing.Point(5, 31);
            this.btnSeperator4.Name = "btnSeperator4";
            this.btnSeperator4.Size = new System.Drawing.Size(140, 1);
            this.btnSeperator4.TabIndex = 12;
            this.btnSeperator4.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.txtCode);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblDepartmentCode);
            this.pnlMain.Controls.Add(this.lblDepartmentName);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pnlMain.Location = new System.Drawing.Point(165, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(487, 96);
            this.pnlMain.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.txtCode.Format = null;
            this.txtCode.isAllowNegative = false;
            this.txtCode.isAllowSpecialChar = false;
            this.txtCode.isNumbersOnly = false;
            this.txtCode.isNumeric = false;
            this.txtCode.isTouchable = false;
            this.txtCode.Location = new System.Drawing.Point(135, 35);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(344, 18);
            this.txtCode.TabIndex = 0;
            this.txtCode.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCode.WaterMark = null;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.txtName.Format = null;
            this.txtName.isAllowNegative = false;
            this.txtName.isAllowSpecialChar = false;
            this.txtName.isNumbersOnly = false;
            this.txtName.isNumeric = false;
            this.txtName.isTouchable = false;
            this.txtName.Location = new System.Drawing.Point(135, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 18);
            this.txtName.TabIndex = 1;
            this.txtName.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtName.WaterMark = null;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDepartmentCode
            // 
            this.lblDepartmentCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartmentCode.AutoSize = true;
            this.lblDepartmentCode.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.lblDepartmentCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDepartmentCode.Location = new System.Drawing.Point(85, 35);
            this.lblDepartmentCode.Name = "lblDepartmentCode";
            this.lblDepartmentCode.Size = new System.Drawing.Size(45, 18);
            this.lblDepartmentCode.TabIndex = 8;
            this.lblDepartmentCode.Text = "Code :";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.lblDepartmentName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDepartmentName.Location = new System.Drawing.Point(7, 61);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(126, 18);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name :";
            // 
            // frmCheckListServiceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 214);
            this.Controls.Add(this.pnlSearchBylist);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmCheckListServiceDepartment";
            this.Text = "frmCheckListServiceDepartment";
            this.atPreviewClick += new atACCFramework.BaseClasses.PreviewClickEventHandler(this.frmCheckListServiceDepartment_atPreviewClick);
            this.atDesignClick += new atACCFramework.BaseClasses.DesignClickEventHandler(this.frmCheckListServiceDepartment_atDesignClick);
            this.atValidate += new atACCFramework.BaseClasses.ValidateEventHandler(this.frmCheckListServiceDepartment_atValidate);
            this.Activated += new System.EventHandler(this.frmCheckListServiceDepartment_Activated);
            this.Load += new System.EventHandler(this.frmCheckListServiceDepartment_Load);
            this.Controls.SetChildIndex(this.pnlBottom, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlSearchBylist, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlSearchBylist.ResumeLayout(false);
            this.pnlSearchBylist.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private atACCFramework.UserControls.atPanel pnlSearchBylist;
        private atACCFramework.UserControls.atRadioButton rbtAll;
        private atACCFramework.UserControls.atRadioButton radDepartment;
        private atACCFramework.UserControls.atLabel atLabel3;
        private System.Windows.Forms.Button btnSeperator4;
        private atACCFramework.UserControls.atPanel pnlMain;
        private atACCFramework.UserControls.TextBoxExt txtCode;
        private atACCFramework.UserControls.TextBoxExt txtName;
        private System.Windows.Forms.Label lblDepartmentCode;
        private System.Windows.Forms.Label lblDepartmentName;
    }
}