namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public void Drive();
        

    }

}