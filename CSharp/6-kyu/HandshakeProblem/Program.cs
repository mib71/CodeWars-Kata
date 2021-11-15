using System;

namespace HandshakeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetParticipants(100));
        }

        private static int GetParticipants(int handshakes)
        {
            int people = 1;
            int handshake = 0;

            while (handshakes > handshake)
                handshake += people++;

            return people;
            /*
             * handshakes = n(n-1)/2
             */
        }
    }
}
