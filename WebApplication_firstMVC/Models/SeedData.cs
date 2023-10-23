using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication_firstMVC.Data;
using System;
using System.Linq;
using System.Security.Policy;

namespace WebApplication_firstMVC.Models;
public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WebApplication_firstMVCContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<WebApplication_firstMVCContext>>()))
        {
            // Look for any client.
            if (context.Client.Any())
            {
                return;   // DB has been seeded
            }
            context.Client.AddRange(
                new Client
                {
                    Name = "Coca Cola",
                    WebSite = "https://www.coca-colacompany.com/",
                    URL = "data:image/png;base64,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",
                    ServiceCenter = "CT"
                },
                new Client
                {
                    Name = "Keurig Dr Pepper",
                    WebSite = "https://www.keurigdrpepper.com/",
                    URL = "https://filecache.mediaroom.com/mr5mr_keurig_drpepper/177449/KDP_new_logo__thumbnail_2.jpg",
                    ServiceCenter = "CT"
                },
                new Client
                {
                    Name = "Unilever",
                    WebSite = "https://www.unilever.com/",
                    URL = "https://cdn.sanity.io/images/92ui5egz/production/7c1c60e9afaaaa3cce61e5101717796d21b7f914-1426x1080.svg?rect=0,139,1426,802&w=900&h=506&fit=crop&auto=format",
                    ServiceCenter = "EU"
                },
                new Client
                {
                    Name = "Kraft Heinz Company",
                    WebSite = "https://www.kraftheinzcompany.com/",
                    URL = "https://www.kraftheinzcompany.com/pressroom/images/view/kraftHeinzLogo.png",
                    ServiceCenter = "CT"
                },
                new Client
                {
                    Name = "Nestlé",
                    WebSite = "https://www.nestle.com/",
                    URL = "data:image/jpeg;base64,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",
                    ServiceCenter = "EU"
                }
            );
            context.SaveChanges();
        }
    }
}
