using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedHMICS.Libs
{
    public class Sender
    {
        private string email { get; set; }
        private string password { get; set; }
        private string server { get; set; }
        private int port { get; set; }

        public Sender(string email, string password, int porta, string server)
        {
            this.email = email;
            this.password = password;
            this.server = server;
            this.port = porta;
        }

        public Sender()
        {

        }

        public string GetEmail()
        {
            return email;
        }
        public string GetPass()
        {
            return password;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetPass( string password)
        {
            this.password = password;
        }
        public string GetServer()
        {
            return server;
        }
        public int GetPort()
        {
            return port;
        }
        public void SetServer(string server)
        {
            this.server = server;
        }
        public void SetPort(int porta)
        {
            this.port = porta;
        }
    }
}
