using atACCFramework.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using atACC.CommonExtensions;
using atACCFramework.ReportBases;
using atACCFramework.UserControls;
using atACCORM;
using System.Data.SqlClient;
using atACCFramework.Common;
using atACC.Common;
using atACC.CommonMessages;
using Microsoft.Reporting.WinForms;

namespace atACC.ServiceManagement
{
    public partial class FrmCheckListServiceInsurance : atReportFormBase
    {
        #region Constructor
        public FrmCheckListServiceInsurance()
        {
            InitializeComponent();
            db = atContext.CreateContext();
        }
        #endregion
        #region Private Variables
        ToolTip tooltip;
        atACCContextEntities db;
        CommonLibClasses objLib = new CommonLibClasses();
        #endregion
        #region Populate Events
        private void PopulateServiceInsurance()
        {
            try
            {
               
                List<ServiceInsurance> m_ServiceInsuranceList = db.ServiceInsurances.ToList();
                txtInsuranceCode.LoadSuggest(m_ServiceInsuranceList, "InsuranceCode");
                txtInsuranceName.LoadSuggest(m_ServiceInsuranceList, "InsuranceName");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Form Events
        private void FrmCheckListServiceInsurance_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateServiceInsurance();
                txtInsuranceCode.Focus();

                //**ToolTip Section**//
                tooltip = new ToolTip();
               // tooltip.SetToolTip(txtInsuranceName, MessageKeys.MsgEnterVoucherNumber);
                rbtAll_CheckedChanged(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtInsuranceCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ServiceInsurance> Sd = db.ServiceInsurances.ToList();
                List<ServiceInsurance> SDp = Sd.Where(x => x.InsuranceCode == txtInsuranceCode.Text).ToList();
                if (SDp.Count > 0)
                {
                    txtInsuranceName.Text = SDp.Select(x => x.InsuranceName).Single();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void txtInsuranceName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ServiceInsurance> Sd = db.ServiceInsurances.ToList();
                List<ServiceInsurance> SDp = Sd.Where(x => x.InsuranceCode == txtInsuranceName.Text).ToList();
                if (SDp.Count > 0)
                {
                    txtInsuranceCode.Text = SDp.Select(x => x.InsuranceCode).Single();
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
                txtInsuranceCode.Enabled = !radAll.Checked;
                txtInsuranceName.Enabled = !radAll.Checked;
                txtInsuranceCode.Text = string.Empty;
                txtInsuranceName.Text = string.Empty;
                errProvider.Clear();
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void frmCheckListServiceInsurance_Activated(object sender, EventArgs e)
        {
            try
            {
                radServiceInsurance.Checked = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Framework Events
        private bool frmCheckListServiceInsurance_atValidate(object source)
        {
            try
            {
                if (radServiceInsurance.Checked == true && txtInsuranceCode.Text == "" && txtInsuranceName.Text == "")
                {
                    errProvider.SetError(radServiceInsurance, MessageKeys.MsgAtleastOneSearchCriteriaMustBeSpecified); return false;
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
        private void frmCheckListServiceInsurance_atPreviewClick(object source, PreviewClickEventArgs e)
        {
            try
            {
                e.ReportPath = Application.StartupPath + "\\Reports\\rptCheckListServiceInsurance.rdlc";
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

                sqlParameters.Add(new SqlParameter("InsuranceName", txtInsuranceName.Text));
                sqlParameters.Add(new SqlParameter("InsuranceCode", txtInsuranceCode.Text));
                sqlParameters.Add(new SqlParameter("All", radAll.Checked ? 1 : 0));
                SqlHelper sqlh = new SqlHelper();
                ds = sqlh.ExecuteProcedure("SPCheckListServiceInsurance", sqlParameters);
                ds.Tables[0].TableName = "DataSetCheckListServiceInsurance";
                e.DataSource = ds;
            
                }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Preview);
                return;
            }
        }
        private void frmCheckListServiceInsurance_atDesignClick(object source, DesignClickEventArgs e)
        {
            try
            {
                if (radAll.Checked == true)
                {
                    e.ReportPath = Application.StartupPath + "\\Reports\\rptCheckListServiceInsurance.rdlc";
                }
              
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
