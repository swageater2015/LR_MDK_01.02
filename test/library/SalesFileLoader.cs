using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class SalesFileLoader
    {
        public List<Sales> Load()
        {
            List<Sales> result = new List<Sales>();
            StreamReader sr = new StreamReader("TestFile.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] UserInformation = line.Split(' ');
                Sales sale = new Sales();
                result.Add(sale);
            }
            return result;
        }
        
    }
}
