using System;
using WebMachine.Services;

namespace WebMachine {
    class Program {
        static void Main(string[] args) {

            var _servClient = new ClientService();

            var clients = _servClient.Get();

            //foreach (var client in clients) {
            //    if (client.IsUpdate) {
                    GmapsService.GetAddress(clients);
                    
            //        if (!client.IsUpdate) {
                        
            //        }
            //    }
            //}

            Console.Write("Process concluded");
        }
    }
}
