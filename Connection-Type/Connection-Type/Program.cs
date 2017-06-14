using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace VPN_Check
{
    class Program
    {
        private const int ERROR_VPN_Connected = 0xA0;
        static void Main(string[] args)
        {
            string macType = string.Empty;
            int VPN_count = 0;
            long maxSpeed = 1;
            int eth_count = 0;
            int WiFi_count = 0;
            int BT_Count = 0;

//look at each adapter found and list it.
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                var temptype = nic.NetworkInterfaceType.ToString();
                //Console.WriteLine("Found MAC Address: " + nic.GetPhysicalAddress() +" Type: " + temptype);
                //VPN or PPP adapter
                if (temptype == "Ppp")
                {
                    Console.WriteLine("VPN connection Found");
                    Console.WriteLine("Name:" +nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    VPN_count++;
                }

                //ethernet adpter that is connected (diffrent types)
                if (nic.Speed > maxSpeed && temptype == "Ethernet")
                {
                                   
                    //Deal with Bluetooth Nic that shows as wired
                    if (nic.Name == "Bluetooth Network Connection")
                    {
                        Console.WriteLine("Name:" + nic.Name);
                        Console.WriteLine("Speed: " + nic.Speed);
                        Console.WriteLine("");
                        BT_Count++;
                    }

                    else
                    {
                        Console.WriteLine("Wired Network connection Found.");
                        Console.WriteLine("Name:" + nic.Name);
                        Console.WriteLine("Speed: " +nic.Speed);
                        Console.WriteLine("");
                        eth_count++;
                    }
                    
                    
                }
                
                if (nic.Speed > maxSpeed && temptype == "GigabitEthernet")
                {
                    Console.WriteLine("Wired Network connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    eth_count++;
                }

                if (nic.Speed > maxSpeed && temptype == "Ethernet3Megabit")
                {
                    Console.WriteLine("Wired Network connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    eth_count++;
                }
                if (nic.Speed > maxSpeed && temptype == "FastEthernetFx")
                {
                    Console.WriteLine("Fiber Network connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    eth_count++;
                }

                if (nic.Speed > maxSpeed && temptype == "Fddi")
                {
                    Console.WriteLine("Fiber Network connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    eth_count++;
                }
                //Tokenring if you are that old
                if (nic.Speed > maxSpeed && temptype == "TokenRing")
                {
                    Console.WriteLine("Token Ring Network connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    eth_count++;
                }



                //WiFi adapter
                if (nic.Speed > maxSpeed && temptype == "Wireless80211")
                {
                    Console.WriteLine("WiFi connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    WiFi_count++;

                }

                if (nic.Speed > maxSpeed && temptype == "Wman")
                {
                    Console.WriteLine("WiMax connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    WiFi_count++;

                }

                if (nic.Speed > maxSpeed && temptype == "Wwanpp")
                {
                    Console.WriteLine("GSM based Broadband connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                    WiFi_count++;

                }

                if (nic.Speed > maxSpeed && temptype == "Wwanpp2")
                {
                    Console.WriteLine("CDMA based Broadband connection Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine(""); WiFi_count++;

                }
                
                //unknown adapter warning
                if (nic.Speed > maxSpeed && temptype == "Unknown")
                {
                    Console.WriteLine("WARNING!!! Unknown connection type Found.");
                    Console.WriteLine("Name:" + nic.Name);
                    Console.WriteLine("Speed: " + nic.Speed);
                    Console.WriteLine("");
                }

                //done looking for adapters
            }

            Console.WriteLine(eth_count + " Wired Network connections found.");
            Console.WriteLine(WiFi_count + " Wireless Network connections found.");
            Console.WriteLine(VPN_count + " VPN Network connections found.");
            Console.WriteLine(BT_Count + " Bluetooth Network connections found. (may not be active)");

            //Console.ReadLine();

        }

    }

}




