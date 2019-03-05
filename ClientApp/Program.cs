using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trafikverket.Client;
using Trafikverket.TrafficInfo.Rails.Models;

namespace ClientApp
{
    class Program
    {
        private const string myKey = "";
        private static TrafikVerketClient Client = new TrafikVerketClient(myKey);

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is just an example of how to use the Trafikverket library");
                if (myKey.Length > 5)
                {
                    TestAllStations();
                    TestStationAnnouncements();
                    TestStationDepartures();
                    TestStationMessages();
                }
                else
                {
                    Console.WriteLine("Please edit the ClientApp Program.cs class and supply a valid API key.");
                    Console.WriteLine("You may request an API key from https://api.trafikinfo.trafikverket.se/Account/Register");
                }
                Console.WriteLine("Press Enter to close...");
                Console.ReadLine();
            } 
            catch(Exception ex)
            {
                Console.Write("Exception: " + ex.Message);
            }
        }

        static void TestAllStations()
        {
            List<TrainStation> ret = Client.getAllActiveSwedishStations();
            if(ret != null)
                Console.WriteLine("There are " + ret.Count + " active stations in Sweden");
        }
        static void TestStationAnnouncements()
        {
            List<TrainAnnouncement> ret = Client.getStationArrivals("Hd", 0, 12);
            if (ret != null)
                Console.WriteLine("There are " + ret.Count + " scheduled arrivals to Halmstad C in the next 12 hours");
        }
        static void TestStationDepartures()
        {
            List<TrainAnnouncement> ret = Client.getStationDepartures("Hd", 0, 12);
            if (ret != null)
                Console.WriteLine("There are " + ret.Count + " scheduled Departures from Halmstad C in the next 12 hours");
        }

        static void TestStationMessages()
        {
            List<TrainMessage> ret = Client.getStationMessages("Hd");
            if (ret != null)
                Console.WriteLine("There are " + ret.Count + " messages for Halmstad C");
        }
    }
}
