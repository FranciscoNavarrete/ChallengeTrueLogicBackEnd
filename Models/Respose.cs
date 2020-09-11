using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Response<T>
    {
        public Boolean Successful { get; set; }

        public String Message { get; set; }

        public T Content { get; set; }
    }
}
