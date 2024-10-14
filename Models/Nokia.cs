namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // this is an constructor
        public Nokia(string number, string model, string imei, int memory) : 
        base(number, model, imei, memory){}
        public override void InstalarAplicativo(string AppName)
        {
            Console.WriteLine("Installing " + AppName);
        }
    }
}