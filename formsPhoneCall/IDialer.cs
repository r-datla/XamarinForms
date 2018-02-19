using System;
using System.Threading.Tasks;

namespace formsPhoneCall
{
    public interface IDialer
    {
        Task<bool> DialAsync(string number);
    }
}
