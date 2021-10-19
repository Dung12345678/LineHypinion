
namespace BMS
{
    partial class frmHypMeasuringTools
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHypMeasuringTools));
			this.btnSave = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtChecker = new System.Windows.Forms.TextBox();
			this.txtAddCodeProduct = new System.Windows.Forms.TextBox();
			this.txtCancelCodeProduct = new System.Windows.Forms.TextBox();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.txtSTD = new System.Windows.Forms.TextBox();
			this.txtToolCode = new System.Windows.Forms.TextBox();
			this.txtMax = new System.Windows.Forms.TextBox();
			this.txtMin = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.grdMaHang = new DevExpress.XtraGrid.GridControl();
			this.grvMaHang = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grdToolList = new DevExpress.XtraGrid.GridControl();
			this.grvToolList = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.B = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colCodeTool = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colNameToolDisplay = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colRealValue = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colResult = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colIDTool = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colNameTool = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colSTD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colMin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colMax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colGoodsID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colValueFrequency = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colTypeFrequencyCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colFrequencyCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colDateOld = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colGoodID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrequencyCheck = new System.Windows.Forms.TextBox();
			this.cboPart = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMaHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvMaHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdToolList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvToolList)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.SlateGray;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.Location = new System.Drawing.Point(1008, 742);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(114, 29);
			this.btnSave.TabIndex = 34;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.BackColor = System.Drawing.Color.SlateGray;
			this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReset.Location = new System.Drawing.Point(12, 742);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(114, 29);
			this.btnReset.TabIndex = 33;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtChecker
			// 
			this.txtChecker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtChecker.BackColor = System.Drawing.Color.Plum;
			this.tableLayoutPanel1.SetColumnSpan(this.txtChecker, 2);
			this.txtChecker.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtChecker.Location = new System.Drawing.Point(227, 1);
			this.txtChecker.Margin = new System.Windows.Forms.Padding(1);
			this.txtChecker.Name = "txtChecker";
			this.txtChecker.Size = new System.Drawing.Size(450, 43);
			this.txtChecker.TabIndex = 0;
			this.txtChecker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtChecker.TextChanged += new System.EventHandler(this.txtChecker_TextChanged);
			this.txtChecker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChecker_KeyDown);
			// 
			// txtAddCodeProduct
			// 
			this.txtAddCodeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddCodeProduct.BackColor = System.Drawing.Color.Plum;
			this.tableLayoutPanel1.SetColumnSpan(this.txtAddCodeProduct, 2);
			this.txtAddCodeProduct.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtAddCodeProduct.Location = new System.Drawing.Point(227, 45);
			this.txtAddCodeProduct.Margin = new System.Windows.Forms.Padding(1);
			this.txtAddCodeProduct.Name = "txtAddCodeProduct";
			this.txtAddCodeProduct.Size = new System.Drawing.Size(450, 43);
			this.txtAddCodeProduct.TabIndex = 1;
			this.txtAddCodeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAddCodeProduct.TextChanged += new System.EventHandler(this.txtAddCodeProduct_TextChanged);
			this.txtAddCodeProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddCodeProduct_KeyDown);
			// 
			// txtCancelCodeProduct
			// 
			this.txtCancelCodeProduct.BackColor = System.Drawing.Color.Plum;
			this.txtCancelCodeProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCancelCodeProduct.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCancelCodeProduct.Location = new System.Drawing.Point(905, 45);
			this.txtCancelCodeProduct.Margin = new System.Windows.Forms.Padding(1);
			this.txtCancelCodeProduct.Name = "txtCancelCodeProduct";
			this.txtCancelCodeProduct.Size = new System.Drawing.Size(228, 43);
			this.txtCancelCodeProduct.TabIndex = 2;
			this.txtCancelCodeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCancelCodeProduct.TextChanged += new System.EventHandler(this.txtCancelCodeProduct_TextChanged);
			this.txtCancelCodeProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCancelCodeProduct_KeyDown);
			// 
			// txtValue
			// 
			this.txtValue.BackColor = System.Drawing.Color.Plum;
			this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtValue.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtValue.Location = new System.Drawing.Point(679, 177);
			this.txtValue.Margin = new System.Windows.Forms.Padding(1);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(224, 43);
			this.txtValue.TabIndex = 1;
			this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
			this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
			this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
			// 
			// txtResult
			// 
			this.txtResult.BackColor = System.Drawing.Color.White;
			this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResult.Enabled = false;
			this.txtResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtResult.ForeColor = System.Drawing.Color.White;
			this.txtResult.Location = new System.Drawing.Point(905, 177);
			this.txtResult.Margin = new System.Windows.Forms.Padding(1);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(228, 43);
			this.txtResult.TabIndex = 30;
			this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResult.Click += new System.EventHandler(this.txtResult_Click);
			// 
			// txtSTD
			// 
			this.txtSTD.BackColor = System.Drawing.Color.White;
			this.txtSTD.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSTD.Enabled = false;
			this.txtSTD.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtSTD.Location = new System.Drawing.Point(1, 177);
			this.txtSTD.Margin = new System.Windows.Forms.Padding(1);
			this.txtSTD.Name = "txtSTD";
			this.txtSTD.Size = new System.Drawing.Size(224, 43);
			this.txtSTD.TabIndex = 2;
			this.txtSTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtToolCode
			// 
			this.txtToolCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtToolCode.BackColor = System.Drawing.Color.Plum;
			this.tableLayoutPanel1.SetColumnSpan(this.txtToolCode, 2);
			this.txtToolCode.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtToolCode.Location = new System.Drawing.Point(227, 89);
			this.txtToolCode.Margin = new System.Windows.Forms.Padding(1);
			this.txtToolCode.Name = "txtToolCode";
			this.txtToolCode.Size = new System.Drawing.Size(450, 43);
			this.txtToolCode.TabIndex = 0;
			this.txtToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtToolCode.TextChanged += new System.EventHandler(this.txtToolCode_TextChanged);
			this.txtToolCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToolCode_KeyDown);
			// 
			// txtMax
			// 
			this.txtMax.BackColor = System.Drawing.Color.White;
			this.txtMax.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMax.Enabled = false;
			this.txtMax.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtMax.Location = new System.Drawing.Point(453, 177);
			this.txtMax.Margin = new System.Windows.Forms.Padding(1);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(224, 43);
			this.txtMax.TabIndex = 4;
			this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			this.txtMin.BackColor = System.Drawing.Color.White;
			this.txtMin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMin.Enabled = false;
			this.txtMin.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.txtMin.Location = new System.Drawing.Point(227, 177);
			this.txtMin.Margin = new System.Windows.Forms.Padding(1);
			this.txtMin.Name = "txtMin";
			this.txtMin.Size = new System.Drawing.Size(224, 43);
			this.txtMin.TabIndex = 3;
			this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.tableLayoutPanel2);
			this.panel2.Location = new System.Drawing.Point(0, 224);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1134, 512);
			this.panel2.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.68085F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.31915F));
			this.tableLayoutPanel2.Controls.Add(this.grdMaHang, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.grdToolList, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1134, 512);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// grdMaHang
			// 
			this.grdMaHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdMaHang.Location = new System.Drawing.Point(3, 3);
			this.grdMaHang.MainView = this.grvMaHang;
			this.grdMaHang.Name = "grdMaHang";
			this.grdMaHang.Size = new System.Drawing.Size(217, 506);
			this.grdMaHang.TabIndex = 0;
			this.grdMaHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMaHang});
			// 
			// grvMaHang
			// 
			this.grvMaHang.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumBlue;
			this.grvMaHang.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.grvMaHang.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grvMaHang.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grvMaHang.ColumnPanelRowHeight = 60;
			this.grvMaHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHang,
            this.colID});
			this.grvMaHang.GridControl = this.grdMaHang;
			this.grvMaHang.Name = "grvMaHang";
			this.grvMaHang.OptionsView.ShowGroupPanel = false;
			this.grvMaHang.OptionsView.ShowIndicator = false;
			this.grvMaHang.RowHeight = 20;
			// 
			// colMaHang
			// 
			this.colMaHang.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
			this.colMaHang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colMaHang.AppearanceCell.Options.UseBackColor = true;
			this.colMaHang.AppearanceCell.Options.UseFont = true;
			this.colMaHang.AppearanceCell.Options.UseTextOptions = true;
			this.colMaHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMaHang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMaHang.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colMaHang.AppearanceHeader.BackColor2 = System.Drawing.Color.Transparent;
			this.colMaHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colMaHang.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colMaHang.AppearanceHeader.Options.UseBackColor = true;
			this.colMaHang.AppearanceHeader.Options.UseFont = true;
			this.colMaHang.AppearanceHeader.Options.UseForeColor = true;
			this.colMaHang.AppearanceHeader.Options.UseTextOptions = true;
			this.colMaHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colMaHang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colMaHang.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colMaHang.Caption = "MÃ HÀNG";
			this.colMaHang.FieldName = "Mahang";
			this.colMaHang.Name = "colMaHang";
			this.colMaHang.OptionsColumn.AllowEdit = false;
			this.colMaHang.Visible = true;
			this.colMaHang.VisibleIndex = 0;
			// 
			// colID
			// 
			this.colID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colID.AppearanceHeader.Options.UseBackColor = true;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			// 
			// grdToolList
			// 
			this.grdToolList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdToolList.Location = new System.Drawing.Point(226, 3);
			this.grdToolList.MainView = this.grvToolList;
			this.grdToolList.Name = "grdToolList";
			this.grdToolList.Size = new System.Drawing.Size(905, 506);
			this.grdToolList.TabIndex = 1;
			this.grdToolList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvToolList});
			// 
			// grvToolList
			// 
			this.grvToolList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumBlue;
			this.grvToolList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.grvToolList.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grvToolList.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grvToolList.BandPanelRowHeight = 30;
			this.grvToolList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.B});
			this.grvToolList.ColumnPanelRowHeight = 30;
			this.grvToolList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colCodeTool,
            this.colNameToolDisplay,
            this.colRealValue,
            this.colResult,
            this.colIDTool,
            this.colNameTool,
            this.colSTD,
            this.colMin,
            this.colMax,
            this.colType,
            this.colGoodsID,
            this.colValueFrequency,
            this.colTypeFrequencyCheck,
            this.colFrequencyCheck,
            this.colDateOld,
            this.colGoodID});
			this.grvToolList.GridControl = this.grdToolList;
			this.grvToolList.Name = "grvToolList";
			this.grvToolList.OptionsView.ShowGroupPanel = false;
			this.grvToolList.OptionsView.ShowIndicator = false;
			this.grvToolList.RowHeight = 20;
			this.grvToolList.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.grvToolList_CustomDrawCell);
			// 
			// B
			// 
			this.B.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.B.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B.AppearanceHeader.Options.UseBackColor = true;
			this.B.AppearanceHeader.Options.UseFont = true;
			this.B.AppearanceHeader.Options.UseTextOptions = true;
			this.B.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.B.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.B.Caption = "DANH SÁCH DỤNG CỤ CẦN KIỂM TRA";
			this.B.Columns.Add(this.colCodeTool);
			this.B.Columns.Add(this.colNameToolDisplay);
			this.B.Columns.Add(this.colRealValue);
			this.B.Columns.Add(this.colResult);
			this.B.Name = "B";
			this.B.VisibleIndex = 0;
			this.B.Width = 300;
			// 
			// colCodeTool
			// 
			this.colCodeTool.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
			this.colCodeTool.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colCodeTool.AppearanceCell.Options.UseBackColor = true;
			this.colCodeTool.AppearanceCell.Options.UseFont = true;
			this.colCodeTool.AppearanceCell.Options.UseTextOptions = true;
			this.colCodeTool.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCodeTool.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCodeTool.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colCodeTool.AppearanceHeader.BackColor2 = System.Drawing.Color.Transparent;
			this.colCodeTool.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colCodeTool.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colCodeTool.AppearanceHeader.Options.UseBackColor = true;
			this.colCodeTool.AppearanceHeader.Options.UseFont = true;
			this.colCodeTool.AppearanceHeader.Options.UseForeColor = true;
			this.colCodeTool.AppearanceHeader.Options.UseTextOptions = true;
			this.colCodeTool.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCodeTool.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colCodeTool.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colCodeTool.Caption = "MÃ DỤNG CỤ";
			this.colCodeTool.FieldName = "Code";
			this.colCodeTool.Name = "colCodeTool";
			this.colCodeTool.OptionsColumn.ReadOnly = true;
			this.colCodeTool.Visible = true;
			// 
			// colNameToolDisplay
			// 
			this.colNameToolDisplay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colNameToolDisplay.AppearanceCell.Options.UseFont = true;
			this.colNameToolDisplay.AppearanceCell.Options.UseTextOptions = true;
			this.colNameToolDisplay.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNameToolDisplay.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colNameToolDisplay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.colNameToolDisplay.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colNameToolDisplay.AppearanceHeader.Options.UseBackColor = true;
			this.colNameToolDisplay.AppearanceHeader.Options.UseFont = true;
			this.colNameToolDisplay.AppearanceHeader.Options.UseForeColor = true;
			this.colNameToolDisplay.AppearanceHeader.Options.UseTextOptions = true;
			this.colNameToolDisplay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNameToolDisplay.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colNameToolDisplay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
			this.colNameToolDisplay.Caption = "TÊN DỤNG CỤ";
			this.colNameToolDisplay.FieldName = "NameDisplay";
			this.colNameToolDisplay.Name = "colNameToolDisplay";
			this.colNameToolDisplay.OptionsColumn.ReadOnly = true;
			this.colNameToolDisplay.Visible = true;
			// 
			// colRealValue
			// 
			this.colRealValue.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colRealValue.AppearanceCell.Options.UseFont = true;
			this.colRealValue.AppearanceCell.Options.UseTextOptions = true;
			this.colRealValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colRealValue.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.colRealValue.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colRealValue.AppearanceHeader.Options.UseBackColor = true;
			this.colRealValue.AppearanceHeader.Options.UseFont = true;
			this.colRealValue.AppearanceHeader.Options.UseForeColor = true;
			this.colRealValue.AppearanceHeader.Options.UseTextOptions = true;
			this.colRealValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colRealValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colRealValue.Caption = "KẾT QUẢ";
			this.colRealValue.FieldName = "RealValue";
			this.colRealValue.Name = "colRealValue";
			this.colRealValue.OptionsColumn.ReadOnly = true;
			this.colRealValue.Visible = true;
			// 
			// colResult
			// 
			this.colResult.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.colResult.AppearanceCell.Options.UseFont = true;
			this.colResult.AppearanceCell.Options.UseTextOptions = true;
			this.colResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colResult.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colResult.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colResult.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
			this.colResult.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
			this.colResult.AppearanceHeader.Options.UseBackColor = true;
			this.colResult.AppearanceHeader.Options.UseFont = true;
			this.colResult.AppearanceHeader.Options.UseForeColor = true;
			this.colResult.AppearanceHeader.Options.UseTextOptions = true;
			this.colResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colResult.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
			this.colResult.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colResult.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colResult.Caption = "ĐÁNH GIÁ";
			this.colResult.FieldName = "Result";
			this.colResult.Name = "colResult";
			this.colResult.OptionsColumn.ReadOnly = true;
			this.colResult.Visible = true;
			// 
			// colIDTool
			// 
			this.colIDTool.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colIDTool.AppearanceHeader.Options.UseBackColor = true;
			this.colIDTool.Caption = "ID mÃ DỤNG CỤ";
			this.colIDTool.FieldName = "ID";
			this.colIDTool.Name = "colIDTool";
			this.colIDTool.OptionsColumn.ReadOnly = true;
			// 
			// colNameTool
			// 
			this.colNameTool.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colNameTool.AppearanceHeader.Options.UseBackColor = true;
			this.colNameTool.Caption = "Name";
			this.colNameTool.FieldName = "Name";
			this.colNameTool.Name = "colNameTool";
			this.colNameTool.OptionsColumn.ReadOnly = true;
			// 
			// colSTD
			// 
			this.colSTD.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colSTD.AppearanceHeader.Options.UseBackColor = true;
			this.colSTD.Caption = "STD";
			this.colSTD.FieldName = "Std";
			this.colSTD.Name = "colSTD";
			this.colSTD.OptionsColumn.ReadOnly = true;
			// 
			// colMin
			// 
			this.colMin.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colMin.AppearanceHeader.Options.UseBackColor = true;
			this.colMin.Caption = "Min";
			this.colMin.FieldName = "Min";
			this.colMin.Name = "colMin";
			this.colMin.OptionsColumn.ReadOnly = true;
			// 
			// colMax
			// 
			this.colMax.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colMax.AppearanceHeader.Options.UseBackColor = true;
			this.colMax.Caption = "Max";
			this.colMax.FieldName = "Max";
			this.colMax.Name = "colMax";
			this.colMax.OptionsColumn.ReadOnly = true;
			// 
			// colType
			// 
			this.colType.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colType.AppearanceHeader.Options.UseBackColor = true;
			this.colType.Caption = "Type";
			this.colType.FieldName = "Type";
			this.colType.Name = "colType";
			this.colType.OptionsColumn.ReadOnly = true;
			// 
			// colGoodsID
			// 
			this.colGoodsID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.colGoodsID.AppearanceHeader.Options.UseBackColor = true;
			this.colGoodsID.Caption = "ID ma hang";
			this.colGoodsID.FieldName = "GoodsID";
			this.colGoodsID.Name = "colGoodsID";
			this.colGoodsID.OptionsColumn.ReadOnly = true;
			// 
			// colValueFrequency
			// 
			this.colValueFrequency.Caption = "Giá trị add ";
			this.colValueFrequency.FieldName = "ValueFrequency";
			this.colValueFrequency.Name = "colValueFrequency";
			this.colValueFrequency.OptionsColumn.ReadOnly = true;
			// 
			// colTypeFrequencyCheck
			// 
			this.colTypeFrequencyCheck.Caption = "Type Frequency Check ";
			this.colTypeFrequencyCheck.FieldName = "TypeFrequencyCheck";
			this.colTypeFrequencyCheck.Name = "colTypeFrequencyCheck";
			this.colTypeFrequencyCheck.OptionsColumn.ReadOnly = true;
			// 
			// colFrequencyCheck
			// 
			this.colFrequencyCheck.Caption = "Ngày kiểm tra tiếp";
			this.colFrequencyCheck.FieldName = "FrequencyCheck";
			this.colFrequencyCheck.Name = "colFrequencyCheck";
			this.colFrequencyCheck.OptionsColumn.ReadOnly = true;
			// 
			// colDateOld
			// 
			this.colDateOld.Caption = "Ngày khởi tạo";
			this.colDateOld.FieldName = "DateOld";
			this.colDateOld.Name = "colDateOld";
			this.colDateOld.OptionsColumn.ReadOnly = true;
			// 
			// colGoodID
			// 
			this.colGoodID.Caption = "GoodID";
			this.colGoodID.FieldName = "GoodID";
			this.colGoodID.Name = "colGoodID";
			this.colGoodID.OptionsColumn.ReadOnly = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label10, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label11, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.label12, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.dtpFrequencyCheck, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.cboPart, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtResult, 4, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtValue, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.label2, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtChecker, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtAddCodeProduct, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtMax, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtSTD, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtCancelCodeProduct, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtToolCode, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtMin, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 223);
			this.tableLayoutPanel1.TabIndex = 35;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MediumBlue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(1, 1);
			this.label6.Margin = new System.Windows.Forms.Padding(1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(224, 42);
			this.label6.TabIndex = 39;
			this.label6.Text = "NGƯỜI KIỂM TRA";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.MediumBlue;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(1, 45);
			this.label7.Margin = new System.Windows.Forms.Padding(1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(224, 42);
			this.label7.TabIndex = 40;
			this.label7.Text = "THÊM MÃ HÀNG";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.MediumBlue;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(1, 89);
			this.label8.Margin = new System.Windows.Forms.Padding(1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(224, 42);
			this.label8.TabIndex = 41;
			this.label8.Text = "MÃ DỤNG CỤ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.MediumBlue;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Location = new System.Drawing.Point(1, 133);
			this.label9.Margin = new System.Windows.Forms.Padding(1);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(224, 42);
			this.label9.TabIndex = 42;
			this.label9.Text = "STD";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.MediumBlue;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(227, 133);
			this.label10.Margin = new System.Windows.Forms.Padding(1);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(224, 42);
			this.label10.TabIndex = 43;
			this.label10.Text = "MIN";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.MediumBlue;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new System.Drawing.Point(453, 133);
			this.label11.Margin = new System.Windows.Forms.Padding(1);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(224, 42);
			this.label11.TabIndex = 44;
			this.label11.Text = "MAX";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.MediumBlue;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label12.Location = new System.Drawing.Point(679, 133);
			this.label12.Margin = new System.Windows.Forms.Padding(1);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(224, 42);
			this.label12.TabIndex = 45;
			this.label12.Text = "KẾT QUẢ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.MediumBlue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(679, 1);
			this.label4.Margin = new System.Windows.Forms.Padding(1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 42);
			this.label4.TabIndex = 38;
			this.label4.Text = "BỘ PHẬN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.MediumBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(679, 45);
			this.label3.Margin = new System.Windows.Forms.Padding(1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 42);
			this.label3.TabIndex = 38;
			this.label3.Text = "HỦY MÃ HÀNG";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MediumBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(679, 89);
			this.label1.Margin = new System.Windows.Forms.Padding(1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 42);
			this.label1.TabIndex = 36;
			this.label1.Text = "THỜI GIAN KIỂM TRA TIẾP THEO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFrequencyCheck
			// 
			this.dtpFrequencyCheck.BackColor = System.Drawing.Color.Plum;
			this.dtpFrequencyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtpFrequencyCheck.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFrequencyCheck.Location = new System.Drawing.Point(905, 89);
			this.dtpFrequencyCheck.Margin = new System.Windows.Forms.Padding(1);
			this.dtpFrequencyCheck.Name = "dtpFrequencyCheck";
			this.dtpFrequencyCheck.Size = new System.Drawing.Size(228, 43);
			this.dtpFrequencyCheck.TabIndex = 37;
			this.dtpFrequencyCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cboPart
			// 
			this.cboPart.BackColor = System.Drawing.Color.Plum;
			this.cboPart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboPart.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
			this.cboPart.FormattingEnabled = true;
			this.cboPart.Location = new System.Drawing.Point(905, 1);
			this.cboPart.Margin = new System.Windows.Forms.Padding(1);
			this.cboPart.Name = "cboPart";
			this.cboPart.Size = new System.Drawing.Size(228, 44);
			this.cboPart.TabIndex = 36;
			this.cboPart.SelectedIndexChanged += new System.EventHandler(this.cboPart_SelectedIndexChanged);
			this.cboPart.TextChanged += new System.EventHandler(this.cboPart_TextChanged);
			this.cboPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPart_KeyDown);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.MediumBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(905, 133);
			this.label2.Margin = new System.Windows.Forms.Padding(1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 42);
			this.label2.TabIndex = 37;
			this.label2.Text = "ĐÁNH GIÁ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmHypMeasuringTools
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1134, 782);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnReset);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmHypMeasuringTools";
			this.Text = "DƯỠNG THƯỚC HÀNG NGÀY";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmHypMeasuringTools_Load);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdMaHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvMaHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdToolList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvToolList)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCancelCodeProduct;
        private System.Windows.Forms.TextBox txtToolCode;
        private System.Windows.Forms.TextBox txtAddCodeProduct;
        private System.Windows.Forms.TextBox txtChecker;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtSTD;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grdMaHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.GridControl grdToolList;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView grvToolList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand B;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCodeTool;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNameToolDisplay;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRealValue;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDTool;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNameTool;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSTD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colType;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGoodsID;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cboPart;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox dtpFrequencyCheck;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colValueFrequency;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTypeFrequencyCheck;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFrequencyCheck;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDateOld;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGoodID;
	}
}