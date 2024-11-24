using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using System.Web;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BankManagement.ClassGlobal
{
    public  class clsUtil
    {
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static bool CreateFolderIFDoesNotExist(string FolderPath)
        {
            if(!Directory.Exists(FolderPath))
            {
                try
                { 
                    //if the Directory Not Exist  , will Create the Folder 
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error Creation Folder "+ ex.Message);
                    return false;
                }
            }
            return true ;
        }
        public static string ReplaceFileNameWithGUID(string SourceFile)
        {
            // Change File Name To Guid 
            string fileName = SourceFile;
            FileInfo fi = new FileInfo(fileName);
            string Exten = fi.Extension;
            return GenerateGUID() + Exten;


        }
         // function will copy the Image you Select to Another Folder
         public static bool CopyProjectImageToOtherFoler(ref string sourcefile)
        {

            string DestinationFolder = @"C:\Banak-Management-People-Images\";

            if(!CreateFolderIFDoesNotExist(DestinationFolder))
            {
                return false ;
            }
            string destinationfile = DestinationFolder + ReplaceFileNameWithGUID(sourcefile);

            //copy file 
            try
            {
                File.Copy(sourcefile, destinationfile, true);
            }
            catch(IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            // return new sourcefile with GUID by ref 
            sourcefile = destinationfile;
            return true ;
        }




    }
}
