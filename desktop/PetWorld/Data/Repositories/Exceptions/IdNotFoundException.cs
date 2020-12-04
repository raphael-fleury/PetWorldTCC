using System;

namespace PetWorld.Data.Repositories.Exceptions
{
    class IdNotFoundException : ApplicationException
    {
        public IdNotFoundException(string message) : base(message) { }
    }
}
