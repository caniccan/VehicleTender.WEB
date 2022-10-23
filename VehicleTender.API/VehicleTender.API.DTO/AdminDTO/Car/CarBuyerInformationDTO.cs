﻿using VehicleTender.API.Validation.Attributes;

namespace VehicleTender.API.DTO.AdminDTO.Models.Car
{
    public class CarBuyerInformationDTO
    {
        [StringType(Max = 20, Min = 3)]
        public string Name { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string Surname { get; set; }
        [StringType(Max = 20, Min = 9)]
        public string Telephone { get; set; }
        [StringType(Max = 20, Min = 3)]
        public string CompanyName { get; set; }
    }
}
