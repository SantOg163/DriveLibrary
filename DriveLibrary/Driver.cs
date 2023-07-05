using System.Collections.Generic;
using System.Text;

namespace DriveLibrary
{
    public class Driver
    {
        //Сантурян
        public Driver(string name, string @class)
        {
            Name = name;
            Class = @class;
            Autos = new List<Auto>();
        }
        public Driver(string name, string @class, List<Auto> autos)
        {
            Name = name;
            Class = @class;
            Autos = autos;
            if (Autos == null)
                Autos = new List<Auto>();
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> Autos { get; set; }
        public void AddAuto(Auto auto) => Autos.Add(auto);
        public StringBuilder ShowAll()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Class: {Class}");
            foreach( Auto auto in Autos )
            {
                stringBuilder.AppendLine(auto.Show());
            }
            return stringBuilder;
        }
    }
}
