using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class IndexService : IIndexService
    {
        public IndexViewModel GetIndexViewModel()
        {
            var index = new IndexViewModel
            {
                WelcomeMessage = "Welcome to EVA",
                ExperienceTitle = "Experience a spacewalk on Earth!",
                ExperienceText = "At EVA, we are passionate about all things space-related, so our website features a wide range of content for all space-fans. So what are you waiting for? Come and explore the wonders of space with EVA!",
                SignInTitle = "Sign in now!",
                SolarTitle = "Our solar system",
                SolarText = "Get to know more about our solar system. The eight planets Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, and Neptune.",
                ReadMoreButton = "READ MORE",
                GalaxiesTitle = "Galaxies",
                GalaxiesText = "Get to know the galaxies. A hude collection of gas, dust, and billions of stars and their solar system, all held together by gravity.",
                AstronautsTitle = "Astronauts",
                AstronautsText = "Get to know the person trained, equipped and deployed by a human spaceflight program to serve as a commander or a crew member abroad a spacecraft.",
                ApodTitle = "Astronomy Picture of the Day",
                ApodOneTitle = "Vast Collection of Astronomical Images",
                ApodOneText = "APOD has amassed a vast collection of stunning astronomical images since its launch in 1995. With over 10,000 featured images to date, it offers a visual journey through the cosmos.",
                ApodTwoTitle = "Educational and Informative Content",
                ApodTwoText = "APOD not only presents captivating visuals but also provides educational and informative descriptions written by astronomers. These explanations delve into the scientific concepts and phenomena depicted in the images, making it an excellent resource for both astronomy enthusiasts and those seeking to learn more about the universe. ",
                ApodThreeTitle = "Community Engagement and Global Reach",
                ApodThreeText = "APOD has a dedicated following worldwide and has become a hub for space enthusiasts and professionals alike. It encourages community engagement through its comment section, where users can discuss and share their thoughts about the featured images.",
                AboutUsTitle = "About us",
                AboutUsText = "Eva is a captivating website dedicated to space enthusiasts, offering a mesmerizing array of content centered around planets, galaxies, and astronauts. With a focus on providing a wealth of information and breathtaking imagery, Eva serves as a hub for fans of space exploration.",
            };
            return index;
        }
    }
}
