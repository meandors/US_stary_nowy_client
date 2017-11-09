using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_stara_nowa_usluga
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Usluga : IUsluga
    {

        List<Client> listOfClients = new List<Client>();
        public void AddClient(Client client)
        {
            client.Id = listOfClients.Count;
            listOfClients.Add(client);
        }

        public Client GetClient(int id)
        {
            return listOfClients.ElementAt(id);
        }

        public Client[] GetClients()
        {
            Client[] clients = new Client[listOfClients.Count];
            for (int i = 0; i < listOfClients.Count; i++)
            {
                clients[i] = listOfClients.ElementAt(i);
            }
            return clients;
        }

        public void ModifyClient(Client client)
        {
            listOfClients.Insert(client.Id, client);
        }
    }
}
