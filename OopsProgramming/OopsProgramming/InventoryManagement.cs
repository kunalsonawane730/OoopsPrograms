using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProgramming
{
    public class InventoryManagement
    {
        public void ReadData(string filepath)
        {
            try
            {
                //var json = JsonConvert.DeserializeObject<InventoryManagement>(filepath);
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Inventorydata>>(json);
                    Console.WriteLine("name\t" + "price\t" + "weight\t" + "total amount");
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight + "\t" + item.Price + "\t" + item.Weight);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
