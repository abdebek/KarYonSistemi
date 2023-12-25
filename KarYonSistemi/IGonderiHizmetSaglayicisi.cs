using System.Threading.Tasks;

namespace KarYonSistemi
{
    public interface IGonderiHizmetSaglayicisi
    {
        Task KargoGonder(Gonderi gonderi);
        Task GonderiSurecleriniYonet(Gonderi gonderi, GonderiHizmetSaglayicisi gonderiHizmetSaglayicisi);
    }
}