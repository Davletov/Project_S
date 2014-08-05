using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace FiilingData
{
    public class FillingCountryAndCity
    {
        public static void FillingCountriesWithCities()
        {
            using (var parser = new TextFieldParser(@"c:\Country.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        var tmp = field;
                    }
                }
            }
        }
    }
}