namespace BMS
{
	partial class frmConfigFormulaAllH
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
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
			DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigFormulaAllH));
			this.grdData = new DevExpress.XtraGrid.GridControl();
			this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.mnuMenu = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
			this.mnuMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// grdData
			// 
			this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdData.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdData.Location = new System.Drawing.Point(0, 45);
			this.grdData.MainView = this.grvData;
			this.grdData.Name = "grdData";
			this.grdData.Size = new System.Drawing.Size(838, 464);
			this.grdData.TabIndex = 34;
			this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
			// 
			// grvData
			// 
			this.grvData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.FocusedRow.Options.UseBackColor = true;
			this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.grvData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.HideSelectionRow.Options.UseBackColor = true;
			this.grvData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grvData.Appearance.SelectedRow.Options.UseBackColor = true;
			this.grvData.ColumnPanelRowHeight = 60;
			this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProductGroupID,
            this.colProductID,
            this.colProductGroupCode,
            this.colProductTypeCode,
            this.colFormula,
            this.colSTT});
			this.grvData.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
			this.grvData.GridControl = this.grdData;
			this.grvData.GroupCount = 2;
			this.grvData.HorzScrollStep = 5;
			this.grvData.Name = "grvData";
			this.grvData.OptionsBehavior.AutoExpandAllGroups = true;
			this.grvData.OptionsCustomization.AllowRowSizing = true;
			this.grvData.OptionsFind.AlwaysVisible = true;
			this.grvData.OptionsFind.ShowCloseButton = false;
			this.grvData.OptionsSelection.MultiSelect = true;
			this.grvData.OptionsView.ColumnAutoWidth = false;
			this.grvData.OptionsView.RowAutoHeight = true;
			this.grvData.OptionsView.ShowAutoFilterRow = true;
			this.grvData.OptionsView.ShowFooter = true;
			this.grvData.OptionsView.ShowGroupPanel = false;
			this.grvData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductGroupCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductTypeCode, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.grvData.DoubleClick += new System.EventHandler(this.grvData_DoubleClick);
			// 
			// colID
			// 
			this.colID.AppearanceCell.Options.UseTextOptions = true;
			this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colID.AppearanceHeader.Options.UseFont = true;
			this.colID.AppearanceHeader.Options.UseTextOptions = true;
			this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colID.Caption = "ID";
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			this.colID.Width = 41;
			// 
			// colProductGroupID
			// 
			this.colProductGroupID.AppearanceCell.Options.UseTextOptions = true;
			this.colProductGroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductGroupID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductGroupID.AppearanceHeader.Options.UseFont = true;
			this.colProductGroupID.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductGroupID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupID.Caption = "ProductGroupID";
			this.colProductGroupID.FieldName = "ProductGroupID";
			this.colProductGroupID.Name = "colProductGroupID";
			this.colProductGroupID.OptionsColumn.AllowEdit = false;
			this.colProductGroupID.Width = 67;
			// 
			// colProductID
			// 
			this.colProductID.AppearanceCell.Options.UseTextOptions = true;
			this.colProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductID.AppearanceHeader.Options.UseFont = true;
			this.colProductID.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductID.Caption = "ProductID";
			this.colProductID.FieldName = "ProductID";
			this.colProductID.Name = "colProductID";
			this.colProductID.OptionsColumn.AllowEdit = false;
			this.colProductID.Width = 100;
			// 
			// colProductGroupCode
			// 
			this.colProductGroupCode.AppearanceCell.Options.UseTextOptions = true;
			this.colProductGroupCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductGroupCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductGroupCode.AppearanceHeader.Options.UseFont = true;
			this.colProductGroupCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductGroupCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductGroupCode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductGroupCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductGroupCode.Caption = "Tên nhóm sản phẩm";
			this.colProductGroupCode.FieldName = "ProductGroupCode";
			this.colProductGroupCode.Name = "colProductGroupCode";
			this.colProductGroupCode.OptionsColumn.AllowEdit = false;
			this.colProductGroupCode.OptionsColumn.AllowFocus = false;
			this.colProductGroupCode.Visible = true;
			this.colProductGroupCode.VisibleIndex = 0;
			this.colProductGroupCode.Width = 122;
			// 
			// colProductTypeCode
			// 
			this.colProductTypeCode.AppearanceCell.Options.UseTextOptions = true;
			this.colProductTypeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductTypeCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colProductTypeCode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductTypeCode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colProductTypeCode.AppearanceHeader.Options.UseFont = true;
			this.colProductTypeCode.AppearanceHeader.Options.UseTextOptions = true;
			this.colProductTypeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colProductTypeCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colProductTypeCode.Caption = "Mã loại sản phẩm";
			this.colProductTypeCode.FieldName = "ProductTypeCode";
			this.colProductTypeCode.Name = "colProductTypeCode";
			this.colProductTypeCode.OptionsColumn.AllowEdit = false;
			this.colProductTypeCode.Visible = true;
			this.colProductTypeCode.VisibleIndex = 3;
			this.colProductTypeCode.Width = 132;
			// 
			// colFormula
			// 
			this.colFormula.AppearanceCell.Options.UseTextOptions = true;
			this.colFormula.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFormula.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colFormula.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFormula.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colFormula.AppearanceHeader.Options.UseFont = true;
			this.colFormula.AppearanceHeader.Options.UseTextOptions = true;
			this.colFormula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colFormula.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colFormula.Caption = "Công thức";
			this.colFormula.FieldName = "Formula";
			this.colFormula.Name = "colFormula";
			this.colFormula.OptionsColumn.AllowEdit = false;
			this.colFormula.Visible = true;
			this.colFormula.VisibleIndex = 1;
			this.colFormula.Width = 300;
			// 
			// colSTT
			// 
			this.colSTT.AppearanceCell.Options.UseTextOptions = true;
			this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.colSTT.AppearanceHeader.Options.UseFont = true;
			this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
			this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colSTT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.colSTT.Caption = "STT";
			this.colSTT.FieldName = "STT";
			this.colSTT.Name = "colSTT";
			this.colSTT.OptionsColumn.AllowEdit = false;
			this.colSTT.Visible = true;
			this.colSTT.VisibleIndex = 0;
			// 
			// mnuMenu
			// 
			this.mnuMenu.AutoSize = false;
			this.mnuMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.mnuMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripSeparator9,
            this.btnEdit,
            this.toolStripSeparator8,
            this.btnDelete});
			this.mnuMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.mnuMenu.Location = new System.Drawing.Point(0, 0);
			this.mnuMenu.Name = "mnuMenu";
			this.mnuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMenu.Size = new System.Drawing.Size(838, 42);
			this.mnuMenu.TabIndex = 35;
			this.mnuMenu.Text = "toolStrip2";
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(102, 37);
			this.btnNew.Tag = "frmConfigFormulaAllH_Add";
			this.btnNew.Text = "Thêm công thức";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(92, 37);
			this.btnEdit.Tag = "frmConfigFormulaAllH_Edit";
			this.btnEdit.Text = "Sửa công thức";
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 37);
			this.btnDelete.Tag = "frmConfigFormulaAllH_Delete";
			this.btnDelete.Text = "Xóa công thức";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmConfigFormulaAllH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 509);
			this.Controls.Add(this.grdData);
			this.Controls.Add(this.mnuMenu);
			this.Name = "frmConfigFormulaAllH";
			this.Text = "CÀI ĐẶT CÔNG THỨC";
			this.Load += new System.EventHandler(this.frmConfigFormulaAllH_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
			this.mnuMenu.ResumeLayout(false);
			this.mnuMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdData;
		private DevExpress.XtraGrid.Views.Grid.GridView grvData;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colProductGroupID;
		private DevExpress.XtraGrid.Columns.GridColumn colProductID;
		private DevExpress.XtraGrid.Columns.GridColumn colProductGroupCode;
		private DevExpress.XtraGrid.Columns.GridColumn colProductTypeCode;
		private DevExpress.XtraGrid.Columns.GridColumn colFormula;
		private System.Windows.Forms.ToolStrip mnuMenu;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private DevExpress.XtraGrid.Columns.GridColumn colSTT;
	}
}