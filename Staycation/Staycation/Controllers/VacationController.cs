using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using PartialView.Services;
using Staycation.ViewModels;
using System.Data;

namespace Staycation.Controllers
{
    public class VacationController : Controller
    {


        public HotelService HotelService { get; }
        public VacationController()
        {
            HotelService = new HotelService();
        }
        
        public IActionResult Index(CountryType type)
        {
            var lstHotels = HotelService.GetAll(type);
            List<HotelVM> hotelVMs = new List<HotelVM>();

            foreach (var hotel in lstHotels)
            {
                var HotelVM = new HotelVM();
                //later we use an automapper
                HotelVM.NaamHotel = hotel.NameHotel;
                HotelVM.Stars = hotel.Stars;
                HotelVM.Score = hotel.Score;
                HotelVM.Benefit = hotel.Benefit;
                HotelVM.ImagePath = hotel.Photo;
                hotelVMs.Add(HotelVM);
            }

            ViewBag.Type = type == CountryType.Coast ? "Kust" : "Wallonie";

            return View(hotelVMs);
        }

    }
}
