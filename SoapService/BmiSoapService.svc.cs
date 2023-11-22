using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class BmiSoapService : IBmiSoapService
    {
        public double myBMI(int height, int weight)
        {
            return ((double)weight / (double)height / (double)height) * 703;
        }

        public BMI myHealth(int height, int weight)
        {
            double bmi = myBMI(height, weight);
            string risk;
            string[] more = {
             "https://www.cdc.gov/healthyweight/assessing/bmi/index.html",
             "https://www.nhlbi.nih.gov/health/educational/lose_wt/index.htm",
             "https://www.ucsfhealth.org/education/body_mass_index_tool/"
            };

            if (bmi < 18)
                risk = "You are underweight - Blue Color";
            else if (bmi >= 18 && bmi < 25)
                risk = "You are normal - Green Color";
            else if (bmi >= 25 && bmi <= 30)
                risk = "You are pre-obese - Purple Color";
            else
                risk = "You are obese - Red Color";

            return new BMI { Bmi = bmi, Risk = risk, More = more };
        }
    }
}
