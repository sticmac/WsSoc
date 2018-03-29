using System.Runtime.Serialization;

namespace MathsLibrary
{
    [DataContract(Namespace="http://Microsoft.ServiceModel.Samples")]
    class CustomFaultDetails
    {
        [DataMember]  
        public string ErrorId { get; set; }
        [DataMember]  
        public string ErrorDetails { get; set; }
    }
}