using RateGun.Infrastructure;


namespace RateGun.Application
{
    public class GunSeeder
    {
        private readonly RateGunDBContext _dbContext;

        public GunSeeder(RateGunDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Guns.Any())
                {
                    //var guns = GetGuns();
                    //_dbContext.Guns.AddRange(guns);
                    //_dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Gun> GetGuns()
        {
            var guns = new List<Gun>();
            /*{
                new Gun()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "KFC (short for Kentucky Fried Chicken) is an American fast food gun chain headquartered in Luisvill, Kentucky.",
                    ContactEmail = "contact@kfc.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name="Nashville Hot Chicken",
                            Price = 10.30M,
                        },
                        new Dish()
                        {
                            Name="Chicken Nuggets",
                            Price = 5.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001"
                    }
                },
                new Gun()
                {
                    Name = "McDonalds",
                    Category = "FastFood",
                    Description = "Something about McDonalds.",
                    ContactEmail = "contact@mddonalds.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name="BigMac",
                            Price = 4.00M,
                        },
                        new Dish()
                        {
                            Name="Lumberjack Burger",
                            Price = 5.20M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Niepołomnice",
                        Street = "Główna 15",
                        PostalCode = "xx-005"
                    }
                }
            };*/
            return guns;
        }
    }
}
