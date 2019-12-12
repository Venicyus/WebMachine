namespace WebMachine.Models {
    class Client {

        public long Id { get; set; }
        public string Name { get; set; }
        public int IdCompany { get; set; }
        public string Address { get; set; } = "";
        public Coordinate Coordinate { get; set; }
    }
}
