namespace OzonLookWinForm
{
    public partial class FitClothesForm : Form
    {
        public FitClothesForm(Image image)
        {
            InitializeComponent();
            catalogPicture.Image = image;
        }

        private void FitClothesForm_Load(object sender, EventArgs e)
        { }


        private void uploadPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialoge = new OpenFileDialog();
            if (openFileDialoge.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPicture.Image = new Bitmap(openFileDialoge.FileName);
                    var image = userPicture.Image;
                    //userPicture.Image = DetectPose(image);
                }
                catch
                { }
            }
        }

        private void getFitResult_Click(object sender, EventArgs e)
        { }

        //private Bitmap DetectPose(Image image)
        //{
        //    try
        //    {

        //        //for openpose
        //        int inWidth = 368;
        //        int inHeight = 368;
        //        float threshold = 0.1f;
        //        int nPoints = 25;

        //        var BODY_PARTS = new Dictionary<string, int>()
        //        {
        //            { "Nose", 0 },
        //            { "Neck", 1 },
        //            { "RShoulder", 2 },
        //            { "RElbow", 3 },
        //            { "RWrist", 4 },
        //            {"LShoulder",5},
        //            { "LElbow", 6 },
        //            { "LWrist", 7 },
        //            { "MidHip", 8 },
        //            { "RHip", 9 },
        //            { "RKnee", 10 },
        //            {"RAnkle",11},
        //            { "LHip", 12 },
        //            { "LKnee", 13 },
        //            { "LAnkle", 14 },
        //            { "REye", 15 },
        //            { "LEye", 16 },
        //            {"REar",17},
        //            { "LEar", 18 },
        //            { "LBigToe", 19 },
        //            { "LSmallToe", 20 },
        //            { "LHeel", 21 },
        //            { "RBigToe", 22 },
        //            {"RSmallToe",23},
        //            { "RHeel", 24 },
        //            { "Background", 25 }
        //        };

        //        int[,] point_pairs = new int[,]{
        //                    {1, 0}, {1, 2}, {1, 5},
        //                    {2, 3}, {3, 4}, {5, 6},
        //                    {6, 7}, {0, 15}, {15, 17},
        //                    {0, 16}, {16, 18}, {1, 8},
        //                    {8, 9}, {9, 10}, {10, 11},
        //                    {11, 22}, {22, 23}, {11, 24},
        //                    {8, 12}, {12, 13}, {13, 14},
        //                    {14, 19}, {19, 20}, {14, 21}};


        //        // Load the caffe Model
        //        string prototxt = @"c:\openpose\models\pose\body_25\pose_deploy.prototxt";
        //        string modelPath = @"c:\openpose\models\pose\body_25\pose_iter_584000.caffemodel";

        //        var net = DnnInvoke.ReadNetFromCaffe(prototxt, modelPath);

        //        var imageHeight = image.Height;
        //        var imageWidth = image.Width;

        //        // Получение изображения из PictureBox
        //        Bitmap bitmapImage = (Bitmap)image;

        //        // Создание Emgu CV изображения
        //        Image<Bgr, byte> inputImage = bitmapImage.ToImage<Bgr, byte>();

        //        var blob = DnnInvoke.BlobFromImage(inputImage, 1.0 / 255.0, new Size(inWidth, inHeight), new MCvScalar(0, 0, 0));

        //        net.SetInput(blob);
        //        net.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);

        //        var output = net.Forward();

        //        var h = output.SizeOfDimension[2];
        //        var w = output.SizeOfDimension[3];

        //        var heatMap = output.GetData();

        //        var points = new List<Point>();

        //        for (int i = 0; i < nPoints; i++)
        //        {
        //            Matrix<float> matrix = new Matrix<float>(h, w);
        //            for (int row = 0; row < h; row++)
        //            {
        //                for (int col = 0; col < w; col++)
        //                {
        //                    matrix[row, col] = (float)heatMap.GetValue(0, i, row, col);
        //                }
        //            }
        //            double minValue = 0;
        //            double maxValue = 0;
        //            Point minLoc = default;
        //            Point maxLoc = default;
        //            CvInvoke.MinMaxLoc(matrix, ref minValue, ref maxValue, ref minLoc, ref maxLoc);

        //            var x = (image.Width * maxLoc.X) / w;
        //            var y = (image.Height * maxLoc.Y) / h;

        //            if (maxValue > threshold)
        //            {
        //                points.Add(new Point(x, y));
        //            }
        //            else
        //            {
        //                points.Add(Point.Empty);
        //            }
        //        }
        //        //display points

        //        for (int i = 0; i < points.Count; i++)
        //        {
        //            var p = points[i];
        //            if (p != Point.Empty)
        //            {
        //                CvInvoke.Circle(inputImage, p, 5, new MCvScalar(0, 255, 0), -1);
        //                CvInvoke.PutText(inputImage, i.ToString(), p, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.8, new MCvScalar(0, 0, 255), 1, Emgu.CV.CvEnum.LineType.AntiAlias);


        //            }
        //        }

        //        for (int i = 0; i < point_pairs.GetLongLength(0); i++)
        //        {
        //            var startIndex = point_pairs[i, 0];
        //            var endIndex = point_pairs[i, 1];

        //            if (points.Contains(points[startIndex]) && points.Contains(points[endIndex]))
        //            {
        //                CvInvoke.Line(inputImage, points[startIndex], points[endIndex], new MCvScalar(255, 0, 0), 2);
        //            }
        //        }

        //        var result = inputImage.ToBitmap();
        //        return result;
        //    }
        //    catch
        //    {
        //        var result = image;
        //        return (Bitmap)result;
        //    }
        //}

        //private void SegmentClothe()
        //{
        //    if (catalogPicture.Image == null || userPicture.Image == null)
        //        return;

        //    // Исходное изображение одежды (каталога)
        //    Bitmap catalogBitmap = (Bitmap)catalogPicture.Image;

        //    // Создаем маску сегментации верхней одежды по цвету (черный цвет)
        //    Image<Bgr, byte> clothingImage = catalogBitmap.ToImage<Bgr, byte>();
        //    Mat mask = new Mat();

        //    // Цветовая сегментация (черный цвет)
        //    var hsvImage = clothingImage.Convert<Hsv, byte>();
        //    var lowerBound = new Hsv(0, 0, 0);
        //    var upperBound = new Hsv(180, 255, 50);
        //    CvInvoke.InRange(hsvImage, new ScalarArray(lowerBound.MCvScalar), new ScalarArray(upperBound.MCvScalar), mask);

        //    // Улучшение маски
        //    Mat kernel = CvInvoke.GetStructuringElement(0, new Size(5, 5), new Point(-1, -1));
        //    CvInvoke.MorphologyEx(mask, mask, MorphOp.Open, kernel, new Point(-1, -1), 2, BorderType.Default, new MCvScalar());
        //    CvInvoke.MorphologyEx(mask, mask, MorphOp.Close, kernel, new Point(-1, -1), 2, BorderType.Default, new MCvScalar());

        //    // Вырезаем одежду
        //    Image<Bgr, byte> clothes = new Image<Bgr, byte>(clothingImage.Width, clothingImage.Height);
        //    clothes.SetZero();

        //    // Получаем данные маски
        //    byte[,] maskData = (byte[,])mask.GetData();

        //    for (int y = 0; y < clothingImage.Height; y++)
        //    {
        //        for (int x = 0; x < clothingImage.Width; x++)
        //        {
        //            byte maskPixel = maskData[y, x];
        //            if (maskPixel != 0)
        //            {
        //                var pixel = clothingImage[y, x];
        //                clothes[y, x] = pixel;
        //            }
        //        }
        //    }

        //    // Создаем изображение с альфа-каналом для прозрачности
        //    Image<Bgra, byte> clothesWithAlpha = new Image<Bgra, byte>(clothes.Width, clothes.Height);

        //    // Заполняем изображение с альфа-каналом
        //    for (int y = 0; y < clothes.Height; y++)
        //    {
        //        for (int x = 0; x < clothes.Width; x++)
        //        {
        //            var pixelBgr = clothes[y, x];
        //            byte alpha = 255; // полностью непрозрачно
        //            byte maskPixel = maskData[y, x];

        //            if (maskPixel == 0)
        //            {
        //                alpha = 0; // прозрачный
        //            }

        //            clothesWithAlpha[y, x] = new Bgra(pixelBgr.Blue, pixelBgr.Green, pixelBgr.Red, alpha);
        //        }
        //    }

        //    // Масштабируем одежду с прозрачным фоном
        //    var targetBitmap = (Bitmap)userPicture.Image;
        //    int targetWidth = targetBitmap.Width;
        //    int targetHeight = targetBitmap.Height;

        //    var overlay = clothesWithAlpha.Resize(targetWidth / 3, targetHeight / 3, Inter.Linear);

        //    int offsetX = targetWidth / 3;
        //    int offsetY = targetHeight / 3;

        //    // Создаем финальное изображение с прозрачностью
        //    Bitmap resultBitmap = new Bitmap(targetBitmap.Width, targetBitmap.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        //    using (Graphics g = Graphics.FromImage(resultBitmap))
        //    {
        //        g.DrawImage(targetBitmap, 0, 0);
        //        g.DrawImage(overlay.ToBitmap(), offsetX, offsetY);
        //    }

        //    // Выводим результат
        //    resultPicture.Image = resultBitmap;

        //}

    }
}
