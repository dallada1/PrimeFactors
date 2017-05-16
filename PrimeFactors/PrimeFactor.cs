using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactors
{
    public class PrimeFactor
    {

        public List<Int32> Generate(Int32 inputNumber)
        {
            List<Int32> primeFactors = null;

            if (inputNumber > 3)
            {
                var factors = GetFactors(inputNumber);

                while (!ListIsPrime(factors))
                {
                    var factorsOfFactors = new List<Int32>();
                    foreach(var factor in factors)
                    {
                        if (IsPrime(factor))
                            factorsOfFactors.Add(factor);
                        else
                            factorsOfFactors.AddRange(GetFactors(factor));
                    }

                    factors = factorsOfFactors;
                }

                primeFactors = factors;
                primeFactors.Sort();
            }
            else if(inputNumber > 1)
            {
                primeFactors = new List<Int32> { inputNumber };
            }

            return primeFactors;
        }

        public Boolean IsPrime(Int32 input)
        {
            for(var i = 2; i < input; i++)
                if(input % i == 0)
                    return false;

            return true;
        }

        public Boolean ListIsPrime(List<Int32> input)
        {
            return input.All(i => IsPrime(i));
        }

        public List<Int32> GetFactors(Int32 input)
        {
            var factors = new List<Int32>();

            for(var i = 2; i < input; i++)
            {
                if(input % i == 0)
                {
                    if(i * i == input)
                    {
                        factors.Add(i);
                    }

                    factors.Add(i);
                }
            }

            return factors;
        }
        
    }
    
}