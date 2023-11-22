using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace ASPRest.Controllers
{
   // [EnableCors("51205", "*", "*")]
    public class BmiController : ApiController
    {
        [HttpGet]
        [Route("api/bmi/myBMI")]
        public double myBMI(int height, int weight)
        {
            return ((double)weight / (double)height / (double)height) * 703;
        }

        [HttpGet]
        [Route("api/bmi/myHealth")]
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

    public class BMI
    {
        public double Bmi { get; set; }
        public string Risk { get; set; }
        public string[] More { get; set; }
    }

}
