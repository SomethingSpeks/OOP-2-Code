﻿using System;

namespace OOP_2_Code
{
    class Program
    {
    //VARIABLE ASSIGNMENT
        //strings to be compared
        public static string str1, str2;
        //files to be read
        public static string fileName1, fileName2;

        static void Main()
        {
            //Asks user for input, string first is created and assigned as the users input
            //\n is used for formatting
            Console.WriteLine("Please select first file to read \n GitRep_1a [1] \n GitRep_2a [2] \n GitRep_3a [3]");
            string first = Console.ReadLine();

            //if the user hasnt selected an appropriate option and the value for first isnt recognized, the previous segment is repeated
            while (first != "1" && first != "2" && first != "3")
            {
                Console.WriteLine("Please select first file to read \n GitRep_1a[1] \n GitRep_2a[2] \n GitRep_3a[3]");
                first = Console.ReadLine();
            }

    //FIRST SWITCH
            //First switch used to set the appropriate target file to be used for comparison
            switch(first)
            {
                //in all files the @"filename.txt" is the location of the file, the @ makes it useable in variables
                case "1":
                    fileName1 = @"GitRepositories_1a.txt";
                    break;
                case "2":
                    fileName1 = @"GitRepositories_2a.txt";
                    break;
                case "3":
                    fileName1 = @"GitRepositories_3a.txt";
                    break;
            }
            //executes a void in the FileReader class using the filename set 
            FileReader.SetFile(fileName1);
            //sets str1 to be a string assigned in the previous void
            str1 = FileReader.temp;
            //line to ensure user the file has been read
            Console.WriteLine(fileName1,  "File has been read \n");

            //Asks user for input, string second is created and assigned as the users input
            //\n is used for formatting
            Console.WriteLine("Please select second file to read GitRep_1b [1] GitRep_2b [2] GitRep_3b [3]");
            string second = Console.ReadLine();
            //if the user hasnt selected an appropriate option and the value for second isnt recognized, the previous segment is repeated
            while (second != "1" && second != "2" && second != "3")
            {
                Console.WriteLine("Please select second file to read GitRep_1b [1] GitRep_2b [2] GitRep_3b [3]");
                second = Console.ReadLine();
            }
    //SECOND SWITCH
            //Second switch used to set the appropriate target file to be compared against the first
            switch (second)
            {
                //in all files the @"filename.txt" is the location of the file, the @ makes it useable in variables
                case "1":
                    fileName2 = @"GitRepositories_1b.txt";
                    break;
                case "2":
                    fileName2 = @"GitRepositories_2b.txt";
                    break;
                case "3":
                    fileName2 = @"GitRepositories_3b.txt";
                    break;
            }
            //executes a void in the FileReader class using the filename set 
            FileReader.SetFile(fileName2);
            //sets str2 to be a string assigned in the previous void, used as a temporary value in FileReader
            str2 = FileReader.temp;
            Console.WriteLine("File has been read \n");
    //COMPARISON
            //essentially a bool, but assigned as an int because of how the string.compare function works
            int a = string.Compare(str1, str2);
            //0 equals false, meaning there are no differences..
            if (a==0)
            {
            //...as such, the line returned reflects this.
                Console.WriteLine("there are no differences between these files");
            }
            //any value other than zero (though should only be 1) means there is a difference...
            else
            {
                //...and again, the line reflects this.
                Console.WriteLine("There Are differences between these files");
            }
        }
    }
}
