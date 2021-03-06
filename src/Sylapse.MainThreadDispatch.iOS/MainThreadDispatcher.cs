﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreFoundation;

namespace Sylapse.MainThreadDispatch
{
    public class MainThreadDispatcher
    {
        public static MainThreadDispatcher Instance = new MainThreadDispatcher();
        
        public MainThreadDispatcher()
        {
        }

        public void Execute(Action action)
        {
            DispatchQueue.MainQueue.DispatchAsync(action);
        }
    }
}