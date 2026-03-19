using Emgu.CV;
using Emgu.CV.Dnn;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using SixLabors.ImageSharp.ColorSpaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hsv = Emgu.CV.Structure.Hsv;

namespace OzonLookWinForm
{
    public partial class FitClothesForm : Form
    {
        private Image<Bgra, byte> clothesWithAlpha;
        public FitClothesForm(Image image)
        {
            InitializeComponent();
            catalogPicture.Image = image;
        }

        private void FitClothesForm_Load(object sender, EventArgs e)
        {
            SegmentClothe();
        }


        private void ProcessAndOverlayClothes()
        {
            // Проверка наличия изображений
            if (userPicture.Image == null || catalogPicture.Image == null)
            {
                MessageBox.Show("Загрузите изображения!");
                return;
            }

            // Шаг 1: Сегментация одежды (если еще не выполнена)
            if (clothesWithAlpha == null)
            {
                SegmentClothe();
            }

            // Шаг 2: Детекция позы
            var imageBitmap = (Bitmap)userPicture.Image;
            List<Point> keypoints = DetectPose(imageBitmap);

            // Шаг 3: Наложение одежды
            OverlayClothesOnPerson(imageBitmap, keypoints, clothesWithAlpha);
        }

        private void SegmentClothe()
        {
            // Предполагается, что у вас есть изображение одежды из catalogPicture
            Bitmap clothingBitmap = new Bitmap(catalogPicture.Image);

            // Вызов сегментации (предположим, что у вас есть функция)
            // Например, сегментация с помощью OpenCV или другого метода
            // Здесь нужно вставить ваш код сегментации, возвращающий Image<Bgra, byte>
            // Для примера создадим просто копию изображения без сегментации
            clothesWithAlpha = new Image<Bgra, byte>(clothingBitmap.Width, clothingBitmap.Height);
            for (int y = 0; y < clothingBitmap.Height; y++)
            {
                for (int x = 0; x < clothingBitmap.Width; x++)
                {
                    var pixel = clothingBitmap.GetPixel(x, y);
                    // Для примера - делаем полностью прозрачный фон и яркую одежду
                    if (pixel.R > 200 && pixel.G > 200 && pixel.B > 200)
                    {
                        // Прозрачный
                        clothesWithAlpha[y, x] = new Bgra(0, 0, 0, 0);
                    }
                    else
                    {
                        // Одежда
                        clothesWithAlpha[y, x] = new Bgra(pixel.B, pixel.G, pixel.R, 255);
                    }
                }
            }
        }

        // Метод для получения ключевых точек позы
        // Основной метод для получения точек позы
        private List<Point> DetectPose(Bitmap image)
        {
            var points = new List<Point>();
            try
            {
                int inWidth = 368;
                int inHeight = 368;
                float threshold = 0.1f;
                int nPoints = 25;

                var BODY_PARTS = new Dictionary<string, int>()
                {
                    { "Nose", 0 },
                    { "Neck", 1 },
                    { "RShoulder", 2 },
                    { "RElbow", 3 },
                    { "RWrist", 4 },
                    { "LShoulder", 5 },
                    { "LElbow", 6 },
                    { "LWrist", 7 },
                    { "MidHip", 8 },
                    { "RHip", 9 },
                    { "RKnee", 10 },
                    { "RAnkle", 11 },
                    { "LHip", 12 },
                    { "LKnee", 13 },
                    { "LAnkle", 14 },
                    { "REye", 15 },
                    { "LEye", 16 },
                    { "REar", 17 },
                    { "LEar", 18 },
                    { "LBigToe", 19 },
                    { "LSmallToe", 20 },
                    { "LHeel", 21 },
                    { "RBigToe", 22 },
                    { "RSmallToe", 23 },
                    { "RHeel", 24 }
                };

                int[,] point_pairs = new int[,]
                {
                    {1, 0}, {1, 2}, {1, 5},
                    {2, 3}, {3, 4}, {5, 6},
                    {6, 7}, {0, 15}, {15, 17},
                    {0, 16}, {16, 18}, {1, 8},
                    {8, 9}, {9, 10}, {10, 11},
                    {11, 22}, {22, 23}, {11, 24},
                    {8, 12}, {12, 13}, {13, 14},
                    {14, 19}, {19, 20}, {14, 21}
                };

                string prototxt = @"c:\openpose\models\pose\body_25\pose_deploy.prototxt";
                string modelPath = @"c:\openpose\models\pose\body_25\pose_iter_584000.caffemodel";

                var net = DnnInvoke.ReadNetFromCaffe(prototxt, modelPath);
                var inputImage = image.ToImage<Bgr, byte>();
                var blob = DnnInvoke.BlobFromImage(inputImage, 1.0 / 255.0, new Size(inWidth, inHeight), new MCvScalar(0, 0, 0));
                net.SetInput(blob);
                net.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);
                var output = net.Forward();

                int h = output.SizeOfDimension[2];
                int w = output.SizeOfDimension[3];
                var heatMap = output.GetData();

                for (int i = 0; i < nPoints; i++)
                {
                    var matrix = new Matrix<float>(h, w);
                    for (int row = 0; row < h; row++)
                        for (int col = 0; col < w; col++)
                            matrix[row, col] = (float)heatMap.GetValue(0, i, row, col);

                    double minVal = 0, maxVal = 0;
                    Point minLoc = default, maxLoc = default;
                    CvInvoke.MinMaxLoc(matrix, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                    double x = (image.Width * maxLoc.X) / w;
                    double y = (image.Height * maxLoc.Y) / h;

                    if (maxVal > threshold)
                        points.Add(new Point((int)x, (int)y));
                    else
                        points.Add(Point.Empty);
                }
            }
            catch
            {
                // В случае ошибки возвращаем пустой список
                return new List<Point>();
            }
            return points;
        }

        private void OverlayClothesOnPerson(Bitmap personImage, List<Point> keypoints, Image<Bgra, byte> clothesWithAlpha)
        {
            if (keypoints == null || keypoints.Count < 19 || clothesWithAlpha == null)
                return;

            // Индексы точек в модели (по вашему прототипу или модели)
            int leftShoulderIdx = 5;   // Левая плечо
            int rightShoulderIdx = 2;  // Правое плечо
            int neckIdx = 1;           // Шея
            int midHipIdx = 8;         // Линия талии/бедра (MidHip)
            int leftElbowIdx = 6;      // Левая рука
            int rightElbowIdx = 3;     // Правая рука

            // Получаем координаты
            Point leftShoulder = keypoints[leftShoulderIdx];
            Point rightShoulder = keypoints[rightShoulderIdx];
            Point neck = keypoints[neckIdx];
            Point midHip = keypoints[midHipIdx];
            Point leftElbow = keypoints[leftElbowIdx];
            Point rightElbow = keypoints[rightElbowIdx];

            // Проверка, что точки найдены
            if (leftShoulder == Point.Empty || rightShoulder == Point.Empty || neck == Point.Empty || midHip == Point.Empty)
                return;

            // Расчет ширины и высоты области одежды
            // Можно использовать расстояние между плечами для ширины
            double shouldersWidth = Distance(leftShoulder, rightShoulder);
            // Высота - от шеи до линии талии
            double height = Distance(neck, midHip);

            // Центр области (можем взять середину между плечами)
            Point center = new Point((leftShoulder.X + rightShoulder.X) / 2, (leftShoulder.Y + rightShoulder.Y) / 2);

            // Расчет верхней левой точки области
            int topLeftX = (int)(center.X - shouldersWidth / 2);
            int topLeftY = (int)(neck.Y); // начинаем чуть выше шеи

            // Масштабируем одежду под размеры
            var resizedClothes = clothesWithAlpha.Resize((int)shouldersWidth, (int)height, Emgu.CV.CvEnum.Inter.Linear);

            // Позиционируем одежду
            int offsetX = topLeftX;
            int offsetY = topLeftY;

            // Создаем итоговое изображение
            Bitmap resultBitmap = new Bitmap(personImage.Width, personImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                g.DrawImage(personImage, 0, 0);
                g.DrawImage(resizedClothes.ToBitmap(), offsetX, offsetY);
            }

            resultPicture.Image = resultBitmap;
        }

        // Вспомогательная функция для вычисления расстояния между точками
        private double Distance(Point p1, Point p2)
        {
            if (p1 == Point.Empty || p2 == Point.Empty)
                return 0;
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

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
        {
            ProcessAndOverlayClothes();
        }

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
