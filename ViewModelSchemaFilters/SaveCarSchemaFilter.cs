namespace GameMaster.ViewModelSchemaFilters
{
    using GameMaster.ViewModels;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class SaveCarSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext context)
        {
            model.Default = new SaveCar()
            {
                Cylinders = 6,
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
