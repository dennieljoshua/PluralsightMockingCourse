using System;

namespace PluralsightMockingCourse
{
    public class FrequentFlyerNumberValidator : IFrequentFlyerNumberValidator
    {
        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use");
        }
    }
}
