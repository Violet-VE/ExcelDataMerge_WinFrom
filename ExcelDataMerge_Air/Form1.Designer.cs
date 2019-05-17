namespace ExcelDataMerge_Air
{
    partial class Root
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LayoutPanel4 = new System.Windows.Forms.TabPage();
            this.IsAppendMergeFile = new System.Windows.Forms.CheckBox();
            this.IsLoadAllCitys = new System.Windows.Forms.CheckBox();
            this.IsMergeAll = new System.Windows.Forms.CheckBox();
            this.IsAppend = new System.Windows.Forms.CheckBox();
            this.IsSelectAllFile = new System.Windows.Forms.CheckBox();
            this.IsSelectAllCity = new System.Windows.Forms.CheckBox();
            this.btn_saveMenu = new System.Windows.Forms.Button();
            this.txt_saveMenu = new System.Windows.Forms.TextBox();
            this.LayoutPanel2 = new System.Windows.Forms.TabPage();
            this.City_LayoutPanel2 = new System.Windows.Forms.SplitContainer();
            this.City_btn_SelectFile = new System.Windows.Forms.Button();
            this.City_LayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.City_MergeFileList = new System.Windows.Forms.ListBox();
            this.City_CityList = new System.Windows.Forms.ListBox();
            this.City_LayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.City_SelectReadSplit = new System.Windows.Forms.GroupBox();
            this.City_Check_SplitTab = new System.Windows.Forms.CheckBox();
            this.City_Check_SplitSpace = new System.Windows.Forms.CheckBox();
            this.City_Check_Comma = new System.Windows.Forms.CheckBox();
            this.City_Check_Semicolon = new System.Windows.Forms.CheckBox();
            this.City_SelectMergeSplit = new System.Windows.Forms.GroupBox();
            this.City_Radio_Semicolon = new System.Windows.Forms.RadioButton();
            this.City_Radio_SplitSpace = new System.Windows.Forms.RadioButton();
            this.City_Radio_SplitComma = new System.Windows.Forms.RadioButton();
            this.City_Radio_SplitTab = new System.Windows.Forms.RadioButton();
            this.City_btn_Start = new System.Windows.Forms.Button();
            this.LayoutPanel1 = new System.Windows.Forms.TabControl();
            this.LayoutPanel3 = new System.Windows.Forms.TabPage();
            this.Site_LayoutPanel2 = new System.Windows.Forms.SplitContainer();
            this.Site_btn_SelectMergeFile = new System.Windows.Forms.Button();
            this.Site_btn_SelectIDFile = new System.Windows.Forms.Button();
            this.Site_LayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Site_LayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Site_SelectReadSplit = new System.Windows.Forms.GroupBox();
            this.Site_Check_SplitTab = new System.Windows.Forms.CheckBox();
            this.Site_Check_SplitSpace = new System.Windows.Forms.CheckBox();
            this.Site_Check_Comma = new System.Windows.Forms.CheckBox();
            this.Site_Check_Semicolon = new System.Windows.Forms.CheckBox();
            this.Site_SelectMergeSplit = new System.Windows.Forms.GroupBox();
            this.Site_Radio_Semicolon = new System.Windows.Forms.RadioButton();
            this.Site_Radio_SplitSpace = new System.Windows.Forms.RadioButton();
            this.Site_Radio_Comma = new System.Windows.Forms.RadioButton();
            this.Site_Radio_SplitTab = new System.Windows.Forms.RadioButton();
            this.Site_btn_Start = new System.Windows.Forms.Button();
            this.Site_IDList = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Site_MergeFileList = new System.Windows.Forms.ListBox();
            this.Site_CityList = new System.Windows.Forms.ListBox();
            this.IsCheckReservations = new System.Windows.Forms.CheckBox();
            this.StatusBar.SuspendLayout();
            this.LayoutPanel4.SuspendLayout();
            this.LayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.City_LayoutPanel2)).BeginInit();
            this.City_LayoutPanel2.Panel1.SuspendLayout();
            this.City_LayoutPanel2.Panel2.SuspendLayout();
            this.City_LayoutPanel2.SuspendLayout();
            this.City_LayoutPanel3.SuspendLayout();
            this.City_LayoutPanel1.SuspendLayout();
            this.City_SelectReadSplit.SuspendLayout();
            this.City_SelectMergeSplit.SuspendLayout();
            this.LayoutPanel1.SuspendLayout();
            this.LayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Site_LayoutPanel2)).BeginInit();
            this.Site_LayoutPanel2.Panel1.SuspendLayout();
            this.Site_LayoutPanel2.Panel2.SuspendLayout();
            this.Site_LayoutPanel2.SuspendLayout();
            this.Site_LayoutPanel3.SuspendLayout();
            this.Site_LayoutPanel1.SuspendLayout();
            this.Site_SelectReadSplit.SuspendLayout();
            this.Site_SelectMergeSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 591);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(715, 25);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 20);
            this.StatusLabel.Text = "Github: ";
            // 
            // LayoutPanel4
            // 
            this.LayoutPanel4.Controls.Add(this.IsCheckReservations);
            this.LayoutPanel4.Controls.Add(this.IsAppendMergeFile);
            this.LayoutPanel4.Controls.Add(this.IsLoadAllCitys);
            this.LayoutPanel4.Controls.Add(this.IsMergeAll);
            this.LayoutPanel4.Controls.Add(this.IsAppend);
            this.LayoutPanel4.Controls.Add(this.IsSelectAllFile);
            this.LayoutPanel4.Controls.Add(this.IsSelectAllCity);
            this.LayoutPanel4.Controls.Add(this.btn_saveMenu);
            this.LayoutPanel4.Controls.Add(this.txt_saveMenu);
            this.LayoutPanel4.Location = new System.Drawing.Point(4, 25);
            this.LayoutPanel4.Name = "LayoutPanel4";
            this.LayoutPanel4.Size = new System.Drawing.Size(707, 562);
            this.LayoutPanel4.TabIndex = 2;
            this.LayoutPanel4.Text = "设置";
            this.LayoutPanel4.UseVisualStyleBackColor = true;
            // 
            // IsAppendMergeFile
            // 
            this.IsAppendMergeFile.AutoSize = true;
            this.IsAppendMergeFile.Checked = true;
            this.IsAppendMergeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsAppendMergeFile.Location = new System.Drawing.Point(3, 193);
            this.IsAppendMergeFile.Name = "IsAppendMergeFile";
            this.IsAppendMergeFile.Size = new System.Drawing.Size(345, 19);
            this.IsAppendMergeFile.TabIndex = 9;
            this.IsAppendMergeFile.Text = "合并后的文件内容是否追加还是覆盖(勾选覆盖)";
            this.IsAppendMergeFile.UseVisualStyleBackColor = true;
            // 
            // IsLoadAllCitys
            // 
            this.IsLoadAllCitys.AutoSize = true;
            this.IsLoadAllCitys.Location = new System.Drawing.Point(3, 167);
            this.IsLoadAllCitys.Name = "IsLoadAllCitys";
            this.IsLoadAllCitys.Size = new System.Drawing.Size(495, 19);
            this.IsLoadAllCitys.TabIndex = 8;
            this.IsLoadAllCitys.Text = "默认加载全国城市还是第一个文件的城市(勾选加载第一个文件的城市)";
            this.IsLoadAllCitys.UseVisualStyleBackColor = true;
            // 
            // IsMergeAll
            // 
            this.IsMergeAll.AutoSize = true;
            this.IsMergeAll.Checked = true;
            this.IsMergeAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsMergeAll.Location = new System.Drawing.Point(3, 142);
            this.IsMergeAll.Name = "IsMergeAll";
            this.IsMergeAll.Size = new System.Drawing.Size(330, 19);
            this.IsMergeAll.TabIndex = 7;
            this.IsMergeAll.Text = "是否默认合并文件列表的全部文件(勾选合并)";
            this.IsMergeAll.UseVisualStyleBackColor = true;
            // 
            // IsAppend
            // 
            this.IsAppend.AutoSize = true;
            this.IsAppend.Location = new System.Drawing.Point(3, 115);
            this.IsAppend.Name = "IsAppend";
            this.IsAppend.Size = new System.Drawing.Size(390, 19);
            this.IsAppend.TabIndex = 6;
            this.IsAppend.Text = "打开文件追加到文件列表还是覆盖文件列表(勾选追加)";
            this.IsAppend.UseVisualStyleBackColor = true;
            // 
            // IsSelectAllFile
            // 
            this.IsSelectAllFile.AutoSize = true;
            this.IsSelectAllFile.Location = new System.Drawing.Point(3, 89);
            this.IsSelectAllFile.Name = "IsSelectAllFile";
            this.IsSelectAllFile.Size = new System.Drawing.Size(224, 19);
            this.IsSelectAllFile.TabIndex = 5;
            this.IsSelectAllFile.Text = "选择文件后是否全选文件列表";
            this.IsSelectAllFile.UseVisualStyleBackColor = true;
            // 
            // IsSelectAllCity
            // 
            this.IsSelectAllCity.AutoSize = true;
            this.IsSelectAllCity.Location = new System.Drawing.Point(4, 63);
            this.IsSelectAllCity.Name = "IsSelectAllCity";
            this.IsSelectAllCity.Size = new System.Drawing.Size(224, 19);
            this.IsSelectAllCity.TabIndex = 4;
            this.IsSelectAllCity.Text = "选择文件后是否全选城市列表";
            this.IsSelectAllCity.UseVisualStyleBackColor = true;
            // 
            // btn_saveMenu
            // 
            this.btn_saveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveMenu.Location = new System.Drawing.Point(579, 3);
            this.btn_saveMenu.Name = "btn_saveMenu";
            this.btn_saveMenu.Size = new System.Drawing.Size(118, 53);
            this.btn_saveMenu.TabIndex = 3;
            this.btn_saveMenu.Text = "选择保存位置";
            this.btn_saveMenu.UseVisualStyleBackColor = true;
            this.btn_saveMenu.Click += new System.EventHandler(this.SelectSaveMenu);
            // 
            // txt_saveMenu
            // 
            this.txt_saveMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_saveMenu.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_saveMenu.Location = new System.Drawing.Point(3, 3);
            this.txt_saveMenu.Name = "txt_saveMenu";
            this.txt_saveMenu.ReadOnly = true;
            this.txt_saveMenu.Size = new System.Drawing.Size(569, 53);
            this.txt_saveMenu.TabIndex = 2;
            this.txt_saveMenu.Text = "./合并.csv";
            // 
            // LayoutPanel2
            // 
            this.LayoutPanel2.Controls.Add(this.City_LayoutPanel2);
            this.LayoutPanel2.Location = new System.Drawing.Point(4, 25);
            this.LayoutPanel2.Name = "LayoutPanel2";
            this.LayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.LayoutPanel2.Size = new System.Drawing.Size(707, 562);
            this.LayoutPanel2.TabIndex = 0;
            this.LayoutPanel2.Text = "城市";
            this.LayoutPanel2.UseVisualStyleBackColor = true;
            // 
            // City_LayoutPanel2
            // 
            this.City_LayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_LayoutPanel2.IsSplitterFixed = true;
            this.City_LayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.City_LayoutPanel2.Name = "City_LayoutPanel2";
            this.City_LayoutPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // City_LayoutPanel2.Panel1
            // 
            this.City_LayoutPanel2.Panel1.Controls.Add(this.City_btn_SelectFile);
            // 
            // City_LayoutPanel2.Panel2
            // 
            this.City_LayoutPanel2.Panel2.Controls.Add(this.City_LayoutPanel3);
            this.City_LayoutPanel2.Size = new System.Drawing.Size(701, 556);
            this.City_LayoutPanel2.SplitterDistance = 72;
            this.City_LayoutPanel2.TabIndex = 0;
            // 
            // City_btn_SelectFile
            // 
            this.City_btn_SelectFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.City_btn_SelectFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.City_btn_SelectFile.Location = new System.Drawing.Point(0, 0);
            this.City_btn_SelectFile.Name = "City_btn_SelectFile";
            this.City_btn_SelectFile.Size = new System.Drawing.Size(115, 72);
            this.City_btn_SelectFile.TabIndex = 0;
            this.City_btn_SelectFile.Text = "选择合并文件";
            this.City_btn_SelectFile.UseVisualStyleBackColor = true;
            this.City_btn_SelectFile.Click += new System.EventHandler(this.SelectMergeFile);
            // 
            // City_LayoutPanel3
            // 
            this.City_LayoutPanel3.ColumnCount = 3;
            this.City_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.City_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.City_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.City_LayoutPanel3.Controls.Add(this.City_MergeFileList, 0, 0);
            this.City_LayoutPanel3.Controls.Add(this.City_CityList, 2, 0);
            this.City_LayoutPanel3.Controls.Add(this.City_LayoutPanel1, 1, 0);
            this.City_LayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_LayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.City_LayoutPanel3.Name = "City_LayoutPanel3";
            this.City_LayoutPanel3.RowCount = 1;
            this.City_LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.City_LayoutPanel3.Size = new System.Drawing.Size(701, 480);
            this.City_LayoutPanel3.TabIndex = 0;
            // 
            // City_MergeFileList
            // 
            this.City_MergeFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_MergeFileList.FormattingEnabled = true;
            this.City_MergeFileList.ItemHeight = 15;
            this.City_MergeFileList.Location = new System.Drawing.Point(3, 3);
            this.City_MergeFileList.Name = "City_MergeFileList";
            this.City_MergeFileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.City_MergeFileList.Size = new System.Drawing.Size(275, 474);
            this.City_MergeFileList.TabIndex = 0;
            // 
            // City_CityList
            // 
            this.City_CityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_CityList.FormattingEnabled = true;
            this.City_CityList.ItemHeight = 15;
            this.City_CityList.Location = new System.Drawing.Point(423, 3);
            this.City_CityList.Name = "City_CityList";
            this.City_CityList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.City_CityList.Size = new System.Drawing.Size(275, 474);
            this.City_CityList.TabIndex = 1;
            // 
            // City_LayoutPanel1
            // 
            this.City_LayoutPanel1.Controls.Add(this.City_SelectReadSplit);
            this.City_LayoutPanel1.Controls.Add(this.City_SelectMergeSplit);
            this.City_LayoutPanel1.Controls.Add(this.City_btn_Start);
            this.City_LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.City_LayoutPanel1.Location = new System.Drawing.Point(284, 3);
            this.City_LayoutPanel1.Name = "City_LayoutPanel1";
            this.City_LayoutPanel1.Size = new System.Drawing.Size(133, 474);
            this.City_LayoutPanel1.TabIndex = 2;
            // 
            // City_SelectReadSplit
            // 
            this.City_SelectReadSplit.Controls.Add(this.City_Check_SplitTab);
            this.City_SelectReadSplit.Controls.Add(this.City_Check_SplitSpace);
            this.City_SelectReadSplit.Controls.Add(this.City_Check_Comma);
            this.City_SelectReadSplit.Controls.Add(this.City_Check_Semicolon);
            this.City_SelectReadSplit.Location = new System.Drawing.Point(3, 3);
            this.City_SelectReadSplit.Name = "City_SelectReadSplit";
            this.City_SelectReadSplit.Size = new System.Drawing.Size(101, 138);
            this.City_SelectReadSplit.TabIndex = 7;
            this.City_SelectReadSplit.TabStop = false;
            this.City_SelectReadSplit.Text = "选择读取时分隔符";
            // 
            // City_Check_SplitTab
            // 
            this.City_Check_SplitTab.AutoSize = true;
            this.City_Check_SplitTab.Checked = true;
            this.City_Check_SplitTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.City_Check_SplitTab.Location = new System.Drawing.Point(6, 35);
            this.City_Check_SplitTab.Name = "City_Check_SplitTab";
            this.City_Check_SplitTab.Size = new System.Drawing.Size(53, 19);
            this.City_Check_SplitTab.TabIndex = 10;
            this.City_Check_SplitTab.Text = "Tab";
            this.City_Check_SplitTab.UseVisualStyleBackColor = true;
            // 
            // City_Check_SplitSpace
            // 
            this.City_Check_SplitSpace.AutoSize = true;
            this.City_Check_SplitSpace.Checked = true;
            this.City_Check_SplitSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.City_Check_SplitSpace.Location = new System.Drawing.Point(6, 85);
            this.City_Check_SplitSpace.Name = "City_Check_SplitSpace";
            this.City_Check_SplitSpace.Size = new System.Drawing.Size(59, 19);
            this.City_Check_SplitSpace.TabIndex = 11;
            this.City_Check_SplitSpace.Text = "空格";
            this.City_Check_SplitSpace.UseVisualStyleBackColor = true;
            // 
            // City_Check_Comma
            // 
            this.City_Check_Comma.AutoSize = true;
            this.City_Check_Comma.Checked = true;
            this.City_Check_Comma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.City_Check_Comma.Location = new System.Drawing.Point(6, 60);
            this.City_Check_Comma.Name = "City_Check_Comma";
            this.City_Check_Comma.Size = new System.Drawing.Size(59, 19);
            this.City_Check_Comma.TabIndex = 12;
            this.City_Check_Comma.Text = "逗号";
            this.City_Check_Comma.UseVisualStyleBackColor = true;
            // 
            // City_Check_Semicolon
            // 
            this.City_Check_Semicolon.AutoSize = true;
            this.City_Check_Semicolon.Checked = true;
            this.City_Check_Semicolon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.City_Check_Semicolon.Location = new System.Drawing.Point(6, 110);
            this.City_Check_Semicolon.Name = "City_Check_Semicolon";
            this.City_Check_Semicolon.Size = new System.Drawing.Size(59, 19);
            this.City_Check_Semicolon.TabIndex = 13;
            this.City_Check_Semicolon.Text = "分号";
            this.City_Check_Semicolon.UseVisualStyleBackColor = true;
            // 
            // City_SelectMergeSplit
            // 
            this.City_SelectMergeSplit.Controls.Add(this.City_Radio_Semicolon);
            this.City_SelectMergeSplit.Controls.Add(this.City_Radio_SplitSpace);
            this.City_SelectMergeSplit.Controls.Add(this.City_Radio_SplitComma);
            this.City_SelectMergeSplit.Controls.Add(this.City_Radio_SplitTab);
            this.City_SelectMergeSplit.Location = new System.Drawing.Point(3, 147);
            this.City_SelectMergeSplit.Name = "City_SelectMergeSplit";
            this.City_SelectMergeSplit.Size = new System.Drawing.Size(101, 144);
            this.City_SelectMergeSplit.TabIndex = 6;
            this.City_SelectMergeSplit.TabStop = false;
            this.City_SelectMergeSplit.Text = "选择合并时分隔符";
            // 
            // City_Radio_Semicolon
            // 
            this.City_Radio_Semicolon.AutoSize = true;
            this.City_Radio_Semicolon.Location = new System.Drawing.Point(7, 114);
            this.City_Radio_Semicolon.Name = "City_Radio_Semicolon";
            this.City_Radio_Semicolon.Size = new System.Drawing.Size(58, 19);
            this.City_Radio_Semicolon.TabIndex = 3;
            this.City_Radio_Semicolon.TabStop = true;
            this.City_Radio_Semicolon.Text = "分号";
            this.City_Radio_Semicolon.UseVisualStyleBackColor = true;
            // 
            // City_Radio_SplitSpace
            // 
            this.City_Radio_SplitSpace.AutoSize = true;
            this.City_Radio_SplitSpace.Location = new System.Drawing.Point(7, 89);
            this.City_Radio_SplitSpace.Name = "City_Radio_SplitSpace";
            this.City_Radio_SplitSpace.Size = new System.Drawing.Size(58, 19);
            this.City_Radio_SplitSpace.TabIndex = 2;
            this.City_Radio_SplitSpace.TabStop = true;
            this.City_Radio_SplitSpace.Text = "空格";
            this.City_Radio_SplitSpace.UseVisualStyleBackColor = true;
            // 
            // City_Radio_SplitComma
            // 
            this.City_Radio_SplitComma.AutoSize = true;
            this.City_Radio_SplitComma.Checked = true;
            this.City_Radio_SplitComma.Location = new System.Drawing.Point(7, 64);
            this.City_Radio_SplitComma.Name = "City_Radio_SplitComma";
            this.City_Radio_SplitComma.Size = new System.Drawing.Size(58, 19);
            this.City_Radio_SplitComma.TabIndex = 1;
            this.City_Radio_SplitComma.TabStop = true;
            this.City_Radio_SplitComma.Text = "逗号";
            this.City_Radio_SplitComma.UseVisualStyleBackColor = true;
            // 
            // City_Radio_SplitTab
            // 
            this.City_Radio_SplitTab.AutoSize = true;
            this.City_Radio_SplitTab.Location = new System.Drawing.Point(7, 39);
            this.City_Radio_SplitTab.Name = "City_Radio_SplitTab";
            this.City_Radio_SplitTab.Size = new System.Drawing.Size(52, 19);
            this.City_Radio_SplitTab.TabIndex = 0;
            this.City_Radio_SplitTab.TabStop = true;
            this.City_Radio_SplitTab.Text = "Tab";
            this.City_Radio_SplitTab.UseVisualStyleBackColor = true;
            // 
            // City_btn_Start
            // 
            this.City_btn_Start.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.City_btn_Start.Location = new System.Drawing.Point(3, 297);
            this.City_btn_Start.Name = "City_btn_Start";
            this.City_btn_Start.Size = new System.Drawing.Size(101, 38);
            this.City_btn_Start.TabIndex = 0;
            this.City_btn_Start.Text = "开始合并";
            this.City_btn_Start.UseVisualStyleBackColor = true;
            this.City_btn_Start.Click += new System.EventHandler(this.StartMerge);
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.Controls.Add(this.LayoutPanel2);
            this.LayoutPanel1.Controls.Add(this.LayoutPanel3);
            this.LayoutPanel1.Controls.Add(this.LayoutPanel4);
            this.LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.SelectedIndex = 0;
            this.LayoutPanel1.Size = new System.Drawing.Size(715, 591);
            this.LayoutPanel1.TabIndex = 2;
            // 
            // LayoutPanel3
            // 
            this.LayoutPanel3.Controls.Add(this.Site_LayoutPanel2);
            this.LayoutPanel3.Location = new System.Drawing.Point(4, 25);
            this.LayoutPanel3.Name = "LayoutPanel3";
            this.LayoutPanel3.Size = new System.Drawing.Size(707, 562);
            this.LayoutPanel3.TabIndex = 3;
            this.LayoutPanel3.Text = "站点";
            this.LayoutPanel3.UseVisualStyleBackColor = true;
            // 
            // Site_LayoutPanel2
            // 
            this.Site_LayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_LayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.Site_LayoutPanel2.Name = "Site_LayoutPanel2";
            this.Site_LayoutPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Site_LayoutPanel2.Panel1
            // 
            this.Site_LayoutPanel2.Panel1.Controls.Add(this.Site_btn_SelectMergeFile);
            this.Site_LayoutPanel2.Panel1.Controls.Add(this.Site_btn_SelectIDFile);
            // 
            // Site_LayoutPanel2.Panel2
            // 
            this.Site_LayoutPanel2.Panel2.Controls.Add(this.Site_LayoutPanel3);
            this.Site_LayoutPanel2.Size = new System.Drawing.Size(707, 562);
            this.Site_LayoutPanel2.SplitterDistance = 82;
            this.Site_LayoutPanel2.TabIndex = 0;
            // 
            // Site_btn_SelectMergeFile
            // 
            this.Site_btn_SelectMergeFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.Site_btn_SelectMergeFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Site_btn_SelectMergeFile.Location = new System.Drawing.Point(115, 0);
            this.Site_btn_SelectMergeFile.Name = "Site_btn_SelectMergeFile";
            this.Site_btn_SelectMergeFile.Size = new System.Drawing.Size(115, 82);
            this.Site_btn_SelectMergeFile.TabIndex = 2;
            this.Site_btn_SelectMergeFile.Text = "选择合并文件";
            this.Site_btn_SelectMergeFile.UseVisualStyleBackColor = true;
            this.Site_btn_SelectMergeFile.Click += new System.EventHandler(this.SelectSiteMergeFile);
            // 
            // Site_btn_SelectIDFile
            // 
            this.Site_btn_SelectIDFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.Site_btn_SelectIDFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Site_btn_SelectIDFile.Location = new System.Drawing.Point(0, 0);
            this.Site_btn_SelectIDFile.Name = "Site_btn_SelectIDFile";
            this.Site_btn_SelectIDFile.Size = new System.Drawing.Size(115, 82);
            this.Site_btn_SelectIDFile.TabIndex = 1;
            this.Site_btn_SelectIDFile.Text = "选择编号文件";
            this.Site_btn_SelectIDFile.UseVisualStyleBackColor = true;
            this.Site_btn_SelectIDFile.Click += new System.EventHandler(this.SelectSiteID);
            // 
            // Site_LayoutPanel3
            // 
            this.Site_LayoutPanel3.ColumnCount = 3;
            this.Site_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Site_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Site_LayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Site_LayoutPanel3.Controls.Add(this.Site_LayoutPanel1, 1, 0);
            this.Site_LayoutPanel3.Controls.Add(this.Site_IDList, 2, 0);
            this.Site_LayoutPanel3.Controls.Add(this.splitContainer1, 0, 0);
            this.Site_LayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_LayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.Site_LayoutPanel3.Name = "Site_LayoutPanel3";
            this.Site_LayoutPanel3.RowCount = 1;
            this.Site_LayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Site_LayoutPanel3.Size = new System.Drawing.Size(707, 476);
            this.Site_LayoutPanel3.TabIndex = 0;
            // 
            // Site_LayoutPanel1
            // 
            this.Site_LayoutPanel1.Controls.Add(this.Site_SelectReadSplit);
            this.Site_LayoutPanel1.Controls.Add(this.Site_SelectMergeSplit);
            this.Site_LayoutPanel1.Controls.Add(this.Site_btn_Start);
            this.Site_LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_LayoutPanel1.Location = new System.Drawing.Point(286, 3);
            this.Site_LayoutPanel1.Name = "Site_LayoutPanel1";
            this.Site_LayoutPanel1.Size = new System.Drawing.Size(135, 470);
            this.Site_LayoutPanel1.TabIndex = 0;
            // 
            // Site_SelectReadSplit
            // 
            this.Site_SelectReadSplit.Controls.Add(this.Site_Check_SplitTab);
            this.Site_SelectReadSplit.Controls.Add(this.Site_Check_SplitSpace);
            this.Site_SelectReadSplit.Controls.Add(this.Site_Check_Comma);
            this.Site_SelectReadSplit.Controls.Add(this.Site_Check_Semicolon);
            this.Site_SelectReadSplit.Location = new System.Drawing.Point(3, 3);
            this.Site_SelectReadSplit.Name = "Site_SelectReadSplit";
            this.Site_SelectReadSplit.Size = new System.Drawing.Size(101, 138);
            this.Site_SelectReadSplit.TabIndex = 14;
            this.Site_SelectReadSplit.TabStop = false;
            this.Site_SelectReadSplit.Text = "选择读取时分隔符";
            // 
            // Site_Check_SplitTab
            // 
            this.Site_Check_SplitTab.AutoSize = true;
            this.Site_Check_SplitTab.Checked = true;
            this.Site_Check_SplitTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Site_Check_SplitTab.Location = new System.Drawing.Point(6, 35);
            this.Site_Check_SplitTab.Name = "Site_Check_SplitTab";
            this.Site_Check_SplitTab.Size = new System.Drawing.Size(53, 19);
            this.Site_Check_SplitTab.TabIndex = 10;
            this.Site_Check_SplitTab.Text = "Tab";
            this.Site_Check_SplitTab.UseVisualStyleBackColor = true;
            // 
            // Site_Check_SplitSpace
            // 
            this.Site_Check_SplitSpace.AutoSize = true;
            this.Site_Check_SplitSpace.Checked = true;
            this.Site_Check_SplitSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Site_Check_SplitSpace.Location = new System.Drawing.Point(6, 85);
            this.Site_Check_SplitSpace.Name = "Site_Check_SplitSpace";
            this.Site_Check_SplitSpace.Size = new System.Drawing.Size(59, 19);
            this.Site_Check_SplitSpace.TabIndex = 11;
            this.Site_Check_SplitSpace.Text = "空格";
            this.Site_Check_SplitSpace.UseVisualStyleBackColor = true;
            // 
            // Site_Check_Comma
            // 
            this.Site_Check_Comma.AutoSize = true;
            this.Site_Check_Comma.Checked = true;
            this.Site_Check_Comma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Site_Check_Comma.Location = new System.Drawing.Point(6, 60);
            this.Site_Check_Comma.Name = "Site_Check_Comma";
            this.Site_Check_Comma.Size = new System.Drawing.Size(59, 19);
            this.Site_Check_Comma.TabIndex = 12;
            this.Site_Check_Comma.Text = "逗号";
            this.Site_Check_Comma.UseVisualStyleBackColor = true;
            // 
            // Site_Check_Semicolon
            // 
            this.Site_Check_Semicolon.AutoSize = true;
            this.Site_Check_Semicolon.Checked = true;
            this.Site_Check_Semicolon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Site_Check_Semicolon.Location = new System.Drawing.Point(6, 110);
            this.Site_Check_Semicolon.Name = "Site_Check_Semicolon";
            this.Site_Check_Semicolon.Size = new System.Drawing.Size(59, 19);
            this.Site_Check_Semicolon.TabIndex = 13;
            this.Site_Check_Semicolon.Text = "分号";
            this.Site_Check_Semicolon.UseVisualStyleBackColor = true;
            // 
            // Site_SelectMergeSplit
            // 
            this.Site_SelectMergeSplit.Controls.Add(this.Site_Radio_Semicolon);
            this.Site_SelectMergeSplit.Controls.Add(this.Site_Radio_SplitSpace);
            this.Site_SelectMergeSplit.Controls.Add(this.Site_Radio_Comma);
            this.Site_SelectMergeSplit.Controls.Add(this.Site_Radio_SplitTab);
            this.Site_SelectMergeSplit.Location = new System.Drawing.Point(3, 147);
            this.Site_SelectMergeSplit.Name = "Site_SelectMergeSplit";
            this.Site_SelectMergeSplit.Size = new System.Drawing.Size(101, 144);
            this.Site_SelectMergeSplit.TabIndex = 13;
            this.Site_SelectMergeSplit.TabStop = false;
            this.Site_SelectMergeSplit.Text = "选择合并时分隔符";
            // 
            // Site_Radio_Semicolon
            // 
            this.Site_Radio_Semicolon.AutoSize = true;
            this.Site_Radio_Semicolon.Location = new System.Drawing.Point(7, 114);
            this.Site_Radio_Semicolon.Name = "Site_Radio_Semicolon";
            this.Site_Radio_Semicolon.Size = new System.Drawing.Size(58, 19);
            this.Site_Radio_Semicolon.TabIndex = 3;
            this.Site_Radio_Semicolon.TabStop = true;
            this.Site_Radio_Semicolon.Text = "分号";
            this.Site_Radio_Semicolon.UseVisualStyleBackColor = true;
            // 
            // Site_Radio_SplitSpace
            // 
            this.Site_Radio_SplitSpace.AutoSize = true;
            this.Site_Radio_SplitSpace.Location = new System.Drawing.Point(7, 89);
            this.Site_Radio_SplitSpace.Name = "Site_Radio_SplitSpace";
            this.Site_Radio_SplitSpace.Size = new System.Drawing.Size(58, 19);
            this.Site_Radio_SplitSpace.TabIndex = 2;
            this.Site_Radio_SplitSpace.TabStop = true;
            this.Site_Radio_SplitSpace.Text = "空格";
            this.Site_Radio_SplitSpace.UseVisualStyleBackColor = true;
            // 
            // Site_Radio_Comma
            // 
            this.Site_Radio_Comma.AutoSize = true;
            this.Site_Radio_Comma.Checked = true;
            this.Site_Radio_Comma.Location = new System.Drawing.Point(7, 64);
            this.Site_Radio_Comma.Name = "Site_Radio_Comma";
            this.Site_Radio_Comma.Size = new System.Drawing.Size(58, 19);
            this.Site_Radio_Comma.TabIndex = 1;
            this.Site_Radio_Comma.TabStop = true;
            this.Site_Radio_Comma.Text = "逗号";
            this.Site_Radio_Comma.UseVisualStyleBackColor = true;
            // 
            // Site_Radio_SplitTab
            // 
            this.Site_Radio_SplitTab.AutoSize = true;
            this.Site_Radio_SplitTab.Location = new System.Drawing.Point(7, 39);
            this.Site_Radio_SplitTab.Name = "Site_Radio_SplitTab";
            this.Site_Radio_SplitTab.Size = new System.Drawing.Size(52, 19);
            this.Site_Radio_SplitTab.TabIndex = 0;
            this.Site_Radio_SplitTab.TabStop = true;
            this.Site_Radio_SplitTab.Text = "Tab";
            this.Site_Radio_SplitTab.UseVisualStyleBackColor = true;
            // 
            // Site_btn_Start
            // 
            this.Site_btn_Start.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Site_btn_Start.Location = new System.Drawing.Point(3, 297);
            this.Site_btn_Start.Name = "Site_btn_Start";
            this.Site_btn_Start.Size = new System.Drawing.Size(101, 38);
            this.Site_btn_Start.TabIndex = 12;
            this.Site_btn_Start.Text = "开始合并";
            this.Site_btn_Start.UseVisualStyleBackColor = true;
            this.Site_btn_Start.Click += new System.EventHandler(this.StartMergeSite);
            // 
            // Site_IDList
            // 
            this.Site_IDList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_IDList.Location = new System.Drawing.Point(427, 3);
            this.Site_IDList.Name = "Site_IDList";
            this.Site_IDList.Size = new System.Drawing.Size(277, 470);
            this.Site_IDList.TabIndex = 2;
            this.Site_IDList.UseCompatibleStateImageBehavior = false;
            this.Site_IDList.View = System.Windows.Forms.View.Details;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Site_MergeFileList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Site_CityList);
            this.splitContainer1.Size = new System.Drawing.Size(277, 470);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 3;
            // 
            // Site_MergeFileList
            // 
            this.Site_MergeFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_MergeFileList.FormattingEnabled = true;
            this.Site_MergeFileList.ItemHeight = 15;
            this.Site_MergeFileList.Location = new System.Drawing.Point(0, 0);
            this.Site_MergeFileList.Name = "Site_MergeFileList";
            this.Site_MergeFileList.Size = new System.Drawing.Size(134, 470);
            this.Site_MergeFileList.TabIndex = 2;
            // 
            // Site_CityList
            // 
            this.Site_CityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Site_CityList.FormattingEnabled = true;
            this.Site_CityList.ItemHeight = 15;
            this.Site_CityList.Location = new System.Drawing.Point(0, 0);
            this.Site_CityList.Name = "Site_CityList";
            this.Site_CityList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Site_CityList.Size = new System.Drawing.Size(139, 470);
            this.Site_CityList.TabIndex = 1;
            // 
            // IsCheckReservations
            // 
            this.IsCheckReservations.AutoSize = true;
            this.IsCheckReservations.Checked = true;
            this.IsCheckReservations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsCheckReservations.Location = new System.Drawing.Point(3, 219);
            this.IsCheckReservations.Name = "IsCheckReservations";
            this.IsCheckReservations.Size = new System.Drawing.Size(255, 19);
            this.IsCheckReservations.TabIndex = 10;
            this.IsCheckReservations.Text = "是否需要保留重复标题(勾选保留)";
            this.IsCheckReservations.UseVisualStyleBackColor = true;
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 616);
            this.Controls.Add(this.LayoutPanel1);
            this.Controls.Add(this.StatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Root";
            this.Text = "Excel数据合并";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RootClose);
            this.Load += new System.EventHandler(this.RootLoad);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.LayoutPanel4.ResumeLayout(false);
            this.LayoutPanel4.PerformLayout();
            this.LayoutPanel2.ResumeLayout(false);
            this.City_LayoutPanel2.Panel1.ResumeLayout(false);
            this.City_LayoutPanel2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.City_LayoutPanel2)).EndInit();
            this.City_LayoutPanel2.ResumeLayout(false);
            this.City_LayoutPanel3.ResumeLayout(false);
            this.City_LayoutPanel1.ResumeLayout(false);
            this.City_SelectReadSplit.ResumeLayout(false);
            this.City_SelectReadSplit.PerformLayout();
            this.City_SelectMergeSplit.ResumeLayout(false);
            this.City_SelectMergeSplit.PerformLayout();
            this.LayoutPanel1.ResumeLayout(false);
            this.LayoutPanel3.ResumeLayout(false);
            this.Site_LayoutPanel2.Panel1.ResumeLayout(false);
            this.Site_LayoutPanel2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Site_LayoutPanel2)).EndInit();
            this.Site_LayoutPanel2.ResumeLayout(false);
            this.Site_LayoutPanel3.ResumeLayout(false);
            this.Site_LayoutPanel1.ResumeLayout(false);
            this.Site_SelectReadSplit.ResumeLayout(false);
            this.Site_SelectReadSplit.PerformLayout();
            this.Site_SelectMergeSplit.ResumeLayout(false);
            this.Site_SelectMergeSplit.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TabPage LayoutPanel4;
        private System.Windows.Forms.TabPage LayoutPanel2;
        private System.Windows.Forms.SplitContainer City_LayoutPanel2;
        private System.Windows.Forms.Button City_btn_SelectFile;
        private System.Windows.Forms.TableLayoutPanel City_LayoutPanel3;
        private System.Windows.Forms.ListBox City_MergeFileList;
        private System.Windows.Forms.ListBox City_CityList;
        private System.Windows.Forms.FlowLayoutPanel City_LayoutPanel1;
        private System.Windows.Forms.Button City_btn_Start;
        private System.Windows.Forms.TabControl LayoutPanel1;
        private System.Windows.Forms.TabPage LayoutPanel3;
        private System.Windows.Forms.SplitContainer Site_LayoutPanel2;
        private System.Windows.Forms.Button Site_btn_SelectMergeFile;
        private System.Windows.Forms.Button Site_btn_SelectIDFile;
        private System.Windows.Forms.TableLayoutPanel Site_LayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel Site_LayoutPanel1;
        private System.Windows.Forms.ListView Site_IDList;
        private System.Windows.Forms.GroupBox City_SelectReadSplit;
        private System.Windows.Forms.CheckBox City_Check_SplitSpace;
        private System.Windows.Forms.CheckBox City_Check_Comma;
        private System.Windows.Forms.CheckBox City_Check_Semicolon;
        private System.Windows.Forms.GroupBox City_SelectMergeSplit;
        private System.Windows.Forms.CheckBox City_Check_SplitTab;
        private System.Windows.Forms.RadioButton City_Radio_Semicolon;
        private System.Windows.Forms.RadioButton City_Radio_SplitSpace;
        private System.Windows.Forms.RadioButton City_Radio_SplitComma;
        private System.Windows.Forms.RadioButton City_Radio_SplitTab;
        private System.Windows.Forms.GroupBox Site_SelectReadSplit;
        private System.Windows.Forms.CheckBox Site_Check_SplitTab;
        private System.Windows.Forms.CheckBox Site_Check_SplitSpace;
        private System.Windows.Forms.CheckBox Site_Check_Comma;
        private System.Windows.Forms.CheckBox Site_Check_Semicolon;
        private System.Windows.Forms.GroupBox Site_SelectMergeSplit;
        private System.Windows.Forms.RadioButton Site_Radio_Semicolon;
        private System.Windows.Forms.RadioButton Site_Radio_SplitSpace;
        private System.Windows.Forms.RadioButton Site_Radio_Comma;
        private System.Windows.Forms.RadioButton Site_Radio_SplitTab;
        private System.Windows.Forms.Button Site_btn_Start;
        private System.Windows.Forms.Button btn_saveMenu;
        private System.Windows.Forms.TextBox txt_saveMenu;
        private System.Windows.Forms.CheckBox IsSelectAllFile;
        private System.Windows.Forms.CheckBox IsSelectAllCity;
        private System.Windows.Forms.CheckBox IsAppend;
        private System.Windows.Forms.CheckBox IsMergeAll;
        private System.Windows.Forms.CheckBox IsLoadAllCitys;
        private System.Windows.Forms.CheckBox IsAppendMergeFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox Site_MergeFileList;
        private System.Windows.Forms.ListBox Site_CityList;
        private System.Windows.Forms.CheckBox IsCheckReservations;
    }
}

