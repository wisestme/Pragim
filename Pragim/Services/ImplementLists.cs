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
    }

    class Churches
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pastor { get; set; }
        public string Location { get; set; }
    }
}
