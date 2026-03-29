using System;

namespace TP_MODUL5_103022400008 
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}