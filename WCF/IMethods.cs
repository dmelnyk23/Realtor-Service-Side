using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF.DataContracts;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMethods
    {
        [OperationContract]
        void AddUser(User user);

        [OperationContract]
        void ModifyUser(User user);

        [OperationContract]
        void DeleteUser(User user);

        [OperationContract]
        List<User> GetUsers();

        [OperationContract]
        List<Lot> GetLots();

        [OperationContract]
        void ReserveLot(int id);

        [OperationContract]
        void AddLot(Lot lot);

        [OperationContract]
        void LotEdit(Lot lot);

        [OperationContract]
        void DeleteLot(int id);




    }
}
