namespace BancoInterface.Entities.Shapes{
    class Circle : AbstractShape{
        public double Radius { get; set; }

        public override double Area(){
            return Math.PI * Radius * Radius;
        }

        public override string ToString(){
            return "Circle color: " + Color
                    + ", radius: "
                    + Radius
                    + ", area: "
                    + Area();
        }
    }
}