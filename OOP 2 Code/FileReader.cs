using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_2_Code
{
    class FileReader
    {
        //sets a public variable to be used to used as a temp string
        public static string temp;

        //void set to only use the sting in program (@"filename"), only reads the file and assigns its content to the temp string
        public static void SetFile(string toRead)
        {
            try
            {
                //using the toRead value and StreamReader, a file is found at the file address and read if possible
                using (StreamReader sr = new StreamReader(toRead))
                {
                    //string used to store the entire file's content through ReadToEnd
                    temp = sr.ReadToEnd();
                }
            }
            //any exceptions are reported, e.g.incorrect value for toRead
            catch (Exception E)
            {
                //the built in system returns the message created through the catch
                Console.WriteLine("exception: " + E.Message);
            }
        }
    }
}
