using EVA.IServices;
using EVA.Models;

namespace EVA.Services
{
    public class AboutUsService : IAboutUsService
    {
        public AboutUsViewModel GetAboutUsViewModel()
        {
            var model = new AboutUsViewModel
            {
                WelcomeMessage = "Welcome to EVA",
                AboutUsTitle = "About us",
                AboutUsContent = "Welcome to EVA, your gateway to the wonders of space! EVA is a captivating website dedicated to providing a rich and immersive experience for space enthusiasts and those fascinated by the vast mysteries beyond our Earth. We have carefully curated a collection of awe-inspiring content that includes mesmerizing astronomical images, information about galaxies and planets, details about astronauts and their remarkable achievements, and much more. Whether you're an avid fan or a curious explorer, EVA is designed to ignite your passion and broaden your understanding of the cosmos.",
            ApodTitle = "Apod",
                ApodContent = "EVA presents a daily dose of celestial beauty through our Astronomy Picture of the Day feature. Each day, we showcase breathtaking photographs captured by talented astrophotographers from around the world. From stunning nebulae to distant galaxies, these captivating images allow you to witness the extraordinary beauty of the cosmos, expanding your appreciation for the wonders of space.",
            RegistrationTitle = "Registration",
                RegistrationContent = "At EVA, we believe in creating a personalized experience for our visitors. By registering on our platform, you gain access to exclusive features such as saving your favorite images. Our registration feature ensures that you can make the most out of your journey through the cosmos.",
            ExploreTitle = "Explore",
                ExploreContent = "EVA serves as a comprehensive resource for exploring the vastness of space. Dive into our well-researched articles and guides that offer detailed insights into different galaxies and planets. Uncover fascinating facts about their formation, composition, and unique characteristics. Our aim is to provide a deeper understanding of the celestial bodies that populate our universe. Delve into our astronaut profiles, where you can learn about the lives, missions, and groundbreaking discoveries made by these pioneers of space exploration. Discover their courage, determination, and unwavering spirit as they venture into the unknown, expanding our knowledge of the cosmos and inspiring future generations.",
            SignUpTitle = "Ready for an adventure?",
                SignUpContent = "As a registered user, you gain access to exclusive features and functionalities on our website. Join EVA today to embark on a journey through the cosmos, where you can learn and explore with the wonders of space. Sign up now and be part of an ever-growing community of space enthusiasts!"

            };
            return model;
        }
    }
}
