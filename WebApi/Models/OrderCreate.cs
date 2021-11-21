﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Models
{
    public class OrderCreate
    {

        public Guid Id { get; set; }
        public int UserId { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public string Status { get; set; }
        public int DeliveryTypeId { get; set; }

    }
}
