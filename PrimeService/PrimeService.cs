using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if(candidate == 0 || candidate % 2 != 0)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}
