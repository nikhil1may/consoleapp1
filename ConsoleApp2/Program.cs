using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    /* You may add helper classes here if necessary */

    public class Program
    {
        public static List<String> processData(
                                        IEnumerable<string> lines)
        {
            List<InputParams> inputParamsList = new List<InputParams>();
            foreach (var line in lines)
            {
                var setline = line.Split(',');
                inputParamsList.Add(new InputParams { Product = setline[0], LibraryName = setline[1], LibraryVersion = int.Parse(setline[2].ToLower().Replace("v", "")) });
            }
            inputParamsList = inputParamsList.OrderByDescending(a => a.LibraryVersion).OrderBy(a => a.LibraryName).ToList();

            List<String> retVal = new List<String>();
            string CurrentLibName = null;
            foreach (var inputList in inputParamsList)
            {
                if (CurrentLibName != inputList.LibraryName)
                {
                    if (!retVal.Contains(inputList.Product.ToString()))
                        retVal.Add(inputList.Product);
                    CurrentLibName = inputList.LibraryName;
                }
            }

            return retVal;
        }
        static void Main1(string[] args)
        {

        }

       
            static void Main(string[] args)
        {



            var foo = new { Wheels = 4 };












            try
            {









                Class2 class2 = new Class2();
             
                String line;
                //var inputLines = new List<String>();
                //while ((line = Console.ReadLine()) != null)
                //{
                //    line = line.Trim();
                //    if (line != "")
                //        inputLines.Add(line);
                //}
                var inputLines = new List<String>();
                inputLines.Add("Mail Server, Authentication Library, v6");
                inputLines.Add("Video Call Server, Authentication Library, v7");
                inputLines.Add("Mail Server, Data Storage Library, v10");
                inputLines.Add("Chat Server, Data Storage Library, v11");
                inputLines.Add("Mail Server, Search Library, v6");
                inputLines.Add("Chat Server, Authentication Library, v8");
                inputLines.Add("Chat Server, Search Library, v7");
                inputLines.Add("Video Call Server, Data Storage Library, v10");
                inputLines.Add("Video Call Server, Video Compression Library, v3");
                var retVal = processData(inputLines);
                foreach (var res in retVal)
                    Console.WriteLine(res);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public class InputParams
    {
        public string Product { get; set; }
        public string LibraryName { get; set; }
        public int LibraryVersion { get; set; }
    }

    public class Car { int wheels { get; set; } 
        protected  Car()
        {

        }
    }
}