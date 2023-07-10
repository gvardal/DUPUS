using Entities.Dtos;
using Services.Contracts;

namespace DUPUS_BLZR.Data
{
    public class ResourceGanttData
    {
        private readonly IServiceManager _manager;

        public ResourceGanttData(IServiceManager manager)
        {
            _manager = manager;
        }

        public List<ResourceData> GanttResources()
        {
            List<ResourceData> GanttResourcesCollection = new List<ResourceData>();
            var resources = _manager.KonumService.GanttResourceGroup(21);
            if (resources is not null)
            {
                foreach (var resource in resources)
                {
                    GanttResourcesCollection.Add(new ResourceData
                    {
                        ResourceId = resource.KonumID,
                        ResourceName = resource.Ad,
                        ResourceGroup = resource.KonumKodu
                    });
                }
            }
            return GanttResourcesCollection;
        }
    }
}
