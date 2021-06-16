namespace PageUp.Model
{
    public interface IParcel
    {
        int Depth { get; set; }
        int Height { get; set; }
        int Weight { get; set; }
        int Width { get; set; }

        string Category();
        string Cost();
        int Volume();
    }
}