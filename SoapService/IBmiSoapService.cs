using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBmiSoapService
    {
        [OperationContract]
        double myBMI(int height, int weight);

        [OperationContract]
        BMI myHealth(int height, int weight);
    }
    public class BMI
    {
        public double Bmi { get; set; }
        public string Risk { get; set; }
        public string[] More { get; set; }
    }
}
