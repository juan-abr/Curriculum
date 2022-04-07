using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Curriculum.Data;
using System;
using System.Linq;

namespace Curriculum.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CurriculumContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CurriculumContext>>()))
            {
                // look for any.
                if (context.Syllabus.Any())
                {
                    return;
                }

                context.Syllabus.AddRange(
                    new Syllabus
                    {
                        Rank = "Yellow Stripe",
                        Media = "yellow-stripe.png",
                        Thumbnail = "tn-yellow-stripe.png"
                    },
                    new Syllabus
                    {
                        Rank = "Yellow Belt",
                        Media = "yellow-belt.png",
                        Thumbnail = "tn-yellow-belt.png"
                    },
                    new Syllabus
                    {
                        Rank = "Green Stripe",
                        Media = "green-stripe.png",
                        Thumbnail = "tn-green-stripe.png"
                    },
                    new Syllabus
                    {
                        Rank = "Green Belt",
                        Media = "green-belt.png",
                        Thumbnail = "tn-green-belt.png"
                    },
                    new Syllabus
                    {
                        Rank = "Blue Stripe",
                        Media = "blue-stripe.png",
                        Thumbnail = "tn-blue-stripe.png"
                    },
                    new Syllabus
                    {
                        Rank = "Blue Belt",
                        Media = "blue-belt.png",
                        Thumbnail = "tn-blue-belt.png"
                    },
                    new Syllabus
                    {
                        Rank = "Brown Stripe",
                        Media = "brown-belt.png",
                        Thumbnail = "tn-brown-belt.png"
                    },
                    new Syllabus
                    {
                        Rank = "Black Stripe",
                        Media = "black-stripe.png",
                        Thumbnail = "tn-black-stripe.png"
                    },
                    new Syllabus
                    {
                        Rank = "Cho Dan (Black Belt)",
                        Media = "black-belt.png",
                        Thumbnail = "tn-black-belt.png"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}