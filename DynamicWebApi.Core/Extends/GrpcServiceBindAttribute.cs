﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicWebApi.Core.Extends
{
    public class GrpcServiceBindAttribute : Attribute
    {
        public Type BindType { get; set; }
        public Type ClientType { get; set; }
    }
}
