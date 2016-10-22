using myKmAdressBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace myKmAdressBook.Helper
{
    public class CsvConverter
    {
        public List<Adress> GetAdressData()
        {
            var adressList = File.ReadAllLines(@"C:\dev\myKmAdressBook\myKmAdressBook\Content\csvdata\Vendor.csv", Encoding.Default)
                .Skip(1)
                .Select(v => FromCsv(v))
                .ToList();
            return adressList; 
        }

        public Adress FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');

            var adress = new Adress();
            adress.CustumerId = values[0];
            adress.Name = values[1];
            adress.Postcode = values[2];
            adress.City = values[3];
            adress.Country = values[4];
            adress.Street = values[5];

            return adress; 
        }
    }
}