﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Constrete
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
