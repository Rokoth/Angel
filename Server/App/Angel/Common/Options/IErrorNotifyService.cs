using System.Threading.Tasks;

namespace Angel.Common
{
    public interface IErrorNotifyService
    {        
        Task Send(string message, MessageLevelEnum level = MessageLevelEnum.Error, string title = null);
    }
}