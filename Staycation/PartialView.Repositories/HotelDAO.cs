using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PartialView.Models.Hotel;

namespace PartialView.Repositories
{
    public class HotelDAO
    {
        public HotelDAO()
        {
        }

        public IEnumerable<Hotel> GetAll(CountryType type)
        {
            // later we will use a database
            List<Hotel> hotels = new List<Hotel>
            {
            new Hotel{ Id = 1,NameHotel = "Hotel Europe", City = "Nieuwpoort" ,Stars = 4 ,Score = 7.8  ,Benefit = "Familiehotel bij uitsek" ,Photo = "../Images/HotelEurope.jpg" , Country = CountryType.Coast   },
            new Hotel{ Id = 2,NameHotel = "Domein Westhoek", City = "Knokke" ,Stars = 3 ,Score = 7.3  ,Benefit = "Zwembad & wellness" ,Photo = "../Images/DomeinWesthoek_Oostduinkerke.jpg" , Country = CountryType.Coast   },
            new Hotel{ Id = 2,NameHotel = "ibis DeHaan", City = "De haan" ,Stars = 4 ,Score = 8  ,Benefit = "Stand op 350m" ,Photo = "../Images/ibisDeHaan_DeHaan.jpg" , Country = CountryType.Coast   },
            new Hotel{ Id = 2,NameHotel = "C-Hotels Excelsior", City = "Blankenberge" ,Stars = 4 ,Score = 7.9 ,Benefit = "Zwembad & wellness" ,Photo = "../Images/C-HotelsExcelsior_Middelkerke.jpg" , Country = CountryType.Coast   },
            
            };
            

            // LINQ  (+/- SQL)

            // "select * from tblAdul where ..." 

            // => goes operator

            // Uitleg Lambda Expression
            // Expression lambda that has an expression as its body:
            //  (input-parameters) => expression

            // this  '=>' is the goes operator
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

            // uitleg LINQ
            // https://www.tutorialsteacher.com/linq/linq-method-syntax
            return hotels.Where(a => a.Country == type); // hotels -> only hotels objects
        }

    }
}
