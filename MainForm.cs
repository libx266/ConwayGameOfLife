using System.Windows.Forms;

namespace ConwayGameOfLife
{
    public partial class MainForm : Form
    {
        public MainForm() =>
            InitializeComponent();

        ConwayFrame currentFrame;
        DirectBitmap? oldBitmap;
        bool enable = false;


        private Dictionary<string, string> GetArgs() =>
            argsTextBox.Text.Split(' ').ToDictionary(x => x.Split('=').First(), x => x.Split('=').Last());


        private void updatePictureBoxImage(DirectBitmap newImage)
        {
            oldBitmap?.Dispose();
            pictureBox1.Image?.Dispose();
            oldBitmap = newImage;
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new Action(() => pictureBox1.Image = newImage.Bitmap));
            }
            else
            {
                pictureBox1.Image = newImage.Bitmap;
            }
        }


        private async Task loop(double renderPeriod, double computePeriod)
        {
            enable = false;
            await Task.Delay(TimeSpan.FromSeconds(renderPeriod) + TimeSpan.FromMilliseconds(2));
            enable = true;

            var render = Task.Run(async () =>
            {
                while (true)
                {
                    if (!enable)
                    {
                        break;
                    }
                    lock (currentFrame)
                    {
                        updatePictureBoxImage(currentFrame.Render(Color.Black, Color.Green));
                    }
                    await Task.Delay(TimeSpan.FromSeconds(renderPeriod));
                }
            });

            var compute = Task.Run(async () =>
            {
                while (true)
                {
                    if (!enable)
                    {
                        break;
                    }
                    currentFrame = await currentFrame.Next();
                    await Task.Delay(TimeSpan.FromSeconds(computePeriod));
                }
            });

            await Task.WhenAll(render, compute);
        }


        private async void buttonStartClick(object sender, EventArgs e)
        {
            var args = GetArgs();
            double renderPeriod = 1.0 / Convert.ToDouble(args["render_fps"]);
            double computePeriod = 1.0 / Convert.ToDouble(args["compute_fps"]);

            var split = (string n, char sep) =>
            {
                var a = args[n].Split(sep);
                return (Convert.ToByte(a[0]), Convert.ToByte(a[1]));
            };

            var spawn = split("spawn", '-');
            var live = split("live", '-');
            var scope = split("scope", 'x');
            var seed = Convert.ToInt32(args["seed"]);

            var createSeed = () =>
            {
                if (!Convert.ToBoolean(seed))
                {
                    seed = Random.Shared.Next(Int32.MinValue, Int32.MaxValue);
                }
                label.Text = $"seed:  " + seed;
                return seed;
            };

            currentFrame ??= new ConwayFrame(new ConwayConfig
            (
                spawn.Item1,
                spawn.Item2,
                live.Item1,
                live.Item2,
                scope.Item1,
                scope.Item2,
                createSeed(),
                Convert.ToSingle(args["first_gen_alive"].Split('%').First()) / 100f,
                new Size(pictureBox1.Width / 2, pictureBox1.Height / 2)
            ));

            await loop(renderPeriod, computePeriod);
        }


        private void buttonPauseClick(object sender, EventArgs e) =>
            enable = false;


        private async void buttonStopClick(object sender, EventArgs e)
        {
            enable = false;
            await Task.Delay(100);
            currentFrame = default;
            oldBitmap?.Dispose();
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
        }
    }
}