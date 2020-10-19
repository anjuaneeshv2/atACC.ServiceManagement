using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using atACCFramework.BaseForms;
using atACC.Common;
using atACCFramework.BaseClasses;
using atACCFramework.Common;
using atACCFramework.UserControls;
using atACCORM;
using System.Data.Entity;
using atACC.CommonMessages;
using atACC.CommonExtensions;

namespace atACC.ServiceManagement
   
{
    public partial class ServiceDepartmentView : SearchFormBase2
    {
        #region Constructor
        public ServiceDepartmentView()
        {
          //  iContextID = Convert.ToInt32(EnContextID.Adm_ServiceDepartment);
            InitializeComponent();
            iContextID = 1355;
        }
        #endregion
        #region Private Variables
        ServiceDepartment s_Department;
        List<ServiceDepartment> s_Departmentlist;
        atACCContextEntities db;
        ToolTip tooltip;
        #endregion
        #region Populate Method
        private void GetSeqNo()
        {
            try
            {
                txtCode.Text = GlobalFunctions.getSequenceNo((int)ENMVMTTransactionType.Service, 0, 0, txtCode.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void PopulateServiceDepartment()
        {
            try
            {
                s_Departmentlist = db.ServiceDepartments.ToList();
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
                tooltip.SetToolTip(txtCode, MessageKeys.MsgEnterCode.GetMsg());
                tooltip.SetToolTip(txtName, MessageKeys.MsgEnterName.GetMsg());
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Form Event
        private void txtName_KeyDown(object sender, KeyEventArgs e)
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
        #region FrameWork Events
        private void ServiceDepartment_atInitialise()
        {
            try
            {
                db = atContext.CreateContext();
                s_Department = new ServiceDepartment();
                PrintButton.Visible = false;
                ShareButton.Visible = false;
                MaximizeButton.Visible = false;
                MinimizeButton.Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Initialise);
            }
        }
        private void ServiceDepartment_atAfterInitialise()
        {
            try
            {
                GetSeqNo();
                txtCode.Focus();
                ShowToolTip();
                PopulateServiceDepartment();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterInitialise);
            }
        }
        private void ServiceDepartment_atNewClick(object source)
        {
            try
            {
                s_Department = new ServiceDepartment();
                db = atContext.CreateContext();
                GetSeqNo();
                txtCode.Focus();
                PopulateServiceDepartment();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterInitialise);
                return;
            }
        }
        private bool ServiceDepartment_atValidate(object source)
        {
            try
            {
                if (txtCode.Text.Trim() == "") { errProvider.SetError(txtCode, MessageKeys.MsgCodeMustBeEntered.GetMsg()); txtCode.Focus(); return false; }
                if (txtName.Text.Trim() == "") { errProvider.SetError(txtName, MessageKeys.MsgNameMustBeEntered.GetMsg()); txtName.Focus(); return false; }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Validate);
                return false;
            }
        }
        private bool ServiceDepartment_atSaveClick(object source, SaveClickEventArgs e)
        {
            try
            {
                if (NewRecord)
                {
                    GetSeqNo();
                    s_Department = new ServiceDepartment();
                }
                s_Department.LocationID = GlobalFunctions.LoginLocationID;
                s_Department.LoginUserID = GlobalFunctions.LoginUserID;
                s_Department.DepartmentCode = txtCode.Text;
                s_Department.DepartmentName = txtName.Text;
                if (NewRecord)
                {
                    db.ServiceDepartments.AddObject(s_Department);
                }
                if (!NewRecord)
                {
                    db.ObjectStateManager.ChangeObjectState(s_Department,System.Data.EntityState.Modified);
                }
                db.SaveChanges();
                PopulateServiceDepartment();
                return true;
            }
            catch (UpdateException updEx)
            {
                db.DetachAllEntities();
                if (updEx.InnerException.Message.Contains("UC_ServiceDepartmentCode"))
                {
                    if (FirstSaveClick == true && atMessageBox.Show(MessageKeys.MsgCodeAlreadyExistsDoYouWantToFollowTheSeriesBasedOnPreviousSequence, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        txtCode.Focus();
                        return false;
                    }
                    FirstSaveClick = false;
                    return ServiceDepartment_atSaveClick(source, e);
                }
                else if (updEx.InnerException != null)
                {
                    if (updEx.InnerException.Message.Contains("UC_ServiceDepartmentName"))
                    {
                        atMessageBox.Show(MessageKeys.MsgAnother + MessageKeys.MsgService + " (" + txtName.Text + ") "
                            + MessageKeys.MsgWithSameNameAlreadyExistsPleaseEnterDifferentName);
                        txtName.Focus();
                        return false;
                    }
                }
                ExceptionManager.Publish(updEx);
                atMessageBox.Show(updEx, ENOperation.Save);
                return false;
            }
            catch (Exception ex)
            {
                db.DetachAllEntities();
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Save);
                return false;
            }
        }
        private void ServiceDepartment_atBeforeSearch(object source, BeforeSearchEventArgs e)
        {
            try
            {
                var mtype = s_Departmentlist.Select(x => new { id = x.id, Code = x.DepartmentCode, Name = x.DepartmentName }).OrderByDescending(x => x.id);
                e.SearchEntityList = mtype;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.BeforeSearch);
                return;
            }
        }
        public override void ReLoadData(int ID)
        {
            db = atContext.CreateContext();
            s_Department = db.ServiceDepartments.Where(x => x.id == ID).SingleOrDefault();
            if (s_Department != null)
            {
                txtCode.Text = s_Department.DepartmentCode;
                txtName.Text = s_Department.DepartmentName;
            }
        }
        private bool ServiceDepartment_atAfterSearch(object source, AfterSearchEventArgs e)
        {
            try
            {
                if (e.GetSelectedEntity() != null)
                {
                    NewClick();
                    var mtype = new { id = 0, Code = "", Name = "" };
                    ReLoadData(e.GetSelectedEntity().Cast(mtype).id);
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterSearch);
                return false;
            }
        }
        private void ServiceDepartment_atAfterEditClick(object source, EditClickEventArgs e)
        {
            try
            {
                txtCode.Focus();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterEdit);
            }
        }
        private bool ServiceDepartment_atDelete(object source, DeleteClickEventArgs e)
        {
            try
            {

                db.DeleteObject(s_Department);
                db.SaveChanges();
                PopulateServiceDepartment();
                return true;
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.Delete);
                return false;
            }
        }
        private void ServiceDepartment_atAfterDelete(object source)
        {
            try
            {
                NewClick();
            }
            catch (Exception ex)
            {
                ExceptionManager.Publish(ex);
                atMessageBox.Show(ex, ENOperation.AfterDelete);
                return;
            }
        }
        #endregion

       

       
    }
}
