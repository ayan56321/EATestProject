﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace EAAutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;
            XPathItem timeOut;

            //string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";

            string strFilename= "C:\\Users\\ayanc\\source\\repos\\CompleteSection\\EATestProject\\GlobalConfig.xml";

            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            aut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/AUT");
            buildname = navigator.SelectSingleNode("EAAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("EAAutoFramework/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("EAAutoFramework/RunSettings/LogPath");
            timeOut = navigator.SelectSingleNode("EAAutoFramework/RunSettings/TimeOut");

            //Set XML Details in the property to be used accross framework
            Settings.AUT = aut.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
            Settings.TimeOut = timeOut.Value.ToString();
        }


    }
}
