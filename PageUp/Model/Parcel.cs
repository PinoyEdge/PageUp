namespace PageUp.Model
{
    public class Parcel : IParcel
    {
        public int Weight { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int Depth { get; set; }

        public string Category()
        {
            if (Weight > 50)
            {
                return "Rejected";
            }
            else if (Weight > 10)
            {
                return "Heavy Parcel";
            }
            else if (Volume() < 1500)
            {
                return "Small Parcel";
            }
            else if (Volume() < 2500)
            {
                return "Medium Parcel";
            }
            else
            {
                return "Large Parcel";
            }
        }

        public string Cost()
        {
            if (Weight > 50)
            {
                return "N/A";
            }
            else if (Weight > 10)
            {
                return (Weight * 15).ToString();
            }
            else if (Volume() < 1500)
            {
                return (Volume() * 0.05).ToString();
            }
            else if (Volume() < 2500)
            {
                return (Volume() * 0.04).ToString();
            }
            else
            {
                return (Volume() * 0.03).ToString();
            }
        }

        public int Volume()
        {
            return Height * Width * Depth;
        }
    }
}
