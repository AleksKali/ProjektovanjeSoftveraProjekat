﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Komunikacija
{
    public class CommunicationHelper
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        
        public void Posalji<T>(T obj) where T : class
        {
            formatter.Serialize(stream, obj);
        }

        public T Primi<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
