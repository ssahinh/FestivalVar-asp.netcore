using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Responses
{
    public class BaseResponse<T>
    {
        public string Code { get; set; }
        
        public string Message { get; set; }
        
        public T Data { get; set; }
    }
}