using System;
using System.Net;
using System.Net.Sockets;

namespace Caldera.Core
{
   public class ClientSubsystem : ISubsystem
   {
      public void Start()
      {
         
         var tcpListener = new TcpListener( IPAddress.Any, 4000 );

         tcpListener.Start();

         var socket = tcpListener.AcceptSocketAsync();

         Console.WriteLine( "Connection made: " + socket.RemoteEndPoint );
      }
   }
}
