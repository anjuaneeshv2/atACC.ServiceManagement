namespace atACC.ServiceManagement
{
    partial class ServiceDepartmentView
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
            this.pnlOptionalBar = new atACCFramework.UserControls.atGradientPanel();
            this.pnlMain = new atACCFramework.UserControls.atPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new atACCFramework.UserControls.TextBoxExt();
            this.lblName = new atACCFramework.UserControls.atLabel();
            this.txtName = new atACCFramework.UserControls.TextBoxExt();
            this.lblMandatory1 = new System.Windows.Forms.Label();
            this.lblCode = new atACCFramework.UserControls.atLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Size = new System.Drawing.Size(685, 43);
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.Location = new System.Drawing.Point(-5670, 3);
            // 
            // pnlOptionalBar
            // 
            this.pnlOptionalBar.AllowMultiSelect = false;
            this.pnlOptionalBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOptionalBar.Angle = 120F;
            this.pnlOptionalBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(125)))));
            this.pnlOptionalBar.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.pnlOptionalBar.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.pnlOptionalBar.Location = new System.Drawing.Point(4, 43);
            this.pnlOptionalBar.Name = "pnlOptionalBar";
            this.pnlOptionalBar.Selected = false;
            this.pnlOptionalBar.Size = new System.Drawing.Size(150, 119);
            this.pnlOptionalBar.TabIndex = 9;
            this.pnlOptionalBar.TextAdjestmentHeight = 0;
            this.pnlOptionalBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlOptionalBar.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtCode);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblMandatory1);
            this.pnlMain.Controls.Add(this.lblCode);
            this.pnlMain.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.pnlMain.Location = new System.Drawing.Point(167, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(503, 91);
            this.pnlMain.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "*";
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
            this.txtCode.Location = new System.Drawing.Point(125, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(356, 18);
            this.txtCode.TabIndex = 0;
            this.txtCode.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCode.WaterMark = null;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(28, 41);
            this.lblName.Name = "lblName";
            this.lblName.RequiredField = false;
            this.lblName.Size = new System.Drawing.Size(91, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.txtName.Location = new System.Drawing.Point(125, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 18);
            this.txtName.TabIndex = 1;
            this.txtName.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtName.WaterMark = null;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblMandatory1
            // 
            this.lblMandatory1.AutoSize = true;
            this.lblMandatory1.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.lblMandatory1.ForeColor = System.Drawing.Color.Crimson;
            this.lblMandatory1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMandatory1.Location = new System.Drawing.Point(57, 12);
            this.lblMandatory1.Name = "lblMandatory1";
            this.lblMandatory1.Size = new System.Drawing.Size(15, 18);
            this.lblMandatory1.TabIndex = 5;
            this.lblMandatory1.Text = "*";
            // 
            // lblCode
            // 
            this.lblCode.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.lblCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCode.Location = new System.Drawing.Point(31, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.RequiredField = true;
            this.lblCode.Size = new System.Drawing.Size(88, 18);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ServiceDepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 205);
            this.Controls.Add(this.pnlOptionalBar);
            this.Controls.Add(this.pnlMain);
            this.Name = "ServiceDepartmentView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Service Department";
            this.atSaveClick += new atACCFramework.BaseClasses.SaveClickEventHandler(this.ServiceDepartment_atSaveClick);
            this.atInitialise += new atACCFramework.BaseClasses.InitialiseEventHandler(this.ServiceDepartment_atInitialise);
            this.atAfterInitialise += new atACCFramework.BaseClasses.AfterInitialiseEventHandler(this.ServiceDepartment_atAfterInitialise);
            this.atNewClick += new atACCFramework.BaseClasses.NewClickEventHandler(this.ServiceDepartment_atNewClick);
            this.atAfterEditClick += new atACCFramework.BaseClasses.AfterEditClickEventHandler(this.ServiceDepartment_atAfterEditClick);
            this.atDelete += new atACCFramework.BaseClasses.DeleteClickEventHandler(this.ServiceDepartment_atDelete);
            this.atAfterDelete += new atACCFramework.BaseClasses.AfterDeleteEventHandler(this.ServiceDepartment_atAfterDelete);
            this.atValidate += new atACCFramework.BaseClasses.ValidateEventHandler(this.ServiceDepartment_atValidate);
            this.atAfterSearch += new atACCFramework.BaseClasses.AfterSearchEventHandler(this.ServiceDepartment_atAfterSearch);
            this.atBeforeSearch += new atACCFramework.BaseClasses.BeforeSearchEventHandler(this.ServiceDepartment_atBeforeSearch);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            this.Controls.SetChildIndex(this.pnlOptionalBar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private atACCFramework.UserControls.atGradientPanel pnlOptionalBar;
        private atACCFramework.UserControls.atPanel pnlMain;
        private atACCFramework.UserControls.TextBoxExt txtCode;
        private atACCFramework.UserControls.TextBoxExt txtName;
        private System.Windows.Forms.Label lblMandatory1;
        private atACCFramework.UserControls.atLabel lblCode;
        private System.Windows.Forms.Label label1;
        private atACCFramework.UserControls.atLabel lblName;

    }
}

