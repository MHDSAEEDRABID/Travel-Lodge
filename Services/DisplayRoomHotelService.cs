using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHotel.Models;
namespace BlazorHotel.Services
{
    public class DisplayRoomHotelService
    {
        HotelRoom selectedhotelroom;

        public HotelRoom SelectedHotelRoom { get => selectedhotelroom; set => selectedhotelroom = value; }
        public string id { get { return selectedhotelroom.id; } }
        public string maker { get { return selectedhotelroom.maker; } }
        public string img { get { return selectedhotelroom.img; } }
        public string title { get { return selectedhotelroom.title; } }
        public string description { get { return selectedhotelroom.description; } }
    }
}
