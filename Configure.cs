using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HavPlayer
{
    public class Configure
    {
        #region XML配置变量
        /// <summary>登录用户名</summary>
        public static string LoginName;

        /// <summary>登录密码</summary>
        public static string LoginPassword;

        /// <summary>左部列表分类按钮字符串</summary>
        public static string FenLei;

        /// <summary>左部列表分类按钮字符串</summary>
        public static string FenLeiVip;

        /// <summary>左部列表分类按钮字符串</summary>
        public static bool SavePassword;

        /// <summary>左部列表分类按钮字符串</summary>
        public static string PasswordTxt;

        /// <summary>类型筛选</summary>
        public static string SxNrong;

        /// <summary>服务器盘符</summary>
        public static string HardDisk;

        /// <summary>服务器名称</summary>
        public static string ServerName;

        /// <summary>服务器IP地址</summary>
        public static string ServerIP = "192.168.2.60";

        /// <summary>数据库名称</summary>
        public static string DataName;

        /// <summary>数据库登录用户</summary>
        public static string DataUser;

        /// <summary>数据库登录密码</summary>
        public static string DataPassword;

        /// <summary>数据库连接字符串</summary>
        public static string DataConstr;
        #endregion

        /// <summary>
        /// 读取Xml文件
        /// </summary>
        public void Read()
        {
            XmlDocument doc = new XmlDocument();//1.创建对象
            doc.Load("Config.xml"); //2.加载文件
            XmlNodeList xml_catalog = doc.SelectNodes("/User/Inis/Catal");
            for (int i = 0; i < xml_catalog.Count; i++)
            {
                switch (xml_catalog[i].Attributes["Name"].Value)
                {
                    case "LoginName":
                        LoginName = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "LoginPassword":
                        LoginPassword = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "SavePassword":
                        SavePassword = Convert.ToBoolean(xml_catalog[i].Attributes["Value"].Value);
                        break;
                    case "PasswordTxt":
                        PasswordTxt = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "FenLei":
                        FenLei = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "FenLeiVip":
                        FenLeiVip = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "SxNrong":
                        SxNrong = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "HardDisk":
                        HardDisk = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    //-----------------------------------

                    case "ServerName":
                        ServerName = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "ServerIP":
                        ServerIP = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "DataName":
                        DataName = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "DataUser":
                        DataUser = xml_catalog[i].Attributes["Value"].Value;
                        break;
                    case "DataPassword":
                        DataPassword = xml_catalog[i].Attributes["Value"].Value;
                        break;
                }
            }
            DataConstr = "Data Source = " + ServerIP + ";Initial Catalog = " + DataName + "; User ID = " + DataUser + ";Password=" + DataPassword;
        }

        /// <summary>
        /// 更新Xml文件
        /// </summary>
        public void Update()
        {
            XmlDocument doc = new XmlDocument();//1.创建对象
            doc.Load("Config.xml"); //2.加载文件
            XmlNodeList xml_catalog = doc.SelectNodes("/User/Inis/Catal");
            for (int i = 0; i < xml_catalog.Count; i++)
            {
                switch (xml_catalog[i].Attributes["Name"].Value)
                {
                    case "LoginName":
                        xml_catalog[i].Attributes["Value"].Value = LoginName;
                        break;
                    case "LoginPassword":
                        xml_catalog[i].Attributes["Value"].Value = LoginPassword;
                        break;
                    case "FenLei":
                        xml_catalog[i].Attributes["Value"].Value = FenLei;
                        break;
                    case "FenLeiVip":
                        xml_catalog[i].Attributes["Value"].Value = FenLeiVip;
                        break;
                    case "SavePassword":
                        xml_catalog[i].Attributes["Value"].Value = SavePassword.ToString();
                        break;
                    case "PasswordTxt":
                        xml_catalog[i].Attributes["Value"].Value = PasswordTxt;
                        break;
                    case "SxNrong":
                        xml_catalog[i].Attributes["Value"].Value = SxNrong;
                        break;
                    case "HardDisk":
                        xml_catalog[i].Attributes["Value"].Value = HardDisk;
                        break;
                    case "ServerName":
                        xml_catalog[i].Attributes["Value"].Value = ServerName;
                        break;
                    case "ServerIP":
                        xml_catalog[i].Attributes["Value"].Value = ServerIP;
                        break;
                    case "DataName":
                        xml_catalog[i].Attributes["Value"].Value = DataName;
                        break;
                    case "DataUser":
                        xml_catalog[i].Attributes["Value"].Value = DataUser;
                        break;
                    case "DataPassword":
                        xml_catalog[i].Attributes["Value"].Value = DataPassword;
                        break;
                }
            }
            doc.Save("Config.xml");
        }

        /// <summary>
        /// 更新XML文件
        /// </summary>
        /// <param name="name">字段名称</param>
        /// <param name="val">字段的值</param>
        public void Update(string name, string val)
        {
            XmlDocument doc = new XmlDocument();//1.创建对象
            doc.Load("Config.xml"); //2.加载文件
            XmlNodeList xml_catalog = doc.SelectNodes("/User/Inis/Catal");
            for (int i = 0; i < xml_catalog.Count; i++)
            {
                if (xml_catalog[i].Attributes["Name"].Value == name)
                {
                    xml_catalog[i].Attributes["Value"].Value = val;
                }
            }
            doc.Save("Config.xml");
        }

    }
}
