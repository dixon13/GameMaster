using System.Collections.Generic;

namespace GameMaster.Models
{
    public class Server
    {
        public int ServerId { get; set; } // Will need to be unique

        public string ServerName { get; set; } // Will need to be unique

        public Game Game { get; set; }

        public List<WorkshopItem> WorkshopItems { get; set; }

        // TODO: Configs attribute maybe setup a configs model

        public string Args { get; set; }
    }
}
