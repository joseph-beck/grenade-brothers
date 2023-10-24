namespace Network
{
    public class Client
    {
        private int _ip;
        private int _port;

        public Client(int ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public void Connect() { }

        public void Disconnect() { }
    }
}