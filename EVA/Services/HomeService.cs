using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class HomeService : IHomeService
    {
        private readonly ApodService _apodService;
        private readonly IAstronautsService _astronautsService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IGalaxiesService _galaxiesService;
        private readonly IPlanetsService _planetsService;
        private readonly IIndexService _indexService;

        public HomeService(ApodService apodService, IAstronautsService astronautsService, IAboutUsService aboutUsService, IGalaxiesService galaxiesService, IPlanetsService planetsService, IIndexService indexService)
        {
            _apodService = apodService;
            _astronautsService = astronautsService;
            _aboutUsService = aboutUsService;
            _galaxiesService = galaxiesService;
            _planetsService = planetsService;
            _indexService = indexService;
        }
        public Task<ApodDto?> GetApodData()
        {

            return _apodService.GetApodData();
        }

        public AstronautsViewModel GetAstronautsViewModel()
        {

            return _astronautsService.GetAstronautsViewModel();
        }

        public AboutUsViewModel GetAboutUsViewModel()
        {

            return _aboutUsService.GetAboutUsViewModel();
        }

        public GalaxiesViewModel GetGalaxiesViewModel()
        {

            return _galaxiesService.GetGalaxiesViewModel();
        }
        public PlanetsViewModel GetPlanetsViewModel()
        {

            return _planetsService.GetPlanetsViewModel();
        }
        public IndexViewModel GetIndexViewModel()
        {

            return _indexService.GetIndexViewModel();
        }
    }
}
