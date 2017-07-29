using System.Collections.Generic;
using System.Threading.Tasks;
using GameMaster.Models;

namespace GameMaster.Repositories
{
    public interface IWorkshopItemRepository
    {
        Task<WorkshopItem> Add(WorkshopItem workshopItem);

        Task Delete(WorkshopItem workshopItem);

        Task<WorkshopItem> Get(int workshopItemId);

        Task<ICollection<WorkshopItem>> GetPage(int page, int count);

        Task<int> GetTotalPages(int count);

        Task<WorkshopItem> Update(WorkshopItem workshopItem);
    }
}
