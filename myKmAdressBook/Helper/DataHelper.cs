using myKmAdressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myKmAdressBook.Helper
{
    public static class DataHelper
    {
        public static List<Adress> GetUniqueItems(List<Adress> databaseItems, List<Adress> csvItems)
        {
            foreach(Adress adress in csvItems)
            {
                var found = databaseItems.FirstOrDefault(o => o.CustumerId == adress.CustumerId);
                if(found == null)
                {
                    databaseItems.Add(adress); 
                }
            }
            return databaseItems; 
        }
    }
}