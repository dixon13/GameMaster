using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMaster.Models
{
    public class WorkshopItem
    {
        public int WorkshopID { get; set; }

        public string Name { get; set; }

        public DateTimeOffset DateDownloaded { get; set; }

        public int GameID { get; set; }
    }
}
