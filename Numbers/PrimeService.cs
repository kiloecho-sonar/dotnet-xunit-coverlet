using System.Security.Cryptography;

namespace System.Numbers
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            var tripleDES1 = new TripleDESCryptoServiceProvider(); // Noncompliant: Triple DES is vulnerable to meet-in-the-middle attack
            var simpleDES = new DESCryptoServiceProvider(); // Noncompliant: DES works with 56-bit keys allow attacks via exhaustive search
            var RC2 = new RC2CryptoServiceProvider(); // Noncompliant: RC2 is vulnerable to a related-key attack

            if (1 < 3)
            {
                if (2 < 4)
                {
                    // ...
                }
            }

            if (candidate < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
