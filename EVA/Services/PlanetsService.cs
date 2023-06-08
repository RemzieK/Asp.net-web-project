using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class PlanetsService : IPlanetsService
    {
        public PlanetsViewModel GetPlanetsViewModel()
        {
            var planet = new PlanetsViewModel
            {
                WelcomeMessage = "Welcome to Eva",
                SolarName = "Оur solar system",
                PlanetsTitle = "Planets",
                MercuryName = "Mercury",
                VenusName = "Venus",
                EarthName = "Earth",
                MarsName = "Mars",
                JupiterName = "Jupiter",
                SaturnName = "Saturn",
                UranusName = "Uranus",
                NeptuneName = "Neptune",
                
                BlogText = "Four unique, rocky worlds, two complex gas giants and two distant ice giants.",
                BlogOneTitle = "Diverse Planetary Composition",
                BlogOneText = "Planets exhibit a wide range of compositions. Some are predominantly rocky, like Earth, while others are predominantly gaseous, such as Jupiter and Saturn. This diversity in composition is due to variations in the formation process and conditions within different regions of the protoplanetary disk.",
                BlogTwoTitle = "Orbits and Habitability",
                BlogTwoText = "The orbits of planets around their parent stars play a crucial role in determining their habitability. The distance from the star affects the planet's temperature, presence of liquid water, and potential for supporting life. The concept of the habitable zone, also known as the Goldilocks zone, refers to the range of distances where conditions could be favorable for the existence of liquid water and potentially life as we know it.",
                BlogThreeTitle = "Planetary Interactions and System Dynamics",
                BlogThreeText = "Planets interact with each other and influence the overall dynamics of their solar systems. For example, gravitational interactions between planets can cause orbital changes, including eccentricities, resonances, and even orbital instabilities. These interactions shape the long-term evolution of planetary systems and can lead to phenomena such as planetary migration, formation of gaps in debris disks, and even ejections of planets from their original orbits.",
                SolarText = "Our planetary system is located in an outer spiral arm of the Milky Way galaxy.",
                RockyType = "Rocky planet",
                GasType = "Gas giant",
                IceType = "Ice giant",
                MercuryText = "The smallest planet in our solar system closest to the Sun.",
                MercuryContent = "Mercury is the closest planet to the Sun and the smallest planet in our solar system. It is located at a distance of approximately 57.9 million kilometers from the Sun. Mercury has a diameter of 4,879 kilometers and does not have any moons. Its surface is heavily cratered, and it has a very thin atmosphere.",
                VenusText = "Venus spins slowly in the opposite direction.",
                VenusContent = "Venus is the second planet from the Sun and is often referred to as Earth's \"twin\" due to its similar size and composition. It is located at an average distance of about 108.2 million kilometers from the Sun. Venus has a diameter of approximately 12,104 kilometers and does not have any moons. It is known for its thick atmosphere consisting mainly of carbon dioxide, which causes a runaway greenhouse effect, resulting in extremely high surface temperatures.",
                EarthText = "Our home planet-is the only place we know so far that's inhabited by living things.",
                EarthContent = "Earth is the third planet from the Sun and the only known celestial body to support life. It is located at an average distance of about 149.6 million kilometers from the Sun. Earth has a diameter of approximately 12,742 kilometers and a single moon. It is characterized by its diverse ecosystems, water bodies, and an atmosphere that supports a wide variety of life forms.",
                MarsText = "Mars is dusty, cold, desert world with a very thin atmosphere.",
                MarsContent = "Mars, often called the \"Red Planet,\" is the fourth planet from the Sun. It is located at an average distance of about 227.9 million kilometers from the Sun. Mars has a diameter of approximately 6,779 kilometers and has two small moons, Phobos and Deimos. It is known for its reddish appearance, caused by iron oxide (rust) on its surface. Mars has a thin atmosphere and polar ice caps, and it has been a subject of interest for potential future human exploration.",
                JupiterText = "Jupiter is more than twice as amssive than the other planets of our solar system combined.",
                JupiterContent = "Jupiter is the largest planet in our solar system, located as the fifth planet from the Sun. It is situated at an average distance of about 778.5 million kilometers from the Sun. Jupiter has a diameter of approximately 139,820 kilometers and is orbited by at least 79 moons, including the four largest ones known as the Galilean moons: Io, Europa, Ganymede, and Callisto. Jupiter is a gas giant and is known for its vibrant atmospheric bands, the Great Red Spot (a persistent storm), and its numerous moons.",
                SaturnText = "Adorned with dazzling, complex system of icy rings, Saturn is unique.",
                SaturnContent = "Saturn is the sixth planet from the Sun and is recognized for its beautiful ring system. It is located at an average distance of about 1.4 billion kilometers from the Sun. Saturn has a diameter of approximately 116,460 kilometers and is orbited by more than 80 moons, with its largest moon being Titan. Saturn's iconic ring system is composed of ice particles and dust, and its atmosphere boasts distinct cloud bands.",
                UranusText = "Uranus rotates nearly 90-degree angle from the plane of its orbit.",
                UranusContent = "Uranus is the seventh planet from the Sun and is notable for its unique sideways orientation. It is located at an average distance of about 2.9 billion kilometers from the Sun. Uranus has a diameter of approximately 50,724 kilometers and is surrounded by a system of rings and at least 27 moons. It is an ice giant planet, primarily composed of hydrogen, helium, and methane. Uranus has a bluish-green color due to the presence of methane in its atmosphere.",
                NeptuneText = "The eight and most distant major planet orbiting our Sun.",
                NeptuneContent = "Neptune is the farthest planet from the Sun and the fourth-largest planet in our solar system. It is located at an average distance of about 4.5 billion kilometers from the Sun. Neptune has a diameter of approximately 49,244 kilometers and is orbited by 14 known moons, including Triton, which is believed to be a captured Kuiper Belt object. Neptune is an ice giant planet, similar to Uranus, and is composed primarily of hydrogen, helium, and methane. It has a bluish color due to the presence of methane in its atmosphere. Neptune also exhibits distinct cloud bands and is known for its active and dynamic weather patterns.",
                CloseButton = "Close",
            };
            return planet;
        }
    }
}
