using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSProject
{
    class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = { ", " };

            if (File.Exists(path))
            {
                
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        /* using streamreader to read a line and split the line using "," as a seperator...
                         * ...any empty space in the line is removed. 
                         * assign each of the separated words into result Array of String type...E.g., 
                         * Word1, Word2 --> result[0] then result[1] respectively... 
                         */
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

                        /* if content of array in result[1] is Manager...   
                         * ...then add new Manager object (and it's name result[0]) into myStaff of Staff Class List.
                         * else if resut[1] is Admin then...
                         * ...then add new Admin object (and it's name result[0]) into myStaff of Staff Class List.
                         */

                        //James, Manager
                        if (result[1] == "Manager")
                        {
                            myStaff.Add(new Manager(result[0]));
                        }
                        else if (result[1] == "Admin")
                        {
                            myStaff.Add(new Admin(result[0]));
                        }

                        sr.Close();
                    }
                }
            }
            else
                Console.WriteLine("File doesn't exist");

            return myStaff;
        }
    }
}
