using System;
using System.Collections.Generic;
using WebMachine.Models;

namespace WebMachine.Services {
    class ClientServices {

        public static List<Client> GetAll() {
            List<Client> Clients = new List<Client>();

            try {
                Clients.Add(new Client() {
                    Id = 1,
                    Name = "Test_1",
                    IdCompany = 0,
                    Coordinate = new Coordinate() {
                        Latitude = -16.740217,
                        Longitude = -49.294298
                    }
                });

                Clients.Add(new Client() {
                    Id = 2,
                    Name = "Test_2",
                    IdCompany = 0,
                    Coordinate = new Coordinate() {
                        Latitude = -16.732069,
                        Longitude = -49.296937
                    }
                });

                Clients.Add(new Client() {
                    Id = 3,
                    Name = "Test_3",
                    IdCompany = 0,
                    Coordinate = new Coordinate() {
                        Latitude = -16.733137,
                        Longitude = -49.306554
                    }
                });

                return Clients;
            } catch (Exception ex) {
                throw new Exception($"Erro ao buscar Clientes. : {ex}");
            }
        }
    }
}
