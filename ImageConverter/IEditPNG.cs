namespace ImageConverter
{
    //Target
    public partial class IEditPNG
    {
        public virtual void CropPNG() {}
        public void AdjustColorPNG()
        {
            Console.WriteLine("Image color adjusted");
        }
        public void RotatePNG()
        {
            Console.WriteLine("Image rotated");
        }
    }
}