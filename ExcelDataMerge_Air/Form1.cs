using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelDataMerge_Air
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        #region 全局变量
        private List<string> filePaths = new List<string>();//所有需要合并的文件的路径
        private string[] sArray;//所有列(包括城市和前面三个)
        private string[] sArrayCity;//所有城市
        private Dictionary<string, string> sArrayCityID;
        private List<string> sArrayID;
        #endregion

        /// <summary>
        /// 打开需要合并文件的按钮
        /// </summary>
        private void SelectMergeFile(object sender, EventArgs e)
        {
            string[] ssArray = {
                "北京","天津","石家庄","唐山","秦皇岛","邯郸",
                "保定","张家口","承德","廊坊","沧州","衡水",
                "邢台","太原","呼和浩特","沈阳","大连","长春",
                "哈尔滨","上海","南京","苏州","南通","连云港",
                "徐州","扬州","无锡","常州","镇江","泰州",
                "淮安","盐城","宿迁","杭州","宁波","温州",
                "绍兴","湖州","嘉兴","台州","舟山","金华",
                "衢州","丽水","合肥","福州","厦门","南昌",
                "济南","青岛","郑州","武汉","长沙","广州",
                "深圳","珠海","佛山","中山","江门","东莞",
                "惠州","肇庆","南宁","海口","重庆","成都",
                "贵阳","昆明","拉萨","西安","兰州","西宁",
                "银川","乌鲁木齐","湘潭","株洲","包头","鄂尔多斯",
                "营口","盘锦","泉州","莱芜","临沂","德州",
                "聊城","滨州","淄博","枣庄","烟台","潍坊",
                "济宁","泰安","日照","威海","东营","韶关",
                "汕头","湛江","茂名","梅州","汕尾","阳江",
                "清远","潮州","云浮","玉溪","菏泽","大同",
                "长治","临汾","阳泉","赤峰","鞍山","抚顺",
                "本溪","锦州","吉林","齐齐哈尔","牡丹江","大庆",
                "芜湖","马鞍山","九江","洛阳","安阳","开封",
                "焦作","平顶山","三门峡","宜昌","荆州","岳阳",
                "常德","张家界","桂林","北海","柳州","三亚",
                "绵阳","宜宾","攀枝花","泸州","自贡","德阳",
                "南充","遵义","曲靖","咸阳","铜川","延安",
                "宝鸡","渭南","金昌","嘉峪关","石嘴山","克拉玛依",
                "库尔勒","寿光","章丘","即墨","胶南","胶州",
                "莱西","平度","蓬莱","招远","莱州","荣成",
                "文登","乳山","吴江","昆山","常熟","张家港",
                "太仓","句容","江阴","宜兴","金坛","溧阳",
                "海门","临安","富阳","义乌","诸暨","瓦房店",
                "信阳","周口","漳州","晋城","朔州","晋中",
                "运城","忻州","吕梁","乌海","通辽","呼伦贝尔",
                "巴彦淖尔","乌兰察布","兴安盟","锡林郭勒盟","阿拉善盟","阜新",
                "铁岭","四平","辽源","通化","白山","松原",
                "白城","延边州","鸡西","鹤岗","双鸭山","伊春",
                "佳木斯","七台河","黑河","绥化","大兴安岭地区","蚌埠",
                "淮南","淮北","铜陵","安庆","黄山","滁州",
                "阜阳","宿州","六安","亳州","池州","宣城",
                "莆田","三明","南平","龙岩","宁德","景德镇",
                "萍乡","新余","鹰潭","赣州","吉安","宜春",
                "抚州","上饶","鹤壁","新乡","濮阳","许昌",
                "漯河","南阳","商丘","驻马店","黄石","十堰",
                "鄂州","荆门","孝感","黄冈","咸宁","随州",
                "恩施州","衡阳","邵阳","益阳","郴州","永州",
                "怀化","娄底","湘西州","梧州","防城港","钦州",
                "贵港","玉林","百色","贺州","河池","来宾",
                "崇左","广元","遂宁","内江","乐山","眉山",
                "广安","达州","雅安","巴中","资阳","阿坝州",
                "甘孜州","凉山州","六盘水","安顺","铜仁地区","毕节",
                "黔西南州","黔东南州","黔南州","保山","昭通","丽江",
                "临沧","楚雄州","红河州","文山州","西双版纳州","大理州",
                "德宏州","怒江州","迪庆州","昌都地区","山南地区","日喀则地区",
                "那曲地区","阿里地区","林芝地区","汉中","榆林","安康",
                "商洛","白银","天水","武威","张掖","平凉",
                "酒泉","庆阳","定西","陇南","临夏州","甘南州",
                "海东地区","海北州","黄南州","海南州","果洛州","玉树州",
                "海西州","吴忠","中卫","固原","吐鲁番地区","哈密地区",
                "昌吉州","博州","阿克苏地区","喀什地区","和田地区","伊犁哈萨克州",
                "塔城地区","阿勒泰地区","石河子","五家渠","克州","普洱",
                "襄阳","葫芦岛","河源","揭阳","辽阳","朝阳","丹东"
            };
            if (!City_Check_SplitSpace.Checked && !City_Check_Comma.Checked && !City_Check_Semicolon.Checked && !City_Check_SplitTab.Checked)
            {
                MessageBox.Show("请选择分隔符!!", "提示");
                return;
            }
            try
            {
                OpenFileDialog openMergeFile = new OpenFileDialog();
                #region 设置打开文件对话框
                //设置打开对话框的标题
                openMergeFile.Title = "请选择要合并的文件";
                //设置打开对话框可以多选
                openMergeFile.Multiselect = true;
                //设置对话框打开的文件类型
                openMergeFile.Filter = "csv文件|*.csv|文本文件|*.txt|所有文件|*.*";
                //设置文件对话框当前选定的筛选器的索引
                openMergeFile.FilterIndex = 1;
                //设置对话框是否记忆之前打开的目录
                openMergeFile.RestoreDirectory = true;
                #endregion

                if (openMergeFile.ShowDialog() == DialogResult.OK)
                {
                    #region 清空列表
                    if (!IsAppend.Checked) City_MergeFileList.Items.Clear();
                    City_CityList.Items.Clear();
                    #endregion
                    //获取用户选择的文件完整路径
                    if (IsAppend.Checked)
                        filePaths.InsertRange(filePaths.Count, openMergeFile.FileNames);
                    else
                        filePaths = openMergeFile.FileNames.ToList<string>();
                    string filePath = filePaths[0];
                    //获取对话框中所选文件的文件名和扩展名，文件名不包括路径
                    string fileName = openMergeFile.SafeFileName;
                    #region 加载城市列表
                    //读取全部行数,保存到string数组
                    string[] sStr = File.ReadAllLines(filePath);
                    char[] splitStr = SplitStr("City");
                    sArray = sStr[0].Split(splitStr);
                    sArrayCity = new string[sArray.Length - 3];
                    for (int i = 3; i < sArray.Length; i++)
                    {
                        sArrayCity[i - 3] = sArray[i];
                    }
                    if (IsLoadAllCitys.Checked)
                        City_CityList.Items.AddRange(sArrayCity);
                    else
                        City_CityList.Items.AddRange(ssArray);
                    #endregion

                    #region 加载文件列表
                    City_MergeFileList.Items.AddRange(openMergeFile.SafeFileNames);
                    #endregion
                    //全选城市
                    if (IsSelectAllCity.Checked)
                    {
                        for (int i = 0; i < City_CityList.Items.Count; i++)
                        {
                            City_CityList.SelectedItem = City_CityList.Items[i];
                        }
                    }
                    //全选文件
                    if (IsSelectAllFile.Checked)
                    {
                        for (int i = 0; i < City_MergeFileList.Items.Count; i++)
                        {
                            City_MergeFileList.SelectedItem = City_MergeFileList.Items[i];
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("文件被占用!", "报错");
            }
        }

        /// <summary>
        /// 开始合并按钮
        /// </summary>
        private void StartMerge(object sender, EventArgs e)
        {
            if (City_MergeFileList.Items.Count < 2)
            {
                MessageBox.Show("请选择至少两个合并的文件再进行合并!!!!", "提示!!");
                return;
            }
            if (City_CityList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个城市再进行合并!!!!", "提示!!");
                return;
            }
            string sss = "";//保存需要读取到文件的字符串
            bool[] IsHaveCity = new bool[1];
            string[] selectedFilePaths = new string[1];
            if (!IsMergeAll.Checked)
            {
                selectedFilePaths = new string[City_MergeFileList.SelectedIndices.Count];//已选择的文件路径
                for (int i = 0; i < City_MergeFileList.SelectedIndices.Count; i++)
                {
                    selectedFilePaths[i] = filePaths[City_MergeFileList.SelectedIndices[i]];
                }
            }
            string[] FPaths;
            int[] arrayIndex = new int[1];
            if (IsMergeAll.Checked)
                FPaths = filePaths.ToArray();
            else
            {
                FPaths = selectedFilePaths;
            }
            #region 分隔符
            char[] splitStr = SplitStr("City");

            char SplitStr2 = ',';
            if (City_Radio_SplitTab.Checked) SplitStr2 = '\t';
            else if (City_Radio_SplitSpace.Checked) SplitStr2 = ' ';
            else if (City_Radio_SplitComma.Checked) SplitStr2 = ',';
            else if (City_Radio_Semicolon.Checked) SplitStr2 = ';';
            #endregion
            try
            {
                if (IsAppendMergeFile.Checked) File.Delete(txt_saveMenu.Text);
                bool FirstFile = true;
                foreach (string R in FPaths)/*循环读文件*/
                {
                    using (StreamReader read = new StreamReader(R, Encoding.UTF8))
                    {
                        foreach (string SR in read.ReadToEnd().Split('\r'))//读全部行
                        {
                            if (SR != "" && SR != "\n" && SR != "\r")
                            {
                                string[] SSR = SR.Split(SplitStr("City"));//按分隔符分割后的结果
                                SSR = SSR.Where(x => x != "").ToArray();//去掉是空字符串的列
                                if (SSR[0] != "date")
                                {
                                    int.TryParse(SSR[0], out int iis);
                                    if (iis != 0) sss = sss + (iis / 10000).ToString() + "/" + ((iis % 10000) / 100).ToString() + "/" + (iis % 100).ToString() + SplitStr2;
                                    for (int i = 1; i < 3; i++)
                                    {
                                        sss = SSR.Length > i
                                            ? sss + SSR[i] + SplitStr2
                                            : sss + "0" + SplitStr2;
                                    }//把前面的三列先加进去
                                    int n = 0;
                                    foreach (int i in City_CityList.SelectedIndices)
                                    {
                                        sss = SSR.Length > i + 3 && IsHaveCity[n]
                                            ? sss + SSR[arrayIndex[n] + 3] + SplitStr2
                                            : sss + "0" + SplitStr2;
                                    }//加入已选定的城市列表
                                    sss = sss.Substring(0, sss.Length - 1);//去掉末尾的逗号
                                    sss += "\r";
                                }
                                else
                                {
                                    IsHaveCity = new bool[City_CityList.SelectedIndices.Count];
                                    arrayIndex = new int[City_CityList.SelectedIndices.Count];
                                    sArrayCity = new string[SSR.Length - 3];
                                    for (int i = 3; i < SSR.Length; i++)
                                    {
                                        sArrayCity[i - 3] = SSR[i];
                                    }
                                    int n = 0;
                                    foreach (int i in City_CityList.SelectedIndices)
                                    {
                                        if (Array.IndexOf(sArrayCity, City_CityList.Items[i].ToString()) != -1)
                                        {
                                            IsHaveCity[n] = true;
                                            arrayIndex[n] = Array.IndexOf(sArrayCity, City_CityList.Items[i].ToString());
                                        }
                                        else IsHaveCity[n] = false;
                                        n++;
                                    }//加入已选定的城市列表
                                    if ( FirstFile )
                                    {
                                        for (int i = 0; i < 3; i++)
                                        {
                                            sss = sss + SSR[i] + SplitStr2;
                                        }//把前面的三列先加进去
                                        
                                        foreach (int i in arrayIndex)
                                        {
                                            sss = sss + SSR[i + 3] + SplitStr2;
                                        }
                                        sss = sss.Substring(0, sss.Length - 1);
                                        sss += "\r";
                                    }
                                    if (!IsCheckReservations.Checked)
                                        FirstFile = false;
                                }
                            }
                            else//如果存在空行
                            {
                                continue;
                            }
                        }
                    }

                    sss = sss.Substring(0, sss.Length - 1);
                    string saveMenu = txt_saveMenu.Text;
                    StreamWriter sw = new StreamWriter(saveMenu, true);
                    sw.WriteLine(sss);
                    sw.Close();//写入
                    sss = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("报错了!!请检查!!\n"+ex.ToString(), "错误!!");
                OutLog("===========合并按钮===========");
                OutLog(ex.ToString(), true);
            }
        }

        /// <summary>
        /// 字符串分割符
        /// </summary>
        /// <returns>返回分隔符数组</returns>
        private char[] SplitStr(string IsCity)
        {
            char[] SplitStr = new char[1];
            switch (IsCity)
            {
                case "City":
                    if (City_Check_SplitTab.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = '\t';
                        if (City_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = '\t';
                            SplitStr[1] = ' ';
                            if (City_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (City_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (City_Check_SplitSpace.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ' ';
                        if (City_Check_SplitTab.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = '\t';
                            SplitStr[1] = ' ';
                            if (City_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (City_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (City_Check_Semicolon.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ';';
                        if (City_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = ';';
                            SplitStr[1] = ' ';
                            if (City_Check_SplitTab.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (City_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (City_Check_Comma.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ',';
                        if (City_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = ',';
                            SplitStr[1] = ' ';
                            if (City_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = ',';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (City_Check_SplitTab.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    break;
                case "Site":
                    if (Site_Check_SplitTab.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = '\t';
                        if (Site_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = '\t';
                            SplitStr[1] = ' ';
                            if (Site_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (Site_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (Site_Check_SplitSpace.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ' ';
                        if (Site_Check_SplitTab.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = '\t';
                            SplitStr[1] = ' ';
                            if (Site_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (Site_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (Site_Check_Semicolon.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ';';
                        if (Site_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = ';';
                            SplitStr[1] = ' ';
                            if (Site_Check_SplitTab.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = '\t';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (Site_Check_Comma.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    else if (Site_Check_Comma.Checked)
                    {
                        SplitStr = new char[1];
                        SplitStr[0] = ',';
                        if (Site_Check_SplitSpace.Checked)
                        {
                            SplitStr = new char[2];
                            SplitStr[0] = ',';
                            SplitStr[1] = ' ';
                            if (Site_Check_Semicolon.Checked)
                            {
                                SplitStr = new char[3];
                                SplitStr[0] = ',';
                                SplitStr[1] = ' ';
                                SplitStr[2] = ';';
                                if (Site_Check_SplitTab.Checked)
                                {
                                    SplitStr = new char[4];
                                    SplitStr[0] = '\t';
                                    SplitStr[1] = ' ';
                                    SplitStr[2] = ';';
                                    SplitStr[3] = ',';
                                }
                            }
                        }
                    }
                    break;
            }
            return SplitStr;
        }

        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="strLog">日志内容</param>
        /// <param name="append">是否追加日志内容</param>
        private void OutLog(string strLog, bool append = false)
        {
            string txt_FileInfo = "";
            txt_FileInfo = DateTime.Now.ToString("HH:mm:ss ") + strLog + "\r\n";

            StreamWriter sw = new StreamWriter(@"./Log.log", append);
            sw.WriteLine(txt_FileInfo);
            sw.Close();//写入
        }

        /// <summary>
        /// 开始合并站点
        /// </summary>
        private void StartMergeSite(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 选择保存目录
        /// </summary>
        private void SelectSaveMenu(object sender, EventArgs e)
        {
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "CSV UTF-8 (*.csv)|*.csv|文本文件（*.txt）|*.txt|所有文件（*.*）|*.*";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //设置默认的文件名
            sfd.FileName = "合并.csv";// in wpf is  sfd.FileName = "YourFileName";

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                txt_saveMenu.Text = localFilePath;

            }
        }

        /// <summary>
        /// 窗体加载时的初始化
        /// </summary>
        private void RootLoad(object sender, EventArgs e)
        {
            if (File.Exists(@"./Confingure.ini"))
            {
                using (StreamReader read = new StreamReader(@"./Confingure.ini", Encoding.UTF8))
                {
                    while (!read.EndOfStream)
                    {
                        string str = read.ReadLine().Trim(' ');
                        if (str.StartsWith("#") || str == "" || str == "\n" || str == "\r") continue;
                        else
                        {
                            if (str.StartsWith("saveMenu"))
                            {
                                txt_saveMenu.Text = str.Split('=')[1].Trim(' ');
                            }
                            if (str.StartsWith("IsSelectAllCity"))
                            {
                                IsSelectAllCity.CheckState = (CheckState)Enum.Parse(typeof(CheckState), str.Split('=')[1].Trim(' '));
                            }
                            if (str.StartsWith("IsSelectAllFile"))
                            {
                                IsSelectAllFile.CheckState = (CheckState)Enum.Parse(typeof(CheckState), str.Split('=')[1].Trim(' '));
                            }
                            if (str.StartsWith("IsAppend"))
                            {
                                IsAppend.CheckState = (CheckState)Enum.Parse(typeof(CheckState), str.Split('=')[1].Trim(' '));
                            }
                            if (str.StartsWith("IsAppendMergeFile"))
                            {
                                IsAppendMergeFile.CheckState = (CheckState)Enum.Parse(typeof(CheckState), str.Split('=')[1].Trim(' '));
                            }
                            if (str.StartsWith("IsLoadAllCitys"))
                            {
                                IsLoadAllCitys.CheckState = (CheckState)Enum.Parse(typeof(CheckState), str.Split('=')[1].Trim(' '));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 窗体关闭时的处理
        /// </summary>
        private void RootClose(object sender, FormClosingEventArgs e)
        {
            string Confingure = "# 作者:朱天浩\r\n# 宁波职业技术学院电信学院\r\n# 保存目录,值无需加\"\"\r\n" +
                "saveMenu = " + txt_saveMenu.Text + "\r\n# 打开文件后是否选择全部城市\r\n" +
                "IsSelectAllCity = " + IsSelectAllCity.CheckState + "\r\n# 打开文件后是否选择全部文件\r\n" +
                "IsSelectAllFile = " + IsSelectAllFile.CheckState + "\r\n# 打开文件后是否追加到已打开的文件列表\r\n" +
                "IsAppend = " + IsAppend.CheckState + "\r\n# 合并文件时是否追加内容\r\n" +
                "IsAppendMergeFile = " + IsAppendMergeFile.CheckState + "\r\n# 打开文件时加载全部城市还是第一个打开的文件中的城市\r\n" +
                "IsLoadAllCitys = " + IsLoadAllCitys.CheckState;
            StreamWriter sw = new StreamWriter(@"./Confingure.ini", false);
            sw.WriteLine(Confingure);
            sw.Close();//写入
        }

        /// <summary>
        /// 选择站点的ID文件
        /// </summary>
        private void SelectSiteID(object sender, EventArgs e)
        {
            OpenFileDialog openIDFile = new OpenFileDialog();
            #region 设置打开文件对话框
            //设置打开对话框的标题
            openIDFile.Title = "请选择要合并文件的编号文件";
            //设置打开对话框可以多选
            openIDFile.Multiselect = false;
            //设置对话框打开的文件类型
            openIDFile.Filter = "csv文件|*.csv|文本文件|*.txt|所有文件|*.*";
            //设置文件对话框当前选定的筛选器的索引
            openIDFile.FilterIndex = 1;
            //设置对话框是否记忆之前打开的目录
            openIDFile.RestoreDirectory = true;
            //设置默认的文件名
            openIDFile.FileName = "站点列表-2018.11.08起.csv";// in wpf is  sfd.FileName = "YourFileName";
            #endregion

            #region 分隔符
            char[] splitStr = SplitStr("Site");
            #endregion

            #region 清空
            Site_CityList.Items.Clear();
            Site_IDList.Items.Clear();
            Site_MergeFileList.Items.Clear();
            #endregion

            if (!City_Check_SplitSpace.Checked && !City_Check_Comma.Checked && !City_Check_Semicolon.Checked && !City_Check_SplitTab.Checked)
            {
                MessageBox.Show("请选择分隔符!!", "提示");
                return;
            }
            if (openIDFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    #region 加载城市列表
                    //读取全部行数,保存到string数组
                    string[] sStr = File.ReadAllLines(openIDFile.FileName);
                    sArrayCityID = new Dictionary<string, string>();
                    bool firstLine = true;
                    foreach (string i in sStr)
                    {
                        string[] si = i.Split(SplitStr("Site"));
                        if (firstLine)
                        {
                            firstLine = false;
                            continue;
                        }
                        Site_IDList.Items.Add(new ListViewItem(new string[] { si[2], si[0], si[1] }));
                        if (Site_CityList.Items.Contains(si[2])) { }
                        else
                            Site_CityList.Items.Add(si[2]);

                        sArrayCityID.Add(si[0], si[2]);
                    }

                    #region listview设置
                    Site_IDList.GridLines = true;//显示行与行之间的分隔线 
                    Site_IDList.FullRowSelect = true;//要选择就是一行 
                    Site_IDList.View = View.Details;//定义列表显示的方式
                    Site_IDList.Scrollable = true;//需要时候显示滚动条
                    Site_IDList.MultiSelect = true; // 不可以多行选择 
                    Site_IDList.Columns.Add("城市", 50, HorizontalAlignment.Left);//第一个参数，表头名，第2个参数，表头大小，第3个参数，列的样式
                    Site_IDList.Columns.Add("ID", 50, HorizontalAlignment.Left);
                    Site_IDList.Columns.Add("监测点名称", 100, HorizontalAlignment.Left);
                    #endregion
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("报错了!!!\n" + ex.ToString(), "错误");
                }
            }
        }


        /// <summary>
        /// 选择需要合并的文件
        /// </summary>
        private void SelectSiteMergeFile(object sender, EventArgs e)
        {

        }
    }
}
