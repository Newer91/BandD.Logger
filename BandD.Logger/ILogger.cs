using BandD.Logger.Class;
using System;
using System.ServiceModel;

namespace BandD.Logger
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogger" in both code and config file together.
    [ServiceContract]
    public interface ILogger
    {
        [OperationContract]
        void SaveErrorToDataBase(Guid applicationId, Guid clientId, string exeptionMessage, string methodNamesExeption,string methoNameCode);
    }
}
