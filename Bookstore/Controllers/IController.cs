﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Bookstore.Controllers
{
    interface IController
    {
        void Execute(RequestContext requestContext);
    }
}
