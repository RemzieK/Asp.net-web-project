using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class AstronautsService : IAstronautsService
    {
        public AstronautsViewModel GetAstronautsViewModel()
        {
            var astro = new AstronautsViewModel
            {
                WelcomeMessage = "Welcome to EVA",
                AstronautsTitle = "Astronauts",
                YuriName = "Yuri Gagarin",
                NailName = "Nail Armstrong",
                AlanName = "Alan B. Shepard Jr.",
                ValentinaName = "Valentina Tereshkova",
                JohnName = "John Glenn Jr.",
                JamesName = "James Lovell Jr.",
                SallyName = "Dr. Sally Ride",
                ChrisName = "Chris Hadfield",
                LaikaName = "Laika",
                BlogText = "Astronauts push the boundaries of human exploration, inspiring us all to reach for the stars.",
                BlogOneTitle = "Intense Training and Preparation",
                BlogOneContent = "Astronauts undergo rigorous physical training to build strength, endurance, and cardiovascular fitness, as they need to adapt to the physically demanding conditions of space travel and spacewalks. They receive psychological training to develop resilience, teamwork, and coping strategies, as they may face isolation, long-duration missions, and potential emergencies during their time in space.",
                BlogTwoTitle = "Advancing Scientific Knowledge",
                BlogTwoContent = "Astronauts conduct experiments in microgravity environments that provide unique opportunities for scientific discovery across disciplines like physics, chemistry, biology, and human health, leading to breakthroughs and advancements not possible on Earth. They capture stunning images and collect data on Earth's atmosphere, land, and oceans, contributing to our understanding of climate change, weather patterns, natural disasters, and the overall health of our planet.",
                BlogThreeTitle = "Global Ambassadors of Exploration",
                BlogThreeContent = "Astronauts represent their respective countries or space agencies, highlighting the importance of international cooperation in space exploration, fostering diplomacy, and promoting peaceful partnerships for the advancement of scientific and technological endeavors. Astronauts inspire people of all ages and backgrounds to dream big and pursue careers in science, technology, engineering, and mathematics (STEM), serving as role models who ignite curiosity and encourage the next generation to push the boundaries of human knowledge.",
                MeetAstroTitle = "Meet the Austronauts",
                MeetAstroText = "Astronauts are pioneers who venture into the unknown, expanding our horizons and inspiring us to embrace the wonders of the universe.",
                RussianNationality = "Russian",
                AmericanNationality ="American" ,
                CanadianNationality = "Canadian",
                SovietNationality = "Soviet",
                YuriText = "The first human to journey into outer space, opening up the realm of space exploration for all of humanity.",
                YuriContent = "Yuri Gagarin, born on March 9, 1934, in the village of Klushino, Russia, made history on April 12, 1961, as the first human to orbit the Earth, completing one orbit during his 108-minute mission aboard the Vostok 1 spacecraft. His achievement marked a significant milestone in the Space Race between the Soviet Union and the United States, propelling him to worldwide acclaim as an iconic figure in space exploration. Tragically, Gagarin's life was cut short on March 27, 1968, when the MiG-15 jet he was piloting crashed during a routine training flight. Despite his untimely death, Gagarin's legacy as a pioneering astronaut and symbol of human achievement in space endures, inspiring generations of future explorers.",
                NailText = "Neil Armstrong forever left his mark on history as the first person to set foot on the moon during the Apollo 11 mission in 1969, inspiring generations with his \"one small step for man, one giant leap for mankind.",
                NailContent = "Neil Armstrong, an American astronaut, made history on July 20, 1969, when he became the first person to set foot on the moon as part of the Apollo 11 mission, uttering his famous words, \"That's one small step for man, one giant leap for mankind.\" Prior to his lunar landing, Armstrong served as a naval aviator and test pilot, accumulating invaluable experience and expertise. His remarkable achievement not only symbolized the triumph of human exploration but also sparked a new era of scientific discovery and inspired generations to reach for the stars. Tragically, Armstrong passed away on August 25, 2012, leaving behind a lasting legacy as a pioneer in space exploration.",
                AlanText = "Alan B. Shepard Jr., an American astronaut, made history as the first American to travel into space during his suborbital flight aboard the Freedom 7 spacecraft on May 5, 1961.",
                AlanContent = "Alan B. Shepard Jr., an American astronaut and naval aviator, made history on May 5, 1961, as the first American to travel to space during the Mercury-Redstone 3 mission, also known as Freedom 7. His 15-minute suborbital flight reached a maximum altitude of 187.5 kilometers (116.5 miles) and paved the way for future manned space missions. Shepard later played a crucial role in the Apollo program, commanding the Apollo 14 mission in 1971, where he became the fifth person to walk on the moon. His accomplishments and contributions to space exploration continue to inspire and leave a lasting impact.",
                ValentinaText = "Valentina Tereshkova, a Russian cosmonaut, made history on June 16, 1963, as the first woman to travel to space, orbiting the Earth aboard the Vostok 6 spacecraft and blazing a trail for women in space exploration.",
                ValentinaContent = "Valentina Tereshkova, a Russian cosmonaut, made history on June 16, 1963, when she became the first woman to travel to space aboard the Vostok 6 spacecraft, orbiting the Earth 48 times in just under three days. Before her space mission, Tereshkova worked as a textile worker and a skydiver, which contributed to her selection as a cosmonaut. Her groundbreaking achievement opened doors for women in space exploration and inspired future generations of female astronauts to follow in her footsteps. Tereshkova remains a prominent figure in space history and a symbol of women's contribution to the field.",
                JohnText = "John Glenn Jr., an American astronaut and senator, made history on February 20, 1962, as the first American to orbit the Earth during his Friendship 7 mission, solidifying his legacy as a pioneering space explorer and national hero.",
                JohnContent = "John Glenn Jr., an American astronaut, aviator, and senator, made history on February 20, 1962, when he became the first American to orbit the Earth aboard the Friendship 7 spacecraft, completing three orbits during his five-hour mission. Glenn's successful flight was a pivotal moment in the Space Race and boosted national pride during the early days of human space exploration. After retiring from NASA, Glenn entered politics and served as a U.S. Senator from Ohio for 24 years, further contributing to his notable career of public service and his lasting impact on American history.",
                JamesText = "James Lovell Jr., an American astronaut, led the Apollo 13 mission, showcasing remarkable resilience and teamwork during a critical space crisis.",
                JamesContent = "James Lovell Jr., an American astronaut and naval aviator, is best known for his role as the commander of the ill-fated Apollo 13 mission in 1970. After an oxygen tank explosion onboard the spacecraft, Lovell and his crew faced a life-threatening situation in space, but through their resourcefulness, problem-solving, and the tireless efforts of NASA's ground control team, they safely returned to Earth after a harrowing four-day journey, demonstrating incredible ingenuity and teamwork in the face of adversity. Lovell's leadership and the lessons learned from the Apollo 13 mission have had a lasting impact on space exploration, astronaut training, and mission planning.",
                SallyText = "Dr. Sally Ride, an American astronaut and physicist, became the first American woman to travel to space, inspiring generations and breaking barriers for women in science and exploration.",
                SallyContent = "Dr. Sally Ride, an American astronaut and physicist, made history on June 18, 1983, as the first American woman to travel to space, aboard the Space Shuttle Challenger during the STS-7 mission. As a mission specialist, Ride played a vital role in conducting experiments and operating the robotic arm. Following her pioneering spaceflight, Ride continued to contribute to NASA and became a passionate advocate for science education, co-founding Sally Ride Science to inspire young students, especially girls, to pursue careers in STEM fields. Her legacy as a trailblazer and advocate for scientific exploration and education remains an inspiration to this day.",
                ChrisText = "Chris Hadfield, a Canadian astronaut, captivated the world with his social media presence and command of the International Space Station, inspiring a new generation of space enthusiasts.",
                ChrisContent = "Chris Hadfield, a renowned Canadian astronaut, gained international fame for his time as the commander of the International Space Station (ISS) during Expedition 35. His engaging videos and stunning photographs, shared through social media, offered a unique perspective of life in space and captured the imagination of millions worldwide. Prior to his ISS command, Hadfield served as a test pilot and flew on two space shuttle missions, accumulating a total of 166 days in space. His contributions to space exploration and his efforts to make science accessible to the public have left a lasting impact on the global space community.",
                LaikaText = "Laika, the Soviet space dog, made history as the first living creature to orbit the Earth aboard Sputnik 2 in 1957.",
                LaikaContent = "Laika, a stray dog from Moscow, was selected by the Soviet space program for the historic mission aboard Sputnik 2. Launched on November 3, 1957, she became the first living being to orbit the Earth, reaching speeds of 28,000 kilometers per hour. Tragically, Laika's journey was one-way, as the technology to safely return animals from space had not yet been developed, and she perished a few hours after the launch. Although her sacrifice sparked ethical debates, Laika's mission contributed valuable data to early space exploration efforts and paved the way for future human spaceflights.",
                CloseButton = "Close"


            };
            return astro;
        }
    }
}
