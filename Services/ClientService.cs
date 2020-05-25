using MongoDB.Driver;
using System.Collections.Generic;
using WebMachine.Models;

namespace WebMachine.Services {
    class ClientService {
        private readonly IMongoCollection<Client> _client;

        public ClientService() {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("dbteste");

            _client = database.GetCollection<Client>("client");
        }

        public Client Create(Client client) {
            _client.InsertOne(client);
            return client;
        }

        public List<Client> Get() => _client.Find(client => client.IsUpdate).ToList();

        public Client Get(string id) => _client.Find<Client>(client => client.Id == id).FirstOrDefault();
               
        public void Update(string id, Client clientIn) =>
            _client.ReplaceOne(client => client.Id == id, clientIn);

        public void Remove(Client clientIn) =>
            _client.DeleteOne(client => client.IdClient == clientIn.IdClient);

        public void Remove(string id) =>
            _client.DeleteOne(client => client.Id == id);

    }
}
