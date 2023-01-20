namespace AreasUtils
{
    public class AerasDims
    {

        int Length { get; set; }
        int Width { get; set; }

        public decimal perimeter => (this.Length+this.Width)*2;

        public AerasDims(int length, int width)
        {
            Length = length;
            Width = width;  
        }
    }
}