using EVA.Models;

namespace EVA.IServices
{
    public interface IHomeService
    {
        Task<ApodDto?> GetApodData();
        AstronautsViewModel GetAstronautsViewModel();
        AboutUsViewModel GetAboutUsViewModel();
        GalaxiesViewModel GetGalaxiesViewModel();
        PlanetsViewModel GetPlanetsViewModel();
        IndexViewModel GetIndexViewModel();
    }
}
