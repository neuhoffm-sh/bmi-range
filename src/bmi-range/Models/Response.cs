using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bmi_range.Models
{
    public class Response
    {
        public Response(double bmi)
        {
            if (bmi < 18.5)
            {
                this.RangeName = "Underweight";
                this.Color = "blue";
            } else if (bmi < 25)
            {
                this.RangeName = "Normal weight";
                this.Color = "green";
            } else if (bmi < 30)
            {
                this.RangeName = "Overweight";
                this.Color = "yellow";
            }
            else
            {
                this.RangeName = "Obese";
                this.Color = "red";
            }
        }

        public string RangeName { get; set; }

        public string Color { get; set; }
    }
}
