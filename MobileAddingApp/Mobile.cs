using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAddingApp
{
    public abstract class Mobile
    {
        public string calling { get; set; }
        public string sms { get; set; }
        public string mobilePhone {get;set; }
        public string fmRadio { get; set; }
        public string cameraFeature { get; set; }

        public string Calling()
        {
            return "Calling";
        }

        public string SMSSending()
        {
            return "SMSSending";
        }
        public string FM(string input)
        {
            if (input == "Yes")
            {
                return "FM";
            }
            else
            {
                return null;
            }
        }

        public string Recording(string input)
        {
            if (input == "Yes")
            {
                return "Recording";
            }
            else
            {
                return null;
            }
        }

        public string Camera(string input)
        {
            if (input == "Yes")
            {
                return "Camera";
            }
            else
            {
                return null;
            }
        }

        public abstract string DisplayFeatures();
        
                  
    }
}
