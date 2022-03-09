using Business.SMSManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.IServices
{
    public interface ISmsOperators
    {
        Task<object> GetById(int id);
        Task<object> List();
        Task<object> Add(SmsOperatorsDto requestBaseDto);
        Task<object> Edit(SmsOperatorsDto requestBaseDto);
        Task<object> Delete(BaseRequestPost<int> baseRequestPost);
    }
}
