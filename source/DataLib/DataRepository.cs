using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib {
  public class DataRepository {
    private List<Customer> _customerList;
    public DataRepository() {
     
    }
    public List<Customer> GetCustomerData()
{
    _customerList = new List<Customer>();

    _customerList.Add(new Customer 
    { 
        FirstName = "Walt", 
        LastName = "Ritscher",
        EmailAddress = "walt@somewhere.com", 
        Company = "LinkedIn", 
        CustomerSince = DateOnly.FromDateTime(new DateTime(2015, 11, 30)) 
    });
    _customerList.Add(new Customer 
    { 
        FirstName = "Richard", 
        LastName = "Wallace", 
        EmailAddress = "richard@somewhere.com", 
        Company = "Big Star Collectibles", 
        CustomerSince = DateOnly.FromDateTime(new DateTime(2021, 4, 12)) 
    });

    _customerList.Add(new Customer
    {
        FirstName = "Alice",
        LastName = "Johnson",
        EmailAddress = "alice.johnson@example.com",
        Company = "Tech Solutions",
        CustomerSince = DateOnly.FromDateTime(new DateTime(2019, 6, 5))
    });
    _customerList.Add(new Customer
    {
        FirstName = "Bob",
        LastName = "Smith",
        EmailAddress = "bob.smith@example.com",
        Company = "Creative Co.",
        CustomerSince = DateOnly.FromDateTime(new DateTime(2018, 9, 20))
    });
    _customerList.Add(new Customer
    {
        FirstName = "Carol",
        LastName = "Miller",
        EmailAddress = "carol.miller@example.com",
        Company = "Innovatech",
        CustomerSince = DateOnly.FromDateTime(new DateTime(2022, 1, 15))
    });
    _customerList.Add(new Customer
    {
        FirstName = "David",
        LastName = "Brown",
        EmailAddress = "david.brown@example.com",
        Company = "Business Corp",
        CustomerSince = DateOnly.FromDateTime(new DateTime(2020, 7, 23))
    });
    _customerList.Add(new Customer
    {
        FirstName = "Eva",
        LastName = "Davis",
        EmailAddress = "eva.davis@example.com",
        Company = "Enterprise Inc.",
        CustomerSince = DateOnly.FromDateTime(new DateTime(2017, 3, 8))
    });

    return _customerList;
}

    // public List<Customer> Customers
    // {
    //   get
    //   {
    //     // code to access data in database
    //     return GetCustomerData();
    //
    //
    //   }
    // }

    public List<Customer> Customers
    {
      get   
      {
        var fakerList = new List<Customer>();
        var customerFaker = new Bogus.Faker<DataLib.Customer>();
        customerFaker.RuleFor(x => x.FirstName, x => x.Person.FullName);
        customerFaker.RuleFor(x => x.LastName, x => x.Person.LastName);
        customerFaker.RuleFor(x => x.EmailAddress, x => x.Person.Email);
        customerFaker.RuleFor(x => x.Company, x => x.Person.Company.Name);
        customerFaker.RuleFor(x => x.CustomerSince, x => DateOnly.FromDateTime(x.Date.Past(5, DateTime.Now)));
        customerFaker.RuleFor(x => x.Review, x => x.Rant.Review());

        for (int counter = 0; counter < 30; counter++)
        {
          fakerList.Add(customerFaker.Generate());
        }
          return fakerList;
      }
    }

    public List<Song> Songs
    {
      get

      {
        var labelNames = new[] { "Tune Crooners", "Skyheart", "Green Denim Records", "Whispertime Studios" };
        var fakerList = new List<Song>();
        var songFaker = new Bogus.Faker<DataLib.Song>();

        songFaker.RuleFor(x => x.SongTitle, x => x.Lorem.Slug(3));
        songFaker.RuleFor(x => x.Genre, x => x.Music.Genre());
        songFaker.RuleFor(x => x.Artist, x => x.Person.UserName);
        songFaker.RuleFor(x => x.Label, x => x.PickRandom(labelNames));

        for (int counter = 0; counter < 18; counter++)
        {
          fakerList.Add(songFaker.Generate());
        }

        return fakerList;
      }
    }


    public List<Product> Products
    {
      get

      {

        var fakerList = new List<Product>();
        var productFaker = new Bogus.Faker<DataLib.Product>();

        productFaker.RuleFor(x => x.Name, x => x.Commerce.ProductName());
        productFaker.RuleFor(x => x.Color, x => x.Commerce.Color());
        productFaker.RuleFor(x => x.Description, x => x.Commerce.ProductDescription());
        productFaker.RuleFor(x => x.Department, x => x.Commerce.Department());

        for (int counter = 0; counter < 5; counter++)
        {
          fakerList.Add(productFaker.Generate());
        }

        return fakerList;
      }
    }
  } 
}
