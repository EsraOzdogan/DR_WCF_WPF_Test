using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
  
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Hosgeldiniz(string ad);
        [OperationContract]
        string GeçersizKullanıcı();
        [OperationContract]
        string FavorilereEklendi();
        [OperationContract]
        double ekleme(double n1, double n2);
        [OperationContract]
        double silme(double n1, double n2);

    }


}
