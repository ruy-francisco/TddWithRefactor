using System;

namespace StronglyCoupled
{
    public class Entrance
    {
        private readonly InfoChecker _infoChecker = null;

        public Entrance() => _infoChecker = new InfoChecker();

        public bool IsMyAddressValid(string cpf)
        {
            Address address = _infoChecker.GetAddressByCPF(cpf);
            return address.Number > 0;
        }

        public bool AmIAdult(string cpf)
        {
            var age = _infoChecker.GetAgeByCPF(cpf);
            return age > 18;
        }       

    }
}
