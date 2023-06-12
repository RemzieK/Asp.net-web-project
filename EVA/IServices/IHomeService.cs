using EVA.Models;
using EVA.Services;

namespace EVA.IServices
{
    public interface IHomeService
    {
        Task<ApodDetailDto?> GetApodData(DateTime? date);
        AstronautsViewModel GetAstronautsViewModel();
        AboutUsViewModel GetAboutUsViewModel();
        GalaxiesViewModel GetGalaxiesViewModel();
        PlanetsViewModel GetPlanetsViewModel();
        IndexViewModel GetIndexViewModel();

    } 
}
