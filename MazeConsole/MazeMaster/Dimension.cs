namespace MazeMaster
{
    public class Dimension
    {
        public Dimension(int newheight, int newwidth)
        {
            height = newheight;
            width = newwidth;
        }

        public Dimension()
        {

        }

        public int width { get; set; }

        public int height { get; set; }
    }
}