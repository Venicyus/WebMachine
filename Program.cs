using System;
using WebMachine.Services;

namespace WebMachine {
    class Program {
        static void Main(string[] args) {

            var clients = ClientServices.GetAll();

            GmapsService.GetAddress(clients);

            Console.Write("Process concluded");
        }
    }
}
