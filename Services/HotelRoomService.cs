using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using BlazorHotel.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace BlazorHotel.Services
{
    public class HotelRoomService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public HotelRoomService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        private string RoomsFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.ContentRootPath , "Data" , "products.json");
            }
        }
        public List<HotelRoom> GetRooms()
        {         
                using (var jsonFileReader = File.OpenText(RoomsFileName))
                {
                    return JsonSerializer.Deserialize<List<HotelRoom>>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                        );
                }
        }
    }
}
/*
 D:\AllProjects\BlazorHotel\BlazorHotel\Data\products.json
 */