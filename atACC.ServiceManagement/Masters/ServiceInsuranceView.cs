using atACC.Common;
using atACC.CommonExtensions;
using atACC.CommonMessages;
using atACCFramework.BaseClasses;
using atACCFramework.Common;
using atACCORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atACC.ServiceManagement
{
    public partial class ServiceInsuranceView : SearchFormBase2
    {
        #region Constructors
        public ServiceInsuranceView()
        {
            InitializeComponent();
            iContextID = 1356;
        }
        #endregion Constructors
        #region Private Varibales
        ServiceInsurance m_ServiceInsurance;
        List<ServiceInsurance> m_ServiceInsuranceList;
        atACCContextEntities db;
        ToolTip tooltip;
        private CommonLibClasses objLib;
        public atACCFramework.BaseClasses.BeforeSearchEventArgs Before_Search;
        public object S;
        #endregion Private Varibales
        #region Populate Events
        private void GetSeqNo()
        {
            try
            {
                txtInsuranceCode.Text = GlobalFunctions.getSequenceNo((int)ENMVMTTransactionType.Service, 0, 0, txtInsuranceCode.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void PopulateServiceInsurance()

        {
            try
            {
                m_ServiceInsuranceList = db.ServiceInsurances.ToList();
            }
            catch (Exception)
            {
                throw;

            }
        }
        public void PopulateCombos()
        {
            try
            {

                cmbCompany.DataSource = db.Companies.OrderBy(x => x.CompanyName).ToList();
                cmbCompany.DisplayMember = "Name";
                cmbCompany.ValueMember = "id";
                cmbCompany.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredAfterSave);
            }




        }
        private void ShowToolTip()
        {
            try
            {
                tooltip = new ToolTip();
               
                tooltip.SetToolTip(txtInsuranceCode, "Enter Insurance Code");
                tooltip.SetToolTip(txtInsuranceName, "Enter Insurance Name");
                tooltip.SetToolTip(cmbCompany, "Choose Company");

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void FnClearAll()
        {
            objLib = new CommonLibClasses();
            m_ServiceInsurance = new ServiceInsurance();
            m_ServiceInsuranceList = new List<ServiceInsurance>();
            txtInsuranceCode.Focus();
        }
        #endregion Populate Event
        #region Form Event
        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift == false && e.KeyCode == Keys.Return)
                {
                    e.Handled = true;
                    SaveClick();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Framework events
        private void FrmServiceInsuranceView_atInitialise()
        {
            try
            {
                db = atContext.CreateContext();
                m_ServiceInsurance = new ServiceInsurance();
                PrintButton.Visible = false;
                MaximizeButton.Visible = false;
                MinimizeButton.Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccuredWhileIntialising);
            }
        }
        private void FrmServiceInsurance_atAfterInitialise()
        {
            try
            {
                txtInsuranceCode.Focus();
               
                ShowToolTip();
                PopulateCombos();
                PopulateServiceInsurance();
                GetSeqNo();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterInitialise);
            }

        }
        private void FrmServiceInsuranceView_atNewClick(object source)
        {
            try
            {
                m_ServiceInsurance = new ServiceInsurance();
                db = atContext.CreateContext();
                txtInsuranceCode.Focus();
              
                FnClearAll();
                PopulateCombos();
                ShowToolTip();
                PopulateServiceInsurance();
                GetSeqNo();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.New);
                return;
            }
        }
        private bool FrmServiceInsuranceView_atValidate(object source)
        {
            try
            {
                if (txtInsuranceCode.Text.Trim() == string.Empty)
                {
                    errProvider.SetError(txtInsuranceCode, "Enter Insurance Code");
                    txtInsuranceCode.Focus();
                    return false;
                }
                if (txtInsuranceName.Text.Trim() == string.Empty)
                {
                    errProvider.SetError(txtInsuranceName, "Enter Insurance Name ");
                    txtInsuranceName.Focus();
                    return false;
                }
                if (cmbCompany.Text.Trim() == string.Empty)
                {
                    errProvider.SetError(cmbCompany, MessageKeys.MsgCompany);
                    cmbCompany.Focus();
                    return false;
                }

                
               
                return true;
            }

            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredWhileValidating);
                return false;
            }
        }
        private bool FrmServiceInsuranceView_atSaveClick(object source, SaveClickEventArgs e)
        {
            try
            {
                if (NewRecord)
                {
                    GetSeqNo();
                    m_ServiceInsurance = new ServiceInsurance();
                }
              
                m_ServiceInsurance.LocationID = GlobalFunctions.LoginLocationID;
                m_ServiceInsurance.LoginUserID= GlobalFunctions.LoginUserID;
                m_ServiceInsurance.InsuranceCode = txtInsuranceCode.Text.ToString();
                m_ServiceInsurance.InsuranceName = txtInsuranceName.Text.ToString();
                m_ServiceInsurance.Description = txtDescription.Text.ToString();
                m_ServiceInsurance.CompanyName = cmbCompany.Text.ToString();
                if (NewRecord)
                {
                    db.ServiceInsurances.AddObject(m_ServiceInsurance);
                }
                else
                {
                    db.ObjectStateManager.ChangeObjectState(m_ServiceInsurance, EntityState.Modified);
                }
                db.SaveChanges();
                return true;
            }
            catch (UpdateException updEx)
            {
                db.DetachAllEntities();
              
                ExceptionManager.Publish(updEx);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredWhileSaving);
                
                return false;
            }
            catch (Exception ex)
            {
                db.DetachAllEntities();
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredWhileSaving);
                return false;
            }

        }
        private bool FrmServiceInsuranceView_atAfterSave(object source)
        {
            try
            {
                NewClick();
                PopulateServiceInsurance();
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredAfterSave);
                return false;
            }
        }
        private void FrmServiceInsuranceView_atBeforeSearch(object source, BeforeSearchEventArgs e)
        {
            try
            {
                e.SearchEntityList = m_ServiceInsuranceList.Select(x => new { x.id, Name = x.InsuranceName }).OrderByDescending(x => x.id);
             
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredBeforeSearching);
            }
        }
        public override void ReLoadData(int id)
        {
            try
            {
                db = atContext.CreateContext();
                m_ServiceInsurance = db.ServiceInsurances.Where(x => x.id == id).SingleOrDefault();
                if (m_ServiceInsurance != null)
                {
                    txtInsuranceCode.Text = m_ServiceInsurance.InsuranceCode.ToString();
                    txtInsuranceName.Text = m_ServiceInsurance.InsuranceName.ToString();
                    txtDescription.Text = m_ServiceInsurance.Description.ToString();
                    cmbCompany.Text = m_ServiceInsurance.CompanyName.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                throw;
            }
        }
        private bool FrmServiceInsuranceView_atAfterSearch(object source, AfterSearchEventArgs e)
        {
            try
            {
                if (e.GetSelectedEntity() != null)
                {
                    NewClick();
                    var vLoan = new { id = 0, Name = string.Empty };
                    ReLoadData(e.GetSelectedEntity().Cast(vLoan).id);
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(MessageKeys.MsgExceptionOccurredAfterSearching);
                return false;
            }
        }
        private void FrmServiceInsuranceView_atAfterEditClick(object source, EditClickEventArgs e)
        {
            try
            {
                txtInsuranceCode.Focus();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterEdit);
            }
        }
        private bool FrmServiceInsuranceView_atDelete(object source, DeleteClickEventArgs e)
        {
            try
            {
                db.ServiceInsurances.DeleteObject(m_ServiceInsurance);
                db.SaveChanges();
                PopulateCombos();
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Delete);
                return false;
            }
        }
        private void FrmServiceInsuranceView_atAfterDelete(object source)
        {
            try
            {
                NewClick();
                PopulateServiceInsurance();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterDelete);
            }
        }
        #endregion Framework events

       
    }
}
