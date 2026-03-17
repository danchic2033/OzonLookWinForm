using Emgu.CV;
using Emgu.CV.Dnn;
using Emgu.CV.Structure;
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
        {

        }

        private void uploadPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialoge = new OpenFileDialog();
            if (openFileDialoge.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPicture.Image = new Bitmap(openFileDialoge.FileName);
                }
                catch
                { }
            }

            try
            {

                //for openpose
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
                    {"LShoulder",5},
                    { "LElbow", 6 },
                    { "LWrist", 7 },
                    { "MidHip", 8 },
                    { "RHip", 9 },
                    { "RKnee", 10 },
                    {"RAnkle",11},
                    { "LHip", 12 },
                    { "LKnee", 13 },
                    { "LAnkle", 14 },
                    { "REye", 15 },
                    { "LEye", 16 },
                    {"REar",17},
                    { "LEar", 18 },
                    { "LBigToe", 19 },
                    { "LSmallToe", 20 },
                    { "LHeel", 21 },
                    { "RBigToe", 22 },
                    {"RSmallToe",23},
                    { "RHeel", 24 },
                    { "Background", 25 }
                };

                int[,] point_pairs = new int[,]{
                            {1, 0}, {1, 2}, {1, 5},
                            {2, 3}, {3, 4}, {5, 6},
                            {6, 7}, {0, 15}, {15, 17},
                            {0, 16}, {16, 18}, {1, 8},
                            {8, 9}, {9, 10}, {10, 11},
                            {11, 22}, {22, 23}, {11, 24},
                            {8, 12}, {12, 13}, {13, 14},
                            {14, 19}, {19, 20}, {14, 21}};


                // Load the caffe Model
                string prototxt = @"c:\openpose\models\pose\body_25\pose_deploy.prototxt";
                string modelPath = @"c:\openpose\models\pose\body_25\pose_iter_584000.caffemodel";

                var net = DnnInvoke.ReadNetFromCaffe(prototxt, modelPath);

                
                var image = userPicture.Image;
                var imageHeight = image.Height;
                var imageWidth = image.Width;

                // Получение изображения из PictureBox
                Bitmap bitmapImage = (Bitmap)userPicture.Image;

                // Создание Emgu CV изображения
                Image<Bgr, byte> inputImage = bitmapImage.ToImage<Bgr, byte>();

                var blob = DnnInvoke.BlobFromImage(inputImage, 1.0 / 255.0, new Size(inWidth, inHeight), new MCvScalar(0, 0, 0));

                net.SetInput(blob);
                net.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);

                var output = net.Forward();

                var h = output.SizeOfDimension[2];
                var w = output.SizeOfDimension[3];

                var heatMap = output.GetData();

                var points = new List<Point>();

                for (int i = 0; i < nPoints; i++)
                {
                    Matrix<float> matrix = new Matrix<float>(h, w);
                    for (int row = 0; row < h; row++)
                    {
                        for (int col = 0; col < w; col++)
                        {
                            matrix[row, col] = (float)heatMap.GetValue(0, i, row, col);
                        }
                    }
                    double minValue = 0;
                    double maxValue = 0;
                    Point minLoc = default;
                    Point maxLoc = default;
                    CvInvoke.MinMaxLoc(matrix, ref minValue, ref maxValue, ref minLoc, ref maxLoc);

                    var x = (image.Width * maxLoc.X) / w;
                    var y = (image.Height * maxLoc.Y) / h;

                    if (maxValue > threshold)
                    {
                        points.Add(new Point(x, y));
                    }
                    else
                    {
                        points.Add(Point.Empty);
                    }
                }
                //display points

                for (int i = 0; i < points.Count; i++)
                {
                    var p = points[i];
                    if (p != Point.Empty)
                    {
                        CvInvoke.Circle(inputImage, p, 5, new MCvScalar(0, 255, 0), -1);
                        CvInvoke.PutText(inputImage, i.ToString(), p, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.8, new MCvScalar(0, 0, 255), 1, Emgu.CV.CvEnum.LineType.AntiAlias);

                        
                    }
                }

                for (int i = 0; i < point_pairs.GetLongLength(0); i++)
                {
                    var startIndex = point_pairs[i, 0];
                    var endIndex = point_pairs[i, 1];

                    if (points.Contains(points[startIndex]) && points.Contains(points[endIndex]))
                    {
                        CvInvoke.Line(inputImage, points[startIndex], points[endIndex], new MCvScalar(255, 0, 0), 2);
                    }
                }

                userPicture.Image = inputImage.ToBitmap();
            }
            catch 
            { }
        }

        private void getFitResult_Click(object sender, EventArgs e)
        {

        }
    }
}
