// using System;
// using System.Net;
// using System.Net.Sockets;
// using System.Text;

// //  
// public class UserClient
// {

//     private static IPAddress mcastAddress;
//     private static int mcastPort;
//     private static Socket mcastSocket;
//     private static MulticastOption mcastOption;


//     public static void Main(String[] args)
//     {
//         // Initialize the multicast address group and multicast port.
//         // Both address and port are selected from the allowed sets as
//         // defined in the related RFC documents. These are the same 
//         // as the values used by the sender.
//         mcastAddress = IPAddress.Parse("224.168.100.2");
//         mcastPort = 11000;


//         try
//         {
//             mcastSocket = new Socket(AddressFamily.InterNetwork,
//                                      SocketType.Dgram,
//                                      ProtocolType.Udp);


//             IPAddress localIP = IPAddress.Any;
//             EndPoint localEP = (EndPoint)new IPEndPoint(localIP, mcastPort);
//             mcastSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);

//             mcastSocket.Bind(localEP);


//             // Define a MulticastOption object specifying the multicast group 
//             // address and the local IPAddress.
//             // The multicast group address is the same as the address used by the server.
//             mcastOption = new MulticastOption(mcastAddress, localIP);

//             mcastSocket.SetSocketOption(SocketOptionLevel.IP,
//                                         SocketOptionName.AddMembership,     // need to do this once
//                                         mcastOption);


//             bool done = false;
//             byte[] bytes = new Byte[100];
//             IPEndPoint groupEP = new IPEndPoint(mcastAddress, mcastPort);
//             EndPoint remoteEP = (EndPoint)new IPEndPoint(IPAddress.Any, 0);

//             mcastSocket.ReceiveFrom(data, ref remoteEP);

//             Console.WriteLine("Received broadcast from {0} :\n {1}\n",
//               groupEP.ToString(),
//               Encoding.ASCII.GetString(data, 0, data.Length));

//             // Console.WriteLine("Write your message here. Type 'exit' to stop sending messages");
//             // while (true)
//             // {
//             //     input = Console.ReadLine();
//             //     if (input == "exit")
//             //         break;
//             //     mcastSocket.SendTo(Encoding.ASCII.GetBytes(input), remoteEP);
//             //     data = new byte[1024];
//             //     int recv = mcastSocket.ReceiveFrom(data, ref remoteEP);
//             //     stringData = Encoding.ASCII.GetString(data, 0, recv);
//             //     Console.WriteLine(stringData);
//             // }

//             mcastSocket.Close();
//         }

//         catch (Exception e)
//         {
//             Console.WriteLine(e.ToString());
//         }
//     }
// }


