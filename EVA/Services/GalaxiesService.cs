using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class GalaxiesService : IGalaxiesService
    {
        public GalaxiesViewModel GetGalaxiesViewModel()
        {
            var galaxy = new GalaxiesViewModel
            {
                WelcomeMessage = "Welcome to Eva",
                GalaxiesTitle = "Galaxies",
                Andromeda = "Andromeda Galaxy",
                Antennae = "Antennae Galaxy",
                Backward = "Backward Galaxy",
                Blackeye = "Black Eye Galaxy",
                Butterfly = "Butterfly Galaxy",
                Cartwheel = "Cartweel Galaxy",
                BlogText = "Galaxies are vast cosmic structures consisting of billions to trillions of stars, planets, and various celestial objects, exhibiting a wide range of shapes and sizes, and playing a vital role in understanding the universe's evolution and composition.",
                BlogOneTitle = "Vastness and Diversity",
                BlogOneText = "Galaxies are incredibly vast structures that contain billions to trillions of stars, as well as various other celestial objects like planets, moons, asteroids, and comets. They come in a wide range of shapes, sizes, and colors, showcasing a remarkable diversity. The three main types of galaxies are spiral galaxies (such as our Milky Way), elliptical galaxies, and irregular galaxies. Each type exhibits distinct characteristics in terms of their shape, structure, and distribution of stars.",
                BlogTwoTitle = "Gravitational Dynamics",
                BlogTwoText = "Gravity plays a crucial role in the formation and evolution of galaxies. The gravitational force between stars and other matter within a galaxy helps to shape its structure and motion. Galaxies are not static entities but are in a state of constant motion, with stars orbiting around a galactic center. The interactions between galaxies can also be influenced by gravity, leading to phenomena such as galaxy mergers or collisions. These gravitational dynamics shape the overall structure of the universe on both large and small scales.",
                BlogThreeTitle = "Dark Matter",
                BlogThreeText = "A significant portion of a galaxy's mass is believed to be composed of dark matter. Dark matter is an invisible and mysterious form of matter that does not emit, absorb, or reflect light, making it difficult to detect directly. Its presence is inferred through its gravitational effects on visible matter. The gravitational pull of dark matter helps to hold galaxies together and prevents them from flying apart due to the high speeds at which stars and other objects are moving within them. The exact nature of dark matter remains one of the biggest mysteries in modern astrophysics, and ongoing research aims to uncover its properties and understand its role in galaxy formation and evolution.",
                ExploreGalTitle = "Explore the Galaxies",
                ExploreGalText = "Galaxies come in diverse shapes, sizes, and colors, ranging from majestic spirals with elegant arms to elliptical shapes and irregular formations. ",
                AndromedaPlace = "Galaxiy in the Milky Way",
                AntennaePlace = "Galaxies in Corvus",
                BackwardPlace = "Galaxy in Centaurus",
                BlackeyePlace = "Galaxy in Coma Berencies",
                ButterflyPlace = "Galaxies in Virgo",
                CartwheelPlace = "Galaxy in Sculptor",
                AndromedaText = "The Andromeda Galaxy is the closest spiral galaxy to the Milky Way and is on a collision course with our own galaxy.",
                AndromedaContent = "The Andromeda Galaxy, also known as Messier 31 or M31, is located approximately 2.537 million light-years away from Earth. It is a spiral galaxy similar in structure to our Milky Way. Andromeda is the largest galaxy in the Local Group, a collection of galaxies that includes the Milky Way and about 54 other smaller galaxies. In about 4.5 billion years, the Andromeda Galaxy is expected to collide with our Milky Way, resulting in a cosmic event known as a galactic merger.",
                AntennaeText = "The Antennae Galaxies are a pair of interacting galaxies characterized by their long tidal tails and intense star formation.",
                AntennaeContent = "The Antennae Galaxies, also designated as NGC 4038 and NGC 4039, are a pair of interacting galaxies located approximately 45 million light-years away in the constellation Corvus. The galaxies are undergoing a dramatic gravitational interaction, resulting in elongated tidal tails composed of gas, dust, and young stars. This interaction triggers intense star formation, making the Antennae Galaxies a rich laboratory for studying the effects of galactic collisions.",
                BackwardText = "The \"Backward\" Galaxy, also known as NGC 4622, is a peculiar galaxy with a distinctive trailing spiral arm that appears to go against the usual rotation direction of galaxies.",
                BackwardContent = "NGC 4622, often referred to as the \"Backward Galaxy,\" is a peculiar galaxy located about 111 million light-years away in the constellation Centaurus. It stands out due to its unusual trailing spiral arm, which appears to be rotating in the opposite direction to most spiral galaxies. This peculiarity is thought to have been caused by a past merger or gravitational interaction with another galaxy, resulting in a reshaping of its structure.",
                BlackeyeText = "The Black Eye Galaxy, or Messier 64, gets its name from the prominent dark band of dust that appears like a dark eye in the galaxy's bright nucleus.",
                BlackeyeContent = "Black Eye Galaxy or Evil Eye Galaxy, is a spiral galaxy located about 24 million light-years away in the constellation Coma Berenices. It earned its name due to a prominent dark band of dust that crosses its bright nucleus, resembling a black eye. This galaxy is known for its high rate of star formation and a massive central structure called a \"supermassive black hole.\"",
                ButterflyText = "The Butterfly Galaxy, also called NGC 6302, is a planetary nebula resembling the shape of a butterfly due to its distinctive bipolar structure.",
                ButterflyContent = "NGC 6302, commonly known as the Butterfly Galaxy or Bug Nebula, is a planetary nebula located approximately 3,800 light-years away in the constellation Scorpius. It earned its nickname due to its distinctive bipolar structure resembling the wings of a butterfly. This nebula is the result of a dying star, which shed its outer layers, and the intense radiation from its hot central star illuminates the surrounding gas, creating a striking visual appearance.",
                CartwheelText = "The Cartwheel Galaxy is a peculiar ring galaxy formed from a collision between a smaller galaxy and a larger spiral galaxy, resulting in a spectacular ripple-like ring structure.",
                CartwheelContent = "The Cartwheel Galaxy, designated as ESO 350-40, is a peculiar ring galaxy located about 500 million light-years away in the constellation Sculptor. It obtained its distinct appearance through a collision between a smaller galaxy and a larger spiral galaxy. The impact generated a shockwave that rippled through the galactic material, resulting in a circular wave of star formation and creating the ring-like structure seen today. The Cartwheel Galaxy is an excellent example of the transformative effects of galactic collisions.",
                CloseButton = "Close"

            };
            return galaxy;
        }
    }
}
