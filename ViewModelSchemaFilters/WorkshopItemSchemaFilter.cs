namespace GameMaster.ViewModelSchemaFilters
{
    using System;
    using GameMaster.ViewModels;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class WorkshopItemSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext context)
        {
            model.Default = new WorkshopItem()
            {
                WorkshopId = 1,
                Name = "Unkown",
                DateDownloaded = DateTimeOffset.Now,
                GameID = -1
            };
        }
    }
}
