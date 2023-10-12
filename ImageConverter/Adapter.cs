namespace ImageConverter
{
    //Adapter
    public partial class Adapter : IEditPNG
    {
        private CropJPEG _cropJPEG;
        public Adapter(CropJPEG cropJPEG) {
            _cropJPEG = cropJPEG;
        }
        public override void CropPNG()
        {
            Console.WriteLine("Image converted");
            _cropJPEG.CropImageJPEG();
        }
    }
}