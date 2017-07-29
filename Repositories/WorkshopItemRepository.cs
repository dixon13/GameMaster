using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameMaster.Models;

namespace GameMaster.Repositories
{
    public class WorkshopItemRepository : IWorkshopItemRepository
    {
        private static readonly List<WorkshopItem> workshopItems;

        static WorkshopItemRepository()
        {
            // can create a new list here
            //workshopItems = new List<WorkshopItem>()
            //{
            //    new WorkshopItem()
            //    {
            //        WorkshopId = 1,
            //        Name = "game name",
            //        DateDownloaded = DateTimeOffset.UtcNow,
            //        GameID = 000000
            //    }
            //};
        }

        public Task<WorkshopItem> Add(WorkshopItem workshopItem)
        {
            workshopItems.Add(workshopItem);
            workshopItem.WorkshopId = workshopItems.Max(x => x.WorkshopId) + 1;
            return Task.FromResult(workshopItem);
        }

        public Task Delete(WorkshopItem workshopItem)
        {
            if (workshopItems.Contains(workshopItem))
            {
                workshopItems.Remove(workshopItem);
            }
            return Task.FromResult(0);
        }

        public Task<WorkshopItem> Get(int workshopItemId)
        {
            var workshopItem = workshopItems.FirstOrDefault(x => x.WorkshopId == workshopItemId);
            return Task.FromResult(workshopItem);
        }

        public Task<ICollection<WorkshopItem>> GetPage(int page, int count)
        {
            var pageWorkshopItems = workshopItems
                .Skip(count * (page - 1))
                .Take(count)
                .ToList();
            if (pageWorkshopItems.Count == 0)
            {
                pageWorkshopItems = null;
            }

            return Task.FromResult((ICollection<WorkshopItem>)pageWorkshopItems);
        }

        public Task<int> GetTotalPages(int count)
        {
            var totalPages = (int)Math.Ceiling(workshopItems.Count / (double)count);
            return Task.FromResult(totalPages);
        }

        public Task<WorkshopItem> Update(WorkshopItem workshopItem)
        {
            var existingWorkshopItem = workshopItems.FirstOrDefault(x => x.WorkshopId == workshopItem.WorkshopId);
            existingWorkshopItem.Name = workshopItem.Name;
            existingWorkshopItem.DateDownloaded = workshopItem.DateDownloaded;
            existingWorkshopItem.GameID = workshopItem.GameID;
            return Task.FromResult(workshopItem);
        }
    }
}
