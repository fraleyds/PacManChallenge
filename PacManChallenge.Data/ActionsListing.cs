using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacManChallenge.Data
{
    public class ActionsListing
    {
        //public string FilePath { get; set; }

        //// Constructor including ability to change file path means only code in console app needs changing to run a different set of data
        //public ActionsListing(string filePath)
        //{
        //    this.FilePath = filePath;
        //}

        // File Path being specified in Method allows for potentially multiple files to be read
        public string[] GetActionsArray(string filePath)
        {
            var initArray = File.ReadAllLines(filePath);
            var realArray = Regex.Split(initArray[0], ",");
            return realArray;
        }
    }
}