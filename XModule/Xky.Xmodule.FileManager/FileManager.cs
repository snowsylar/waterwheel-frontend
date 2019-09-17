﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xky.Core.Model;

namespace Xky.XModule.FileManager
{
    class FileManager : Core.XModule
    {
       
        public override string Description()
        {
            return "管理手机上的所有文件";
        }

        public override byte[] Icon()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Xky.XModule.FileManager.icon.png");
            if (myStream != null)
            {
                byte[] bytes = new byte[myStream.Length];
                myStream.Read(bytes, 0, bytes.Length);
                return bytes;
            }
            else
            {
                Console.WriteLine("模块图标路径有误，无法加载！");
                return null;
            }
        }

        public override bool IsBackground()
        {
            return false;
        }

        public override string Name()
        {
            return "文件管理器";
        }

        public override void Start()
        {
           
        }
        public override bool ShowUserControl()
        {
           
            var panel = new ModulePanel();
            panel.devices = Devices;
            Core.Client.ShowDialogPanel(panel);
            return true;
        }
    }
}