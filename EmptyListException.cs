﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleSingly
{
    public class EmptyListException : Exception
    {
        public EmptyListException() : base("The queue is empty.")
        {

        }
    }
}
