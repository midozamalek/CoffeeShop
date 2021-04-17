using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Infrastructure.Dto
{
    public class OperationResultDto<T>
    { 
        public OperationResultDto()
        {
            this.Messages = new List<string>();
         }
         
        public T Data { get; set; }
 
        public List<string> Messages { get; set; }

 
        public OperationResultStatusEnum Status { get; set; }
    }
 
    public enum OperationResultStatusEnum
    {
         
        Failed, 
        Succeeded, 
        Warning,
        Validation,
    }
}