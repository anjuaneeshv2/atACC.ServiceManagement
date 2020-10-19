using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using atACC.Common;
using atACC.CommonMessages;
using atACC.CommonExtensions;
using atACCFramework.Common;
using atACCFramework.BaseClasses;
using atACCFramework.ReportBases;
using atACCFramework.UserControls;
using atACCORM;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace atACC.ServiceManagement
{
    public partial class frmCheckListServiceDepartment : atReportFormBase
    { 
        #region Constructor
        public frmCheckListServiceDepartment()
        {
            InitializeComponent();
            db = atContext.CreateContext();
        }
        #endregion
        #region Private Variables
        ToolTip tooltip;
        atACCContextEntities db;
        #endregion
        #region Populate Events
        private void PopulateServiceDepartment()
        {
            try
            {
                List<ServiceDepartment> mvServiceDepartment = db.ServiceDepartments.ToList();
                txtCode.LoadSuggest(mvServiceDepartment, "DepartmentCode");
                txtName.LoadSuggest(mvServiceDepartment, "DepartmentName");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ShowToolTip()
        {
            try
            {
                tooltip = new ToolTip();
                tooltip.SetToolTip(txtCode, MessageKeys.MsgEnterCode);
                tooltip.SetToolTip(txtName, MessageKeys.MsgEnterName);
                tooltip.SetToolTip(rbtAll, MessageKeys.MsgEnableAllOptionToPreviewTheFullReportWithoutSorting);
                tooltip.SetToolTip(radDepartment, MessageKeys.MsgEnableToSearchUsingNameOrCode);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Form Events
        private void frmCheckListServiceDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateServiceDepartment();
                ShowToolTip();
                txtCode.Focus();
                rbtAll_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
        } 
        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            try
            {
                List<ServiceDepartment> Sd = db.ServiceDepartments.ToList();
                List<ServiceDepartment> SDp = Sd.Where(x => x.DepartmentCode == txtCode.Text).ToList();
                if (SDp.Count > 0)
                {
                    txtName.Text = SDp.Select(x => x.DepartmentName).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ServiceDepartment> Sd = db.ServiceDepartments.ToList();
                List<ServiceDepartment> SDp = Sd.Where(x => x.DepartmentName == txtName.Text).ToList();
                if (SDp.Count > 0)
                {
                    txtCode.Text = SDp.Select(x => x.DepartmentCode).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtCode.Enabled = !rbtAll.Checked;
                txtName.Enabled = !rbtAll.Checked;
                txtCode.Text = string.Empty;
                txtName.Text = string.Empty;
                errProvider.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void frmCheckListServiceDepartment_Activated(object sender, EventArgs e)
        {
            try
            {
                radDepartment.Checked = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Framework Events
        private bool frmCheckListServiceDepartment_atValidate(object source)
        {
            try
            {
                if (radDepartment.Checked == true && txtCode.Text == "" && txtName.Text == "")
                {
                    errProvider.SetError(radDepartment, MessageKeys.MsgAtleastOneSearchCriteriaMustBeSpecified); return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Validate);
                return false;
            }
        }
        private void frmCheckListServiceDepartment_atPreviewClick(object source, PreviewClickEventArgs e)
        {
            try
            {
                e.ReportPath = Application.StartupPath + "\\Reports\\rptCheckListServiceDepartment.rdlc";
                if (GlobalFunctions.LanguageCulture == "ar-QA")
                {
                    string sReportCaption = MessageKeys.MsgService + " " + MessageKeys.MsgOf + " " + MessageKeys.MsgChecklistReport;
                    e.reportParameters.Add(new atReportParameter("ReportCaption", sReportCaption));
                }
                else
                {
                    string sReportCaption = MessageKeys.MsgChecklistReport + " " + MessageKeys.MsgOf + " " + MessageKeys.MsgService;
                    e.reportParameters.Add(new atReportParameter("ReportCaption", sReportCaption));
                }
                DataSet ds = new DataSet();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();

                sqlParameters.Add(new SqlParameter("DepartmentName", txtName.Text.Trim()));
                sqlParameters.Add(new SqlParameter("DepartmentCode", txtCode.Text.Trim()));
                sqlParameters.Add(new SqlParameter("All", rbtAll.Checked ? 1 : 0));
                SqlHelper sqlh = new SqlHelper();
                ds = sqlh.ExecuteProcedure("SPCheckListServiceDepartment", sqlParameters);
                ds.Tables[0].TableName = "DataSetCheckListServiceDepartment";
                e.DataSource = ds;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Preview);
                return;
            }
        }
       //private void frmCheckListServiceDepartment_atHyperLinkClick(object sender, Microsoft.Reporting.WinForms.HyperlinkEventArgs e)
        //{
        //    try
        //    {
        //        Uri link = new Uri(e.Hyperlink);
        //        if (link.Authority == "ataccplus")
        //        {
        //            e.Cancel = true;
        //            char[] sep = new char[] { '=' };
        //            var param = link.Query.Split(sep);
        //            string rowid = param[1]; 
        //            ANIHelper aniHelper = new ANIHelper();
        //            aniHelper.DrillDownTransaction(EnContextID.ANI_Bank, rowid.ToInt32());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionManager.Publish(ex);
        //        atMessageBox.Show(ex, ENOperation.HyperLinkClick);
        //        return;
        //    }
        //}
        private void frmCheckListServiceDepartment_atDesignClick(object source, DesignClickEventArgs e)
        {
            try
            {
                e.ReportPath = Application.StartupPath + "\\ServiceManagement.Reports\\rptCheckListServiceDepartment.rdlc";
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.DesignClick);
                return;
            }
        }
        #endregion

      

   
        

    }
}
