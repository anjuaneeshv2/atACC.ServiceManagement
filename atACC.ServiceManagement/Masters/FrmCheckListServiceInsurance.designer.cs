namespace atACC.ServiceManagement
{
    partial class FrmCheckListServiceInsurance
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
            this.pnlCheckListServiceInsurance = new System.Windows.Forms.Panel();
            this.lblInsuranceCode = new atACCFramework.UserControls.atLabel();
            this.txtInsuranceCode = new atACCFramework.UserControls.TextBoxExt();
            this.lblInsuranceName = new atACCFramework.UserControls.atLabel();
            this.txtInsuranceName = new atACCFramework.UserControls.TextBoxExt();
            this.pnlSearchCriteria = new atACCFramework.UserControls.atPanel();
            this.lblSearchBy = new atACCFramework.UserControls.atLabel();
            this.radAll = new atACCFramework.UserControls.atRadioButton();
            this.radServiceInsurance = new atACCFramework.UserControls.atRadioButton();
            this.btnSeperator1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.pnlCheckListServiceInsurance.SuspendLayout();
            this.pnlSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(2, 180);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.Location = new System.Drawing.Point(-319, 3);
            this.pnlHeader2.Margin = new System.Windows.Forms.Padding(2);
            // 
            // pnlCheckListServiceInsurance
            // 
            this.pnlCheckListServiceInsurance.Controls.Add(this.lblInsuranceCode);
            this.pnlCheckListServiceInsurance.Controls.Add(this.txtInsuranceCode);
            this.pnlCheckListServiceInsurance.Controls.Add(this.lblInsuranceName);
            this.pnlCheckListServiceInsurance.Controls.Add(this.txtInsuranceName);
            this.pnlCheckListServiceInsurance.Controls.Add(this.pnlSearchCriteria);
            this.pnlCheckListServiceInsurance.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCheckListServiceInsurance.Location = new System.Drawing.Point(2, 38);
            this.pnlCheckListServiceInsurance.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheckListServiceInsurance.Name = "pnlCheckListServiceInsurance";
            this.pnlCheckListServiceInsurance.Size = new System.Drawing.Size(499, 142);
            this.pnlCheckListServiceInsurance.TabIndex = 6;
            // 
            // lblInsuranceCode
            // 
            this.lblInsuranceCode.AutoSize = true;
            this.lblInsuranceCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInsuranceCode.Location = new System.Drawing.Point(176, 32);
            this.lblInsuranceCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceCode.Name = "lblInsuranceCode";
            this.lblInsuranceCode.RequiredField = false;
            this.lblInsuranceCode.Size = new System.Drawing.Size(87, 15);
            this.lblInsuranceCode.TabIndex = 9;
            this.lblInsuranceCode.Text = "Insurance Code";
            // 
            // txtInsuranceCode
            // 
            this.txtInsuranceCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsuranceCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtInsuranceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsuranceCode.Format = null;
            this.txtInsuranceCode.isAllowNegative = false;
            this.txtInsuranceCode.isAllowSpecialChar = false;
            this.txtInsuranceCode.isNumbersOnly = false;
            this.txtInsuranceCode.isNumeric = false;
            this.txtInsuranceCode.isTouchable = false;
            this.txtInsuranceCode.Location = new System.Drawing.Point(267, 33);
            this.txtInsuranceCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtInsuranceCode.Name = "txtInsuranceCode";
            this.txtInsuranceCode.Size = new System.Drawing.Size(209, 15);
            this.txtInsuranceCode.TabIndex = 8;
            this.txtInsuranceCode.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtInsuranceCode.WaterMark = null;
            this.txtInsuranceCode.TextChanged += new System.EventHandler(this.txtInsuranceCode_TextChanged);
            // 
            // lblInsuranceName
            // 
            this.lblInsuranceName.AutoSize = true;
            this.lblInsuranceName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInsuranceName.Location = new System.Drawing.Point(176, 58);
            this.lblInsuranceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceName.Name = "lblInsuranceName";
            this.lblInsuranceName.RequiredField = false;
            this.lblInsuranceName.Size = new System.Drawing.Size(90, 15);
            this.lblInsuranceName.TabIndex = 7;
            this.lblInsuranceName.Text = "Insurance Name";
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsuranceName.BackColor = System.Drawing.SystemColors.Window;
            this.txtInsuranceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsuranceName.Format = null;
            this.txtInsuranceName.isAllowNegative = false;
            this.txtInsuranceName.isAllowSpecialChar = false;
            this.txtInsuranceName.isNumbersOnly = false;
            this.txtInsuranceName.isNumeric = false;
            this.txtInsuranceName.isTouchable = false;
            this.txtInsuranceName.Location = new System.Drawing.Point(267, 58);
            this.txtInsuranceName.Margin = new System.Windows.Forms.Padding(2);
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.Size = new System.Drawing.Size(209, 15);
            this.txtInsuranceName.TabIndex = 6;
            this.txtInsuranceName.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtInsuranceName.WaterMark = null;
            this.txtInsuranceName.TextChanged += new System.EventHandler(this.txtInsuranceName_TextChanged);
            // 
            // pnlSearchCriteria
            // 
            this.pnlSearchCriteria.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSearchCriteria.Controls.Add(this.lblSearchBy);
            this.pnlSearchCriteria.Controls.Add(this.radAll);
            this.pnlSearchCriteria.Controls.Add(this.radServiceInsurance);
            this.pnlSearchCriteria.Controls.Add(this.btnSeperator1);
            this.pnlSearchCriteria.Location = new System.Drawing.Point(7, 6);
            this.pnlSearchCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearchCriteria.Name = "pnlSearchCriteria";
            this.pnlSearchCriteria.Size = new System.Drawing.Size(165, 135);
            this.pnlSearchCriteria.TabIndex = 3;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblSearchBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchBy.Location = new System.Drawing.Point(6, 7);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.RequiredField = false;
            this.lblSearchBy.Size = new System.Drawing.Size(84, 22);
            this.lblSearchBy.TabIndex = 2;
            this.lblSearchBy.Text = "Search By";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.radAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radAll.Location = new System.Drawing.Point(5, 38);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(40, 22);
            this.radAll.TabIndex = 2;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.rbtAll_CheckedChanged);
            // 
            // radServiceInsurance
            // 
            this.radServiceInsurance.AutoSize = true;
            this.radServiceInsurance.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.radServiceInsurance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radServiceInsurance.Location = new System.Drawing.Point(5, 59);
            this.radServiceInsurance.Margin = new System.Windows.Forms.Padding(2);
            this.radServiceInsurance.Name = "radServiceInsurance";
            this.radServiceInsurance.Size = new System.Drawing.Size(127, 22);
            this.radServiceInsurance.TabIndex = 0;
            this.radServiceInsurance.Text = "Insurance  Name";
            this.radServiceInsurance.UseVisualStyleBackColor = true;
            // 
            // btnSeperator1
            // 
            this.btnSeperator1.BackColor = System.Drawing.Color.LightGray;
            this.btnSeperator1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSeperator1.FlatAppearance.BorderSize = 0;
            this.btnSeperator1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeperator1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeperator1.Location = new System.Drawing.Point(4, 35);
            this.btnSeperator1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeperator1.Name = "btnSeperator1";
            this.btnSeperator1.Size = new System.Drawing.Size(105, 1);
            this.btnSeperator1.TabIndex = 3;
            this.btnSeperator1.UseVisualStyleBackColor = false;
            // 
            // FrmCheckListServiceInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 237);
            this.Controls.Add(this.pnlCheckListServiceInsurance);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCheckListServiceInsurance";
            this.Text = "Check List Service Insurance";
            this.atPreviewClick += new atACCFramework.BaseClasses.PreviewClickEventHandler(this.frmCheckListServiceInsurance_atPreviewClick);
            this.atDesignClick += new atACCFramework.BaseClasses.DesignClickEventHandler(this.frmCheckListServiceInsurance_atDesignClick);
            this.atValidate += new atACCFramework.BaseClasses.ValidateEventHandler(this.frmCheckListServiceInsurance_atValidate);
            this.Activated += new System.EventHandler(this.frmCheckListServiceInsurance_Activated);
            this.Load += new System.EventHandler(this.FrmCheckListServiceInsurance_Load);
            this.Controls.SetChildIndex(this.pnlBottom, 0);
            this.Controls.SetChildIndex(this.pnlCheckListServiceInsurance, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlCheckListServiceInsurance.ResumeLayout(false);
            this.pnlCheckListServiceInsurance.PerformLayout();
            this.pnlSearchCriteria.ResumeLayout(false);
            this.pnlSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCheckListServiceInsurance;
        private atACCFramework.UserControls.atPanel pnlSearchCriteria;
        private atACCFramework.UserControls.atLabel lblSearchBy;
        private atACCFramework.UserControls.atRadioButton radAll;
        private atACCFramework.UserControls.atRadioButton radServiceInsurance;
        private System.Windows.Forms.Button btnSeperator1;
        private atACCFramework.UserControls.atLabel lblInsuranceName;
        private atACCFramework.UserControls.TextBoxExt txtInsuranceName;
        private atACCFramework.UserControls.atLabel lblInsuranceCode;
        private atACCFramework.UserControls.TextBoxExt txtInsuranceCode;
    }
}