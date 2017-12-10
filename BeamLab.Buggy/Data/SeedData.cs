using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeamLab.Buggy.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Status.Any())
                {
                    return;   // DB has been seeded
                }

                context.Status.AddRange(
                     new Status
                     {
                         ID = 1,
                         Name = "Open",
                     },
                    new Status
                    {
                        ID = 2,
                        Name = "In Progress",
                    },
                    new Status
                    {
                        ID = 3,
                        Name = "Closed",
                    },
                    new Status
                    {
                        ID = 4,
                        Name = "Reopen",
                    },
                    new Status
                    {
                        ID = 5,
                        Name = "Rejected",
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
