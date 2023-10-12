namespace ImageConverter
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            CropJPEG cropJPEG = new CropJPEG();
            IEditPNG editPNG = new Adapter(cropJPEG);

            editPNG.CropPNG();
            //editPNG.AdjustColorPNG();
            //editPNG.RotatePNG();
        }
    }
}