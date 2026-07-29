using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class DbInitializer
    {
        public static async Task SeedData(AppDbContext context)
        {
            if (context.Activities.Any()) return;
                
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Latitude = 51.5074,
                    Longitude = -0.1278
                },
                new()
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre Museum",
                    Latitude = 48.8566,
                    Longitude = 2.3522
                },
                new()
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in the future",
                    Category = "music",
                    City = "New York",
                    Venue = "Madison Square Garden",
                    Latitude = 40.7128,
                    Longitude = -74.0060
                },
                new()
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in the future",
                    Category = "food",
                    City = "Tokyo",
                    Venue = "Tsukiji Fish Market",
                    Latitude = 35.6895,
                    Longitude = 139.6917
                },
                new()
                {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 months in the future",
                    Category = "travel",
                    City = "Sydney",
                    Venue = "Sydney Opera House",
                    Latitude = -33.8688,
                    Longitude = 151.2093
                },
                new()
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in the future",
                    Category = "sports",
                    City = "Rio de Janeiro",
                    Venue = "Maracanã Stadium",
                    Latitude = -22.9068,
                    Longitude = -43.1729
                },
                new()
                {
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 months in the future",
                    Category = "theater",
                    City = "London",
                    Venue = "West End Theatre",
                    Latitude = 51.5074,
                    Longitude = -0.1278
                },
                new()
                {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),  
                    Description = "Activity 6 months in the future",    
                    Category = "comedy",
                    City = "Los Angeles",
                    Venue = "Hollywood Bowl",
                    Latitude = 34.0522,
                    Longitude = -118.2437             
                },
                new()
                {
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 7 months in the future",
                    Category = "art",
                    City = "Florence",
                    Venue = "Uffizi Gallery",
                    Latitude = 43.7696,
                    Longitude = 11.2558
                },
                new()
                {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in the future",
                    Category = "history",
                    City = "Rome",
                    Venue = "Colosseum",
                    Latitude = 41.9028,
                    Longitude = 12.4964
                }       
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }    
    }            
}