using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HP.Business;
using HP.Model;

namespace BMS
{
	public partial class frmAddEditKnife : _Forms
	{
		#region Variables
		public KnifeDetailListModel knifeDetailListModel = new KnifeDetailListModel();
		private int _type = 1;
		#endregion

		#region Methods
		public frmAddEditKnife(int type)
		{
			InitializeComponent();
			if (type == cGlobalVariables.Add)
			{
				this.Text = "THÊM CÔNG CỤ";
				_type = cGlobalVariables.Add;
			}
			if (type == cGlobalVariables.Edit)
			{
				this.Text = "SỬA CÔNG CỤ";
				_type = cGlobalVariables.Edit;
			}
		}

		void LoadListUsers()
		{
			DataTable dt = TextUtilsHP.Select(cGlobalFunction.GetWithSelectionQuery(new string[] { "ID", "UserCode", "FullName", "BirthOfDate", "DepartmentID", "DepartmentCode" }, "Users", "UserCode"));
			cWorker.Properties.DataSource = dt;
			cWorker.Properties.DisplayMember = "FullName";
			cWorker.Properties.ValueMember = "ID";
		}
		void LoadDataToForm()
		{
			if (knifeDetailListModel.ID > 0)
			{
				cboDaoParent.SelectedValue = knifeDetailListModel.ID;
			}
			else
			{
				cboDaoParent.Text = "";
			}
			txbKnifeCode.Text = knifeDetailListModel.KnifeCode;
			cWorker.EditValue = knifeDetailListModel.WorkerID;
			txbKnifeName.Text = knifeDetailListModel.KnifeName;
			txbDescription.Text = knifeDetailListModel.Description;
			txbATC.Value = knifeDetailListModel.ATC;
			txbSTD.Value = knifeDetailListModel.STD;

			/*if (!string.IsNullOrEmpty(cWorker.Text)) { 
				DataRowView selectData = (DataRowView)cWorker.GetSelectedDataRow();
				string departmentCode = (string)selectData.Row.ItemArray[6];
				txbDepartmentCode.Text = departmentCode;
			}*/


		}

		bool ValidateForm()
		{
			if (txbKnifeCode.Text == "")
			{
				MessageBox.Show("Vui lòng nhập mã dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			/*if (txbKnifeName.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên dao!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}*/

			if (txbSTD.Value == 0 || txbATC.Value == 0)
			{
				MessageBox.Show("Vui lòng nhập dữ liệu ATC và STD khác 0!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}

			if (cWorker.EditValue == null)
			{
				MessageBox.Show("Vui lòng chọn người phụ trách!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return false;
			}


			if (KnifeDetailListBO.Instance.CheckExist("KnifeCode", txbKnifeCode.Text))
			{
				if (_type == cGlobalVariables.Edit && txbKnifeCode.Text.Trim() != knifeDetailListModel.KnifeCode || _type == cGlobalVariables.Add)
				{
					MessageBox.Show("Mã dao đã tồn tại!", TextUtilsHP.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
					return false;
				}
			}
			return true;
		}

		bool SaveData()
		{
			if (ValidateForm())
			{
				try
				{
					if (_type == cGlobalVariables.Add)
					{
						knifeDetailListModel.KnifeCode = txbKnifeCode.Text.Trim();
						knifeDetailListModel.WorkerID = TextUtilsHP.ToInt(cWorker.EditValue);
						knifeDetailListModel.KnifeName = txbKnifeName.Text.Trim();
						knifeDetailListModel.ImportedDate = DateTime.Now;
						knifeDetailListModel.ATC = TextUtilsHP.ToInt(txbATC.Value);
						knifeDetailListModel.STD = TextUtilsHP.ToInt(txbSTD.Value);
						knifeDetailListModel.Description = txbDescription.Text;
						knifeDetailListModel.Status = true;
						KnifeDetailListBO.Instance.Insert(knifeDetailListModel);
						return true;
					}
					if (_type == cGlobalVariables.Edit)
					{
						knifeDetailListModel.KnifeCode = txbKnifeCode.Text.Trim();
						knifeDetailListModel.WorkerID = TextUtilsHP.ToInt(cWorker.EditValue);
						knifeDetailListModel.KnifeName = txbKnifeName.Text.Trim();
						knifeDetailListModel.ImportedDate = DateTime.Now;
						knifeDetailListModel.ATC = TextUtilsHP.ToInt(txbATC.Value);
						knifeDetailListModel.STD = TextUtilsHP.ToInt(txbSTD.Value);
						knifeDetailListModel.Description = txbDescription.Text;

						TextUtilsHP.ExcuteProcedure("spKnifeDetailUpdate",
									new string[] { "@id", "@knifeCode", "@knifeName", "@description", "@std", "@atc", "@workerID" },
									new object[] { knifeDetailListModel.ID, knifeDetailListModel.KnifeCode, knifeDetailListModel.KnifeName, knifeDetailListModel.Description, knifeDetailListModel.STD, knifeDetailListModel.ATC, knifeDetailListModel.WorkerID });

						return true;
					}
				}
				catch (Exception ex)
				{
					return false;
				}
			}
			return false;
		}
		#endregion

		#region Events
		private void cấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveClose_Click(null, null);
		}

		private void catVaThemOiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnSaveNew_Click(null, null);
		}

		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				knifeDetailListModel = new KnifeDetailListModel();
				this.Text = "THÊM CÔNG CỤ";
				_type = cGlobalVariables.Add;
				LoadDataToForm();
			}
		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			if (SaveData())
			{
				this.DialogResult = DialogResult.OK;
			}
		}

		private void frmAddEditKnife_Load(object sender, EventArgs e)
		{
			LoadCbParent();
			LoadListUsers();
			LoadDataToForm();
		}
		void LoadCbParent()
		{
			DataTable dt = TextUtilsHP.Select("SELECT KnifeCode,ID FROM [HypoidPinion].[dbo].[KnifeDetailList] WHERE ParentID = 0 and Type = 0");
			cboDaoParent.DataSource = dt;
			cboDaoParent.DisplayMember = "KnifeCode";
			cboDaoParent.ValueMember = "ID";
		}

		private void frmAddEditKnife_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		private void cWorker_EditValueChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cWorker.Text))
			{
				DataRowView selectData = (DataRowView)cWorker.GetSelectedDataRow();
				string departmentCode = (string)selectData.Row.ItemArray[6];
				txbDepartmentCode.Text = departmentCode;
			}
		}

		#endregion

		private void txbKnifeCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txbKnifeName.Focus();
		}

		private void txbKnifeName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			cWorker.Focus();
		}

		private void cboDaoParent_SelectedIndexChanged(object sender, EventArgs e)
		{
			cWorker.Focus();
		}
		private void txbDepartmentCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txbDescription.Focus();
		}

		private void txbDescription_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txbSTD.Focus();
		}

		private void txbSTD_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			txbATC.Focus();
		}
	}
}
