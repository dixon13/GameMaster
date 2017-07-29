using System.ComponentModel.DataAnnotations;
using GameMaster.ViewModelSchemaFilters;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace GameMaster.ViewModels
{
    [SwaggerSchemaFilter(typeof(SaveWorkshopItemSchemaFilter))]
    public class SaveWorkshopItem
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int GameID { get; set; }
    }
}
