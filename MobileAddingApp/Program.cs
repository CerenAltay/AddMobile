using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAddingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string mobileName;

            Console.WriteLine("Do you want to add mobile? Press Y or N to exit: ");
            string response = Console.ReadLine();
            
            IList<Mobile> mobiles = new List<Mobile>();

            while (response =="Y")
            {               
                Console.WriteLine("Please enter all the details: Yes or No");
                Console.Write("Enter Mobile Name : ");
                mobileName = Console.ReadLine();
                Console.WriteLine("Features: Calling:Yes");
                Console.WriteLine("SMSSending: Yes");
                Console.Write("FM: ");
                string inputfm = Console.ReadLine();
                Console.Write("Camera: ");
                string inputcamera = Console.ReadLine();

                //still accepts the invalid input???
                try
                {
                    switch (mobileName)
                    {
                        case "Samsung":
                            {
                                Samsung newSamsung = new Samsung();

                                mobiles.Add(new Samsung()
                                {

                                    mobilePhone = "Samsung",
                                    calling = newSamsung.Calling(),
                                    sms = newSamsung.SMSSending(),
                                    fmRadio = newSamsung.FM(inputfm),
                                    cameraFeature = newSamsung.Camera(inputcamera)

                                });
                            }
                            break;

                        case "Nokia":
                            {
                                Nokia newNokia = new Nokia();
                                mobiles.Add(new Samsung()
                                {

                                    mobilePhone = "Nokia",
                                    calling = newNokia.Calling(),
                                    sms = newNokia.SMSSending(),
                                    fmRadio = newNokia.FM(inputfm),
                                    cameraFeature = newNokia.Camera(inputcamera)

                                });
                            }
                            break;

                        case "Apple":
                            {
                                Apple newApple = new Apple();
                                mobiles.Add(new Samsung()
                                {

                                    mobilePhone = "Apple",
                                    calling = newApple.Calling(),
                                    sms = newApple.SMSSending(),
                                    fmRadio = newApple.FM(inputfm),
                                    cameraFeature = newApple.Camera(inputcamera)

                                });
                            }

                            break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Please enter a valid input.");
                }

                Console.Write("Do you want to add mobile? Press Y or N to exit: ");
                response = Console.ReadLine();

            };

            Console.WriteLine();

            foreach (var mobile in mobiles)
            {
                //comma problem on the output
                string output = string.Format("{0}: features : {1}, {2}, {3}, {4}", mobile.mobilePhone, mobile.calling, mobile.sms, mobile.fmRadio, mobile.cameraFeature);
                Console.WriteLine(output);
            }

            Console.ReadKey();

        }
    }
}
