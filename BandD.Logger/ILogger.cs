using System;
using System.ServiceModel;

namespace BandD.Logger
{
    [ServiceContract]
    public interface ILogger
    {
        [OperationContract]
        void SaveErrorToDataBase(Guid applicationId, Guid clientId, Exception exeption);
    }
}