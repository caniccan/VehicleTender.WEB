﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.WEB.UserDTO.VM.Tender
{
    public class PageModelTender
    {
        public SearchTenderVM SearchTenderVM { get; set; }
        public List<TenderListVM> TenderList { get; set; }   
    }
}
