using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_stara_nowa_usluga
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUsluga
    {

        [OperationContract]
        Client[] GetClients();
        [OperationContract]
        Client GetClient(int id);
        [OperationContract]
        void AddClient(Client client);
        [OperationContract]
        void ModifyClient(Client client);
    }

    [DataContract]
    public class Client : IExtensibleDataObject
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
