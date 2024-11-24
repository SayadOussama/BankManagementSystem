using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement.ClassGlobal
{
    internal static  class clsGlobal
    {

        public static clsUsers CurrentUser;


        public static bool RemeberUsernameAndPassWord(string UserName , string PassWord)
        {
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePath = CurrentDirectory + "\\Data.txt";

                //incase the Username is Empty , will Delete the txt file 
                if (UserName == "" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
                //doing seperator bitween the UserName And PassWord 
                string DataToSave = UserName + "#//#" + PassWord;

                //create SteamWriter that Will Write DataToSave To File 

                // txt Directory 
                //will save txt file in bin Folder where Debugging
                using (StreamWriter Writer = new StreamWriter(filePath))
                {
                    //Writing Process 
                    Writer.WriteLine(DataToSave);
                    return true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"an  Error Occurent : {ex.Message} ");
                return false;
            }


            }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            try
            {//will go TO the Directory Folder 
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                string filePath = CurrentDirectory + "\\data.txt";
                //check File Exist after Reading
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read Date Line by Line Until the end Of file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Read Each Line 
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);//will devide the string when they Reach to the Split "#//#"
                            UserName = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false; 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurent : {ex.Message}");
                return false;
            }
        }







        }


    }

