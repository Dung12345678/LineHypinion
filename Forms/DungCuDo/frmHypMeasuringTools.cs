using DevExpress.XtraGrid;
using HP.Business;
using HP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
	public partial class frmHypMeasuringTools : Form
	{
		DataTable _dtMaHang;
		DataTable _dtKnifeDetailList;
		Thread _threadReset;
		Thread _threadFrequencyCheck;
		int GoodsID = 0;

		DataTable dtAll = new DataTable();

		string Knife = "";
		DateTime _dateTimeStart1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 01);
		DateTime _dateTimeStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 01);
		DateTime _dateTimeEnd1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 09, 59, 59);
		DateTime _dateTimeEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 07);
		//Check đã reset chưa 1 đã reset,2 đã reset và chờ 
		int CheckReset = 0;
		int _idMaHang { get; set; }
		public frmHypMeasuringTools()
		{
			InitializeComponent();
		}

		private void frmHypMeasuringTools_Load(object sender, EventArgs e)
		{
			LoadCboPart();
			loadGridControl();
			txtChecker.Focus();
			//4 tiếng reset 1 lần bắt đầu từ 6h sáng 
			_threadReset = new Thread(new ThreadStart(ResetControl));
			_threadReset.IsBackground = true;
			_threadReset.Start();

			//_threadFrequencyCheck = new Thread(new ThreadStart(FrequencyCheck));
			//_threadFrequencyCheck.IsBackground = true;
			//_threadFrequencyCheck.Start();
			ShowPart();
		}
		void ShowPart()
		{
			try
			{
				DataTable dt = TextUtilsHP.Select("SELECT DISTINCT  [PartCode] FROM [HypoidPinion].[dbo].[ToolDetail]");
				DataRow dr = dt.NewRow();
				dr["PartCode"] = "";
				dt.Rows.InsertAt(dr, 0);
				cboPart.DataSource = dt;
				cboPart.DisplayMember = "PartCode";
			}
			catch (Exception)
			{

				throw;
			}

		}
		//void FrequencyCheck()
		//{
		//	while (true)
		//	{
		//		Thread.Sleep(1000);
		//		try
		//		{
		//			if (txtToolCode.Text.Trim() == "") continue;
		//			if (dt == null || dt.Rows.Count <= 0) continue;
		//			//Lấy ra ngày nhập gần nhất 
		//			string date = TextUtilsHP.ToString(TextUtilsHP.ExcuteScalar($"SELECT top 1 CreateDate FROM[HypoidPinion].[dbo].[CheckHistory] WHERE OrderCode = '' AND KnifeDetailCodeReal = '{Knife}' Order By ID Desc"));
		//			if (date.Trim() == "")
		//			{
		//				date = TextUtils.ToString(dt.Rows[1]["DateOld"]);
		//			}
		//			//Lấy ra số yêu cầu kiểm tra 0 tuần,1 ngày,2 tháng,3 năm
		//			int type = TextUtils.ToInt(dt.Rows[1]["TypeFrequencyCheck"]);
		//			double ValueFrequency = TextUtils.ToDouble(dt.Rows[1]["ValueFrequency"]);
		//			DateTime dateOld = TextUtilsHP.ToDate(date);
		//			//Cộng ngày nhập gần nhất với 
		//			this.Invoke((MethodInvoker)delegate
		//			{
		//				switch (type)
		//				{
		//					case 0:
		//						dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
		//						break;
		//					case 1:
		//						dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
		//						break;
		//					case 2:
		//						dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddMonths(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
		//						break;
		//					case 3:
		//						dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddYears(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
		//						break;
		//					default:
		//						break;
		//				}
		//			});
		//		}
		//		catch
		//		{
		//		}
		//	}
		//}
		void ResetControl()
		{
			while (true)
			{
				Thread.Sleep(200);
				if (_dateTimeStart < DateTime.Now && DateTime.Now < _dateTimeEnd)
				{
					//Reset
					this.Invoke((MethodInvoker)delegate
					{
						resert();
					});
					_dateTimeStart = _dateTimeStart.AddHours(4);
					_dateTimeEnd = _dateTimeEnd.AddHours(4);
				}
				else
				{
					if (DateTime.Now > _dateTimeEnd1)
					{
						_dateTimeStart1 = _dateTimeStart1.AddHours(4);
						_dateTimeEnd1 = _dateTimeEnd1.AddHours(4);
						_dateTimeStart = _dateTimeStart.AddHours(4);
						_dateTimeEnd = _dateTimeEnd.AddHours(4);
					}
				}
			}
		}
		void resert()
		{
			txtChecker.Text = "";
			txtAddCodeProduct.Text = "";
			txtCancelCodeProduct.Text = "";
			txtToolCode.Text = "";
			txtSTD.Text = "";
			txtMin.Text = "";
			txtMax.Text = "";
			txtValue.Text = "";
			txtResult.Text = "";
			txtSTD.Text = "";
			txtSTD.Text = "";
			txtSTD.Text = "";
			//loadGridControl();
			//Reset dữ liệu kiểm tra trong grid

			for (int i = 0; i < grvToolList.RowCount; i++)
			{
				grvToolList.SetRowCellValue(i, colRealValue, "");
				grvToolList.SetRowCellValue(i, colResult, "");
			}
		}
		void LoadCboPart()
		{
			DataTable dt = TextUtilsHP.Select("SELECT * FROM Part");
			cboPart.DataSource = dt;
			cboPart.DisplayMember = "PartCode";
			cboPart.ValueMember = "ID";

		}

		private void loadGridControl()
		{
			_dtMaHang = new DataTable();
			DataColumn colMaHang = new DataColumn("Mahang", typeof(string));
			DataColumn colID = new DataColumn("ID", typeof(int));
			_dtMaHang.Columns.Add(colMaHang);
			_dtMaHang.Columns.Add(colID);
			grdMaHang.DataSource = _dtMaHang;

			DataTable dtMaDungCu = new DataTable();
			DataColumn colCode = new DataColumn("Code", typeof(string));
			DataColumn colIDTool = new DataColumn("ID", typeof(int));
			DataColumn colName = new DataColumn("Name", typeof(string));
			DataColumn colNameDisplay = new DataColumn("NameDisplay", typeof(string));
			DataColumn colMin = new DataColumn("Min", typeof(string));
			DataColumn colMax = new DataColumn("Max", typeof(string));
			DataColumn colStd = new DataColumn("Std", typeof(string));
			DataColumn colType = new DataColumn("Type", typeof(string));
			DataColumn colRealValue = new DataColumn("RealValue", typeof(string));
			DataColumn colResult = new DataColumn("Result", typeof(string));
			DataColumn colGoodID = new DataColumn("GoodID", typeof(string));
			dtMaDungCu.Columns.Add(colCode);
			dtMaDungCu.Columns.Add(colName);
			dtMaDungCu.Columns.Add(colNameDisplay);
			dtMaDungCu.Columns.Add(colMin);
			dtMaDungCu.Columns.Add(colMax);
			dtMaDungCu.Columns.Add(colStd);
			dtMaDungCu.Columns.Add(colRealValue);
			dtMaDungCu.Columns.Add(colResult);
			dtMaDungCu.Columns.Add(colType);
			dtMaDungCu.Columns.Add(colIDTool);
			dtMaDungCu.Columns.Add(colGoodID);
			grdToolList.DataSource = dtMaDungCu;

			_dtKnifeDetailList = TextUtilsHP.Select($"select * from dbo.Tools left join dbo.GoodsRegister on dbo.Tools.ID = dbo.GoodsRegister.ToolsID");
		}
		private void txtAddCodeProduct_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			if (txtAddCodeProduct.Text.Trim() == "") return;
			//TODO: Kiểm tra có tồn tại mã hàng không?
			GoodsID = TextUtilsHP.ToInt(TextUtilsHP.ExcuteScalar($"select ID from dbo.Goods where Name ='{txtAddCodeProduct.Text.Trim()}'"));
			if (GoodsID == 0)
			{
				MessageBox.Show($"Mã hàng [{txtAddCodeProduct.Text.Trim()}] này không tồn tại trong cơ sở dữ liệu! ", "RTC WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//TODO: Kiểm tra có trùng mã hàng không
			for (int i = 0; i < grvMaHang.RowCount; i++)
			{
				grvMaHang.Focus();
				txtAddCodeProduct.Focus();
				string value = TextUtilsHP.ToString(grvMaHang.GetRowCellValue(i, "Mahang"));

				if (value == txtAddCodeProduct.Text.Trim())
				{
					return;
				}
			}
			//TODO: Show data lên 2 bảng
			grvMaHang.AddNewRow();
			grvMaHang.SetRowCellValue(GridControl.NewItemRowHandle, grvMaHang.Columns["Mahang"], txtAddCodeProduct.Text.Trim());
			grvMaHang.SetRowCellValue(GridControl.NewItemRowHandle, grvMaHang.Columns["ID"], TextUtilsHP.ToString(GoodsID));
			loadToollist(1);
			//DataTable dtAll = _dtKnifeDetailList.Clone();
			//dtAll.Clear();
			//for (int i = 0; i < grvMaHang.RowCount; i++)
			//{
			//    int ID = TextUtilsHP.ToInt(dtMahang.Rows[i]["ID"]);
			//    DataRow[] dtr = _dtKnifeDetailList.Select($"GoodsID = {ID}");
			//    DataTable dt = _dtKnifeDetailList.Clone();
			//    DataColumn c1 = new DataColumn("RealValue", typeof(string));
			//    DataColumn c2 = new DataColumn("Result", typeof(string));
			//    dt.Columns.Add(c1);
			//    dt.Columns.Add(c2);
			//    dt.Clear();
			//    foreach (DataRow dr in dtr)
			//    {
			//        dt.ImportRow(dr);
			//    }
			//    dtAll.Merge(dt);
			//}

			//grdToolList.DataSource = dtAll;

			txtToolCode.Focus();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string path = Application.StartupPath + @"\Error";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string content = DateTime.Now.ToString("HH:mm:ss") + "------>" + "Lỗi" + Environment.NewLine;
				string fileName = Application.StartupPath + @"\Error\" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";
				if (!File.Exists(fileName))
				{
					FileStream fs = new FileStream(fileName, FileMode.Create);
					StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
					sWriter.WriteLine(content);
					sWriter.Flush();
					sWriter.Close();
				}
				else
				{
					File.AppendAllText(fileName, content);
				}
			}
			catch (Exception)
			{

			}
		}
		int _rowhandleToolList = -1;
		private void txtToolCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			if (txtToolCode.Text.Trim() == "") return;

			//TODO: Kiểm tra mã dụng cụ có trong bảng hay không
			txtMin.Text = txtMax.Text = txtSTD.Text = txtValue.Text = txtResult.Text = "";
			txtResult.BackColor = Color.White; txtResult.ForeColor = Color.Black;
			int rowHandleToolList = -1;
			string value = "";
			string[] Value = txtToolCode.Text.Trim().Split(',');
			if (Value.Count() >= 2)
			{
				Knife = Value[0] + "," + Value[1] + "," + Value[2];
				for (int i = 0; i < grvToolList.RowCount; i++)
				{
					grvToolList.Focus();
					txtToolCode.Focus();
					value = TextUtilsHP.ToString(grvToolList.GetRowCellValue(i, "Code"));
					//Tách mã dụng cụ đo
					string[] ValueSplit = value.Split(',');
					if (ValueSplit.Length >= 2)
					{
						value = String.Join(",", new string[] { ValueSplit[0], ValueSplit[1], ValueSplit[2] });
					}
					//if (value == txtToolCode.Text.Trim())
					if (value.Trim().ToUpper() == Knife.ToUpper())
					{
						rowHandleToolList = i;
						_rowhandleToolList = i;
						break;
					}

				}
			}
			if (rowHandleToolList == -1)
			{
				MessageBox.Show($"Mã dụng cụ [{txtToolCode.Text.Trim()}] này không tồn tại trong bảng! ", "RTC WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//TODO: Đặt các điều kiện vào ô tương ứng
			txtSTD.Text = TextUtilsHP.ToString(grvToolList.GetRowCellValue(rowHandleToolList, "Std"));
			txtMin.Text = TextUtilsHP.ToString(grvToolList.GetRowCellValue(rowHandleToolList, "Min"));
			txtMax.Text = TextUtilsHP.ToString(grvToolList.GetRowCellValue(rowHandleToolList, "Max"));

			string date = TextUtilsHP.ToString(TextUtilsHP.ExcuteScalar($"SELECT top 1 CreateDate FROM [HypoidPinion].[dbo].[ToolDetailHistory] WHERE Code = N'{value}' Order By ID Desc"));
			if (date.Trim() == "")
			{
				//date = TextUtilsHP.ToString(grvToolList.GetRowCellValue(rowHandleToolList, "DateOld"));
				date = TextUtilsHP.ToString(dtAll.Rows[rowHandleToolList]["DateOld"]);
			}
			int type = TextUtils.ToInt(TextUtilsHP.ToString(dtAll.Rows[rowHandleToolList]["TypeFrequencyCheck"]));
			double ValueFrequency = TextUtils.ToDouble(dtAll.Rows[rowHandleToolList]["ValueFrequency"]);
			//Cộng ngày nhập gần nhất với 
			DateTime dateOld = TextUtilsHP.ToDate(date);
			switch (type)
			{
				case 0:
					dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
					break;
				case 1:
					dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddDays(ValueFrequency).ToString("dd-MM-yyyy"));
					break;
				case 2:
					dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddMonths(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
					break;
				case 3:
					dtpFrequencyCheck.Text = TextUtilsHP.ToString(dateOld.AddYears(TextUtilsHP.ToInt(ValueFrequency)).ToString("dd-MM-yyyy"));
					break;
				default:
					break;
			}
			txtValue.Focus();
			txtValue.SelectAll();
		}

		private void txtCancelCodeProduct_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			if (txtCancelCodeProduct.Text.Trim() == "") return;
			//TODO: Kiểm tra tồn tại mã hàng trong bảng
			int rowHandleMaHang = -1;
			DataTable dt = _dtKnifeDetailList.Clone();
			for (int i = 0; i < grvMaHang.RowCount; i++)
			{
				grvMaHang.Focus();
				txtCancelCodeProduct.Focus();
				string value = TextUtilsHP.ToString(grvMaHang.GetRowCellValue(i, "Mahang"));

				if (value == txtCancelCodeProduct.Text.Trim())
				{
					rowHandleMaHang = i;
					break;
				}
			}
			if (rowHandleMaHang == -1)
			{
				MessageBox.Show($"Mã hàng [{txtCancelCodeProduct.Text.Trim()}] này không tồn tại trong bảng! ", "RTC WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult dlr = MessageBox.Show($"Bạn có muốn xóa mã hàng [{txtCancelCodeProduct.Text.Trim()}] này không ?", "RTC WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dlr == DialogResult.No)
			{
				return;
			}
			//Xóa trong bảng Tool List
			grvMaHang.DeleteRow(rowHandleMaHang);
			loadToollist(0);
		}
		private void loadToollist(int Condition)
		{
			DataView dtvMaHang = (DataView)grvMaHang.DataSource;
			DataTable dtMahang = (DataTable)dtvMaHang.ToTable();
			string sqladd = "select Distinct dbo.GoodsRegister.ToolsID,dbo.Tools.Code,dbo.Tools.NameDisplay,dbo.Tools.Name,dbo.Tools.Min,dbo.Tools.Max,dbo.Tools.Std,dbo.Tools.Type,dbo.Tools.DateOld,dbo.Tools.FrequencyCheck,dbo.Tools.TypeFrequencyCheck,dbo.Tools.ValueFrequency from dbo.Tools left join dbo.GoodsRegister on dbo.Tools.ID = dbo.GoodsRegister.ToolsID where ";
			for (int i = 0; i < dtMahang.Rows.Count; i++)
			{
				int ID = TextUtilsHP.ToInt(dtMahang.Rows[i]["ID"]);
				if (i == 0)
				{
					sqladd += $"GoodsID = {ID}";
				}
				else
				{
					sqladd += $" or GoodsID = {ID}";
				}

			}
			dtAll = TextUtilsHP.Select(sqladd);
			DataView dtvMaDungCu = (DataView)grvToolList.DataSource;
			DataTable dtMaDungCu = (DataTable)dtvMaDungCu.ToTable();
			if (Condition == 1) //Them moi
			{
				for (int i = 0; i < dtAll.Rows.Count; i++)
				{
					string overlap = "";
					string valuedtAll = TextUtilsHP.ToString(dtAll.Rows[i]["Code"]);
					for (int J = 0; J < dtMaDungCu.Rows.Count; J++)
					{

						string valuegrvMahng = TextUtilsHP.ToString(dtMaDungCu.Rows[J]["Code"]);
						if (valuedtAll == valuegrvMahng)
						{
							overlap += "1";
							break;
						}
					}
					if (!overlap.Contains("1"))
					{
						grvToolList.AddNewRow();
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Code"], TextUtilsHP.ToString(dtAll.Rows[i]["Code"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Name"], TextUtilsHP.ToString(dtAll.Rows[i]["Name"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["NameDisplay"], TextUtilsHP.ToString(dtAll.Rows[i]["NameDisplay"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Min"], TextUtilsHP.ToString(dtAll.Rows[i]["Min"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Max"], TextUtilsHP.ToString(dtAll.Rows[i]["Max"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Std"], TextUtilsHP.ToString(dtAll.Rows[i]["Std"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Type"], TextUtilsHP.ToString(dtAll.Rows[i]["Type"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["ID"], TextUtilsHP.ToString(dtAll.Rows[i]["ToolsID"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["GoodID"], GoodsID);
					}

				}
			}
			else //Xoa
			{
				for (int i = 0; i < dtMaDungCu.Rows.Count; i++)
				{
					string overlap = "";
					string valuegrvMahng = TextUtilsHP.ToString(dtMaDungCu.Rows[i]["Code"]);
					for (int j = 0; j < dtAll.Rows.Count; j++)
					{
						string valuedtAll = TextUtilsHP.ToString(dtAll.Rows[j]["Code"]);

						if (valuedtAll == valuegrvMahng)
						{
							overlap += "1";
						}
						else
						{
							grvToolList.FocusedRowHandle = i;
						}

					}
					if (!overlap.Contains("1"))
					{

						grvToolList.DeleteSelectedRows();
					}
				}
			}
		}
		private void txtValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			if (txtValue.Text.Trim() == "") return;
			grvToolList.SetRowCellValue(_rowhandleToolList, "RealValue", txtValue.Text.Trim());
			decimal value = TextUtilsHP.ToDecimal(txtValue.Text.Trim());
			decimal min = TextUtilsHP.ToDecimal(txtMin.Text.Trim());
			decimal max = TextUtilsHP.ToDecimal(txtMax.Text.Trim());
			decimal std = TextUtilsHP.ToDecimal(txtSTD.Text.Trim());
			string result = "";
			//TODO: So sánh giá trị với điều kiện
			if (value >= min && value <= max) result = "OK";
			else result = "NG";
			txtResult.Text = result;
			switch (txtResult.Text.Trim())
			{
				case "OK":
					{
						txtResult.BackColor = Color.Lime;
						txtResult.ForeColor = Color.Black;
						break;
					}
				case "NG":
					{
						txtResult.BackColor = Color.Red;
						txtResult.ForeColor = Color.White;
						break;
					}
				default:
					{
						txtResult.BackColor = Color.White;
						txtResult.ForeColor = Color.Black;
						break;
					}

			}
			grvToolList.SetRowCellValue(_rowhandleToolList, "Result", result);
			txtToolCode.Focus();
			txtToolCode.SelectAll();
			Reset();
		}

		private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			//if (!Char.IsDigit(e.KeyChar != '.') && !Char.IsControl(e.KeyChar))
			if (e.KeyChar != '.' && !Char.IsControl(e.KeyChar) && Char.IsLetter(e.KeyChar))
				e.Handled = true;
		}

		private void txtResult_Click(object sender, EventArgs e)
		{


		}

		private void grvToolList_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if (e.Column == colResult)
			{
				string StatusColor = TextUtilsHP.ToString(grvToolList.GetRowCellValue(e.RowHandle, colResult));
				if (StatusColor == "NG")
				{
					e.Appearance.BackColor = Color.Red;
				}
				else if (StatusColor == "OK")
				{
					e.Appearance.BackColor = Color.Lime;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (grvToolList.RowCount == 0) return;
				//int GoodsID = TextUtilsHP.ToInt(grvToolList.GetRowCellValue(0,colGoodsID));
				ToolDetailModel toolDetailModel = new ToolDetailModel();
				toolDetailModel.WorkerName = txtChecker.Text.Trim();
				toolDetailModel.PartCode = cboPart.Text.Trim();
				toolDetailModel.CreateDate = DateTime.Now;
				decimal ID = ToolDetailBO.Instance.Insert(toolDetailModel);
				for (int i = 0; i < grvToolList.RowCount; i++)
				{
					string Checker = txtChecker.Text.Trim();
					double Min = TextUtilsHP.ToDouble(grvToolList.GetRowCellValue(i, colMin));
					double Max = TextUtilsHP.ToDouble(grvToolList.GetRowCellValue(i, colMax));
					double Std = TextUtilsHP.ToDouble(grvToolList.GetRowCellValue(i, colSTD));
					string Code = TextUtilsHP.ToString(grvToolList.GetRowCellValue(i, colCodeTool));
					int ToolID = TextUtilsHP.ToInt(grvToolList.GetRowCellValue(i, colIDTool));
					double Value = TextUtilsHP.ToDouble(grvToolList.GetRowCellValue(i, colRealValue));
					string Result = TextUtilsHP.ToString(grvToolList.GetRowCellValue(i, colResult));
					string GoodID = TextUtilsHP.ToString(grvToolList.GetRowCellValue(i, colGoodID));
					string CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					string sql = $"insert into dbo.ToolDetailHistory(Checker,Min,Max,Std,Code,ToolID,Value,Result,CreateDate,ToolDetailID,GoodID) " +
						$" Values(N'{txtChecker.Text.Trim()}'," +
							  $"  {Min}," +
							  $"  {Max}," +
							  $"  {Std}," +
							  $"  '{Code}'," +
							  $"  {ToolID}," +
							  $"  {Value}," +
							  $" '{Result}'," +
							  $" '{CreateDate}'," +
							  $" '{ID}'," +
							  $" '{GoodID}')";
					TextUtilsHP.ExcuteSQL(sql);
				}
				MessageBox.Show("Lưu thành công!");
				Reset();
			}
			catch (Exception)
			{
				throw;
			}
		}
		void Reset()
		{
			txtAddCodeProduct.Text = "";
			txtToolCode.Text = "";
			txtCancelCodeProduct.Text = "";
			dtpFrequencyCheck.Text = "";
			txtSTD.Text = "";
			txtMin.Text = "";
			txtMax.Text = "";
			txtValue.Text = "";
			txtResult.Text = "";
		}

		private void txtChecker_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtChecker.Text.Trim()))
			{
				txtChecker.BackColor = Color.Plum;
			}
			else
			{
				txtChecker.BackColor = Color.White;
			}
		}

		private void txtAddCodeProduct_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtAddCodeProduct.Text.Trim()))
			{
				txtAddCodeProduct.BackColor = Color.Plum;
			}
			else
			{
				txtAddCodeProduct.BackColor = Color.White;
			}
		}

		private void txtCancelCodeProduct_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtCancelCodeProduct.Text.Trim()))
			{
				txtCancelCodeProduct.BackColor = Color.Plum;
			}
			else
			{
				txtCancelCodeProduct.BackColor = Color.White;
			}
		}

		private void txtToolCode_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtToolCode.Text.Trim()))
			{
				txtToolCode.BackColor = Color.Plum;
			}
			else
			{
				txtToolCode.BackColor = Color.White;
			}
		}

		private void txtValue_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtValue.Text.Trim()))
			{
				txtValue.BackColor = Color.Plum;
			}
			else
			{
				txtValue.BackColor = Color.White;
			}
		}

		private void txtChecker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;
			cboPart.Focus();
		}

		private void cboPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboPart.SelectedIndex == 0) return;
			//Xóa tất cả dòng trong 2 gridview
			for (int i = grvMaHang.RowCount; grvMaHang.RowCount > 0; i--)
			{
				grvMaHang.DeleteRow(i);
			}
			for (int i = grvToolList.RowCount; grvToolList.RowCount > 0; i--)
			{
				grvToolList.DeleteRow(i);
			}
			DataSet ds = TextUtilsHP.GetListDataFromSP("spGetHistoryTool", new string[] { "@PartCode" }, new object[] { cboPart.Text.Trim() });
			DataTable dtGood = ds.Tables[0];
			DataTable dtTool = ds.Tables[1];
			//Hiển thị ngày kiểm tra tiếp theo
			string sqladd = "select Distinct dbo.GoodsRegister.ToolsID,dbo.Tools.Code,dbo.Tools.NameDisplay,dbo.Tools.Name,dbo.Tools.Min,dbo.Tools.Max,dbo.Tools.Std,dbo.Tools.Type,dbo.Tools.DateOld,dbo.Tools.FrequencyCheck,dbo.Tools.TypeFrequencyCheck,dbo.Tools.ValueFrequency from dbo.Tools left join dbo.GoodsRegister on dbo.Tools.ID = dbo.GoodsRegister.ToolsID where ";
			for (int i = 0; i < dtGood.Rows.Count; i++)
			{
				int ID = TextUtilsHP.ToInt(dtGood.Rows[i]["ID"]);
				if (i == 0)
				{
					sqladd += $"GoodsID = {ID}";
				}
				else
				{
					sqladd += $" or GoodsID = {ID}";
				}

			}
			dtAll = TextUtilsHP.Select(sqladd);

			if (dtGood == null) return;
			for (int i = 0; i < dtGood.Rows.Count; i++)
			{
				grvMaHang.AddNewRow();
				grvMaHang.SetRowCellValue(GridControl.NewItemRowHandle, grvMaHang.Columns["Mahang"], TextUtilsHP.ToString(dtGood.Rows[i]["Code"]));
			}
			if (dtTool == null) return;
			for (int i = 0; i < dtTool.Rows.Count; i++)
			{
				grvToolList.AddNewRow();
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Code"], TextUtilsHP.ToString(dtTool.Rows[i]["Code"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Name"], TextUtilsHP.ToString(dtTool.Rows[i]["Name"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["NameDisplay"], TextUtilsHP.ToString(dtTool.Rows[i]["NameDisplay"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Min"], TextUtilsHP.ToString(dtTool.Rows[i]["Min"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Max"], TextUtilsHP.ToString(dtTool.Rows[i]["Max"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Std"], TextUtilsHP.ToString(dtTool.Rows[i]["Std"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Type"], TextUtilsHP.ToString(dtTool.Rows[i]["Type"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["ID"], TextUtilsHP.ToString(dtTool.Rows[i]["ToolID"]));
				grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["GoodID"], TextUtilsHP.ToString(dtTool.Rows[i]["GoodID"]));
				if (TextUtilsHP.ToDate2(dtTool.Rows[i]["CreateDate"]) < _dateTimeEnd1 && _dateTimeStart1 < TextUtilsHP.ToDate2(dtTool.Rows[i]["CreateDate"]))
				{
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["RealValue"], TextUtilsHP.ToString(dtTool.Rows[i]["Value"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Result"], TextUtilsHP.ToString(dtTool.Rows[i]["Result"]));
				}
				else
				{
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["RealValue"], "");
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Result"], "");
				}
			}
			txtAddCodeProduct.Focus();
		}

		private void cboPart_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cboPart.Text.Trim()))
			{
				cboPart.BackColor = Color.Plum;
			}
			else
			{
				cboPart.BackColor = Color.White;
			}
		}

		private void cboPart_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtAddCodeProduct.Focus();
				//Xóa tất cả dòng trong 2 gridview
				for (int i = grvMaHang.RowCount; grvMaHang.RowCount > 0; i--)
				{
					grvMaHang.DeleteRow(i);
				}
				for (int i = grvToolList.RowCount; grvToolList.RowCount > 0; i--)
				{
					grvToolList.DeleteRow(i);
				}
				DataSet ds = TextUtilsHP.GetListDataFromSP("spGetHistoryTool", new string[] { "@PartCode" }, new object[] { cboPart.Text.Trim() });
				DataTable dtGood = ds.Tables[0];
				DataTable dtTool = ds.Tables[1];
				if (dtGood == null) return;
				for (int i = 0; i < dtGood.Rows.Count; i++)
				{
					grvMaHang.AddNewRow();
					grvMaHang.SetRowCellValue(GridControl.NewItemRowHandle, grvMaHang.Columns["Mahang"], TextUtilsHP.ToString(dtGood.Rows[i]["Code"]));
				}
				if (dtTool == null) return;
				for (int i = 0; i < dtTool.Rows.Count; i++)
				{
					grvToolList.AddNewRow();
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Code"], TextUtilsHP.ToString(dtTool.Rows[i]["Code"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Name"], TextUtilsHP.ToString(dtTool.Rows[i]["Name"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["NameDisplay"], TextUtilsHP.ToString(dtTool.Rows[i]["NameDisplay"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Min"], TextUtilsHP.ToString(dtTool.Rows[i]["Min"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Max"], TextUtilsHP.ToString(dtTool.Rows[i]["Max"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Std"], TextUtilsHP.ToString(dtTool.Rows[i]["Std"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Type"], TextUtilsHP.ToString(dtTool.Rows[i]["Type"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["ID"], TextUtilsHP.ToString(dtTool.Rows[i]["ToolID"]));
					grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["GoodID"], TextUtilsHP.ToString(dtTool.Rows[i]["GoodID"]));
					if (TextUtilsHP.ToDate2(dtTool.Rows[i]["CreateDate"]) < _dateTimeEnd1 && _dateTimeStart1 < TextUtilsHP.ToDate2(dtTool.Rows[i]["CreateDate"]))
					{
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["RealValue"], TextUtilsHP.ToString(dtTool.Rows[i]["Value"]));
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Result"], TextUtilsHP.ToString(dtTool.Rows[i]["Result"]));
					}
					else
					{
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["RealValue"], "");
						grvToolList.SetRowCellValue(GridControl.NewItemRowHandle, grvToolList.Columns["Result"], "");
					}
				}

			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{

		}
	}
}
