using System.Collections.Generic;

namespace GameMaster.Models
{
    public class Game
    {
        public int AppID { get; set; }

        public string GameName { get; set; }

        public List<WorkshopItem> WorkshopItems { get; set; }
    }
}
