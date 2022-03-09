using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class ListMultiRequest<T>
    {
        public T Id { get; set; }
    }

    public class ListMultiResponse<T>
    {
        public T Id { get; set; }
        public string Title { get; set; }
    }

    public class IdTitle<T>
    {
        public T Id { get; set; }
        public string Title { get; set; }
    }

    public class IdIsActive<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
    }
}
