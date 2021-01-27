using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAAutoFramework.Helpers
{
    public class XMLHelpers
    {

        public static IWebElement readObjectValues(String ObjectName)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string strIdentifier = null;
            string strValue = null;

            FileStream fs = new FileStream("C:\\Users\\ayanc\\source\\repos\\CompleteSection\\EATestProject\\ObjectProperties.xml", FileMode.Open, FileAccess.Read);

            //string strFilename = "C:\\Users\\ayanc\\Desktop\\VSProject\\OldWorkingFramework\\CoreAutomationFramework\\ObjectProperties.xmlObjectProperties.xml";

            /*FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);*/

            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Object");

            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                if (ObjectName.Equals(xmlnode[i].ChildNodes.Item(0).InnerText.Trim()))
                {
                    strIdentifier = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                    strValue = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                    //MessageBox.Show(str);
                }
            }

            IWebElement objReturn = null;
            switch (strIdentifier)
            {
                case "id":
                    objReturn = DriverContext.Driver.FindElement(By.Id(strValue));

                    break;
                case "xpath":
                    objReturn = DriverContext.Driver.FindElement(By.XPath(strValue));

                    break;

                default:
                    break;
            }

            return objReturn;

        }

    }
}
