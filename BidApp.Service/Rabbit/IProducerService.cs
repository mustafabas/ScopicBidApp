﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BidApp.Service.Rabbit
{
    public   interface IProducerService
    {
        bool PushMessageToQ();
    }
}
