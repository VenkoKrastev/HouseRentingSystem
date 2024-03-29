﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.ConstantsDb
{
    public static class DataConstants
    {
        //Category
        public const int NameLength = 50;

        //House
        public const int HouseTitleMaxLength = 50;
        public const int HouseTitleMinLength = 10;

        public const int HouseAddressMaxLength = 150;
        public const int HouseAddressMinLength = 30;

        public const int HouseDescriptionMaxLength = 500;
        public const int HouseDescriptionMinLength = 50;

        public const string HouseRentingPriceMax = "2000.00";
        public const string HouseRentingPriceMin = "0.00";

        //Agent
        public const int AgentPhoneNumberMaxLength = 15;
        public const int AgentPhoneNumberMinLength = 7;

    }
}
