using System;
using System.Collections.Generic;
using System.Text;

namespace sTest.BusinessLogic.Settings
{
    public class HangfireSettings
    {
        public bool Enabled { get; set; }
        public Recurring Recurring { get; set; }
        public FireAndForget FireAndForget { get; set; }
        public Delayed Delayed { get; set; }
        public Continuations Continuations { get; set; }
    }

    public class FireAndForget
    {

    }

    public class Delayed
    {

    }

    public class Recurring
    {
        public string Cron { get; set; }
        public int Time { get; set; }
    }

    public class Continuations
    {

    }
}
