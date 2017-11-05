using System;
using System.Collections.Generic;
namespace SortAnalytics
{
    public class results
    {
        public results(string name, TimeSpan duration, List<long> nums)
        {
            this.name = name;
            this.duration = duration;
            this.nums = nums;
            //this.relative = relative;
        }

        public results(string name, TimeSpan duration, List<double> doubleNums)
        {
            this.name = name;
            this.duration = duration;
            this.doubleNums = doubleNums;
            //this.relative = relative;
        }

        public string name
        {
            get;
            set;
        }

        public TimeSpan duration
        {
            get;
            set;
        }

        public List<long> nums
        {
            get;
            set;
        }

        public List<double> doubleNums
        {
            get;
            set;
        }

        //public double relative
        //{
        //    get;
        //    set;
        //}
    }
}
