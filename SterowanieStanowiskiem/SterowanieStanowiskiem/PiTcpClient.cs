using System.Net.Sockets;

namespace PiController
{
    public class PiTcpClient
    {
        private TcpClient client;
        private NetworkStream stream;

        public bool Connect(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Send(byte command, byte value)
        {
            byte[] data = new byte[] { command, value };
            stream.Write(data, 0, data.Length);
        }

        public byte[] SendAndReceive(byte command, byte value)
        {
            Send(command, value);
            byte[] response = new byte[2];
            stream.Read(response, 0, 2);
            return response;
        }

        public void Close()
        {
            stream?.Close();
            client?.Close();
        }
    }
}
