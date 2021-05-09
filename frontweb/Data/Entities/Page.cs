using System.Collections.Generic;

namespace PetWorldWeb.Data.Entities.Page
{
    public class Page<T>
    {
        public List<T> Content { get; set; }
        public bool Last { get; set; }
    }
}