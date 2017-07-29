namespace GameMaster.ViewModels
{
    using System;
    using GameMaster.ViewModelSchemaFilters;
    using Swashbuckle.AspNetCore.SwaggerGen;

    [SwaggerSchemaFilter(typeof(WorkshopItemSchemaFilter))]
    public class WorkshopItem
    {
        public int WorkshopId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset DateDownloaded { get; set; }

        public int GameID { get; set; }
    }
}
