using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public String BrandName { get; set; }
        public String ColorName { get; set; }
        public int CarDailyInPrice { get; set; }
        public string CarDescription { get; set; }

    }
}
