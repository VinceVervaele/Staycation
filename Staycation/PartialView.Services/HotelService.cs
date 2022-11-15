using PartialView.Models;
using PartialView.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialView.Services
{
    public class HotelService
    {
        private HotelDAO HotelDAO;
        public HotelService()
        {
            HotelDAO = new HotelDAO();
        }

        public IEnumerable<Hotel> GetAll(CountryType type)
        {
            return HotelDAO.GetAll(type);
        }
    }
}
