using Hik.Communication.Scs.Client;
using Hik.Communication.Scs.Communication.EndPoints.Tcp;
using Hik.Communication.Scs.Communication.Messages;
using Hik.Communication.Scs.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klinik3
{
    class ClientServer
    {
        public void StartClient() 
        {
            //Create a client object to connect a server on 127.0.0.1 (local) IP and listens 10085 TCP port
            client = ScsClientFactory.CreateClient(new ScsTcpEndPoint(Klinik3.Properties.Settings.Default.HostPCName, Klinik3.Properties.Settings.Default.Port));

            client.Connect(); //Connect to the server
            //Console.Write("Write some message to be sent to server: ");
            //var messageText = Console.ReadLine(); //Get a message from user
            ////Send message to the server
            //client.SendMessage(new ScsTextMessage(messageText));
        }

        public void StartServer()
        {
            //Create a server that listens 10085 TCP port for incoming connections
            Server = ScsServerFactory.CreateServer(new ScsTcpEndPoint(Klinik3.Properties.Settings.Default.Port));
            Server.Start(); //Start the server
        }
        /// <summary>
        /// Write notification to all listening client to indicate database event occurs
        /// </summary>
        /// <param name="evtmsg"></param>
        public void WriteEntry(string evtmsg)
        {
            client.SendMessage(new ScsTextMessage(evtmsg));
        }
        
        public IScsServer Server;
        public IScsClient client;

    }
}
