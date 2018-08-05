using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        WcfDto Find(string empid);
        [OperationContract]
        List<WcfDto> All();
        [OperationContract]
        void InsertData(WcfDto obj);
        [OperationContract]
        void Updatedata(WcfDto obj);
        [OperationContract]
        void DeleteData(WcfDto obj);
    }
}
