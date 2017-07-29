namespace GameMaster.ViewModelSchemaFilters
{
    using GameMaster.ViewModels;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class SaveWorkshopItemSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext Context)
        {
            model.Default = new SaveWorkshopItem()
            {
                Name = "Unknown",
                GameID = -1
            };
        }
    }
}
