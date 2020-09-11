using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    class ImplementLists
    {
        public void ListOfChurches()
        {
            List<Churches> churchesList = new List<Churches>();
            churchesList.Add(new Churches() { ID = 0, Name = "Household", Pastor = "Chris Okotie", Location = "Oregun, Lagos" });
            churchesList.Add(new Churches() { ID = 1, Name = "Latter Rain", Pastor = "Tunde Bakare", Location = "Oregun Lagos"});
            churchesList.Add(new Churches() { ID = 3, Name = "Daystar", Pastor = "Sam Adeyemi", Location = "Oregun, Lagos" });
        }

        public void LagosMarketsList ()
        {
            List<LagosMarkets> lagosMarkets = new List<LagosMarkets>();

            lagosMarkets.Add(new LagosMarkets() { ID = 1, Name = "Mile 12", Products = "Food Stuffs", Size = "50,000 shops" });
            lagosMarkets.Add(new LagosMarkets() { ID = 2, Name = "Alaba", Products = "Electronics", Size = "100,000 shops" });
            lagosMarkets.Add(new LagosMarkets() { ID = 3, Name = "Oshodi", Products = "Variety", Size = "200,000 shops"});
        }

        public void ListOfMalls()
        {
            List<LagosMalls> lagosMalls = new List<LagosMalls>();

            lagosMalls.Add(new LagosMalls() { ID = 1, Name = "Ikeja City Mall", Capacity = "70,000 Shops", Location = "Alausa, Ikeja" });
            lagosMalls.Add(new LagosMalls() { ID = 3, Name = "Maryland Mall", Capacity = "10,000 shops", Location = "Maryland" });
        }
          
    }

    class Churches
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pastor { get; set; }
        public string Location { get; set; }
    }

    class LagosMarkets
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Products { get; set; }
        public string Size { get; set; }
    }

    class LagosMalls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Capacity { get; set; }
    }
}
