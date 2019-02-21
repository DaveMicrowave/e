using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ClassLibrary7
{
    [ComVisible(true)] // Don't forget 
    [ClassInterface(ClassInterfaceType.AutoDual)] // these two lines
    [Guid("485B98AF-53D4-4148-B2BD-CC3920BF0ADF")] // or this GUID
    public class Class1
    {

        public String GetDirectory()
        {
            string ret = "";
            Type myType = typeof(Class1);
            string username = System.Environment.UserName;
            ret = "C:\\Users\\" + username + "\\source\\repos\\" + myType.Namespace + "\\" + myType.Namespace + "\\bin\\debug\\";

            return ret;
        }

        public String WriteFiles(String arg2)
        {
            string[] files = Directory.GetFiles(GetDirectory(), "*.txt", SearchOption.AllDirectories);
            string message = arg2;
            string success = "Success!";
            foreach (string file in files)
            {
                //Console.WriteLine(file + "  Has been written!");
                File.WriteAllText(file, message);
            }

            return success;
        }
    }
}
