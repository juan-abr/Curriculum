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
                        Thumbnail = "tn-yellow-stripe.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Yellow Belt",
                        Media = "yellow-belt.png",
                        Thumbnail = "tn-yellow-belt.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Green Stripe",
                        Media = "green-stripe.png",
                        Thumbnail = "tn-green-stripe.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Green Belt",
                        Media = "green-belt.png",
                        Thumbnail = "tn-green-belt.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Blue Stripe",
                        Media = "blue-stripe.png",
                        Thumbnail = "tn-blue-stripe.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Blue Belt",
                        Media = "blue-belt.png",
                        Thumbnail = "tn-blue-belt.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Brown Stripe",
                        Media = "brown-belt.png",
                        Thumbnail = "tn-brown-belt.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Black Stripe",
                        Media = "black-stripe.png",
                        Thumbnail = "tn-black-stripe.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    },
                    new Syllabus
                    {
                        Rank = "Cho Dan (Black Belt)",
                        Media = "black-belt.png",
                        Thumbnail = "tn-black-belt.png",
                        DateCreated = DateTime.Parse("2020-5-31"),
                        IsCurrent = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}