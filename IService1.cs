using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cursoeva
{
        [ServiceContract]
    public interface IService1
    {
            /// <summary>
            /// Encontrar dado
            /// </summary>
            /// <param name="value">Valor para encontrar dado</param>
            /// <returns></returns>
        [OperationContract]
        string GetData(int value);

        /// <summary>
        /// Encontrar dado com o parãmetro composto
        /// </summary>
        /// <param name="composite">Dado Composto</param>
        /// <returns></returns>
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        

            /// <summary>
            /// Remove dado pelo ID
            /// </summary>
            /// <param name="id">ID do Dado</param>
            /// <returns></returns>
        [OperationContract]
        CompositeType RemoveData(int id);
        
        /// <summary>
        /// Atualiza info do dado pelo ID
        /// </summary>
        /// <param name="id">ID do Dado</param>
        /// <param name="newinfo">Informação a ser inserida no dado</param>
        /// <returns></returns>
        [OperationContract]
        CompositeType UpdateData(int id, string newinfo);

    }


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember]
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}
