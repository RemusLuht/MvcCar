using Microsoft.AspNetCore.Mvc.Rendering;
using MvcCar.Models;
using System.Collections.Generic;

namespace MvcCar.Models
{
    public class CarColorViewModel
    {
        public List<Car> Cars { get; set; }
        public SelectList Colors { get; set; }
        public string CarColor { get; set; }
        public string SearchString { get; set; }
    }
}