using System.Threading.Tasks;

namespace KarYonSistemi
{
    public interface IGonderiHizmetSaglayicisi
    {
        Task KargoGonder(Gonderi shipmentInfo);
        Task GonderiSurecleriniYonet(Gonderi shipmentInfo, GonderiHizmetSaglayicisi deliveryService);
    }
}