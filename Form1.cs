using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace HalconImageTest
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var himage = new HImage("Lina.jpg");
            hWindowControl.SetFullImagePart(himage);
            hWindowControl.HalconWindow.DispColor(himage);
        }

        private async void btnMemoryLeak_Click(object sender, EventArgs e)
        {
            await ShowImage(ImageProcess1);
        }

        private async void btUsing_Click(object sender, EventArgs e)
        {
            await ShowImage(ImageProcess2);
        }

        private static HImage ImageProcess1()
        {
            return new HImage(fileName: "Lina.jpg")
                .Rgb1ToGray()
                .MirrorImage(mode: "column")
                .MirrorImage(mode: "row")
                .RotateImage(phi: 90.0, interpolation: "constant");
        }

        private static HImage ImageProcess2()
        {
            var image = new HImage(fileName: "Lina.jpg");
            using (var tempImage = image)
                image = tempImage.Rgb1ToGray();
            using (var tempImage = image)
                image = tempImage.MirrorImage(mode: "column");
            using (var tempImage = image)
                image = tempImage.MirrorImage(mode: "row");
            using (var tempImage = image)
                image = tempImage.RotateImage(phi: 90.0, interpolation: "constant");
            return image;
        }

        private async Task ShowImage(Func<HImage> getImage)
        {
            if (cts != null)
                return;
            cts = new CancellationTokenSource();
            var token = cts.Token;
            for (int i = 0; i < 1000; i++)
            {
                lblStatus.Text = $"Image Process {i}";
                var himage = await Task.Run(getImage, token);
                if (token.IsCancellationRequested) return;

                hWindowControl.SetFullImagePart(himage);
                hWindowControl.HalconWindow.DispImage(himage);
                himage.Dispose();
                await Task.Delay(10, token);

                if (token.IsCancellationRequested) return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            cts = null;
            GC.Collect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
            cts = null;
        }

        private string GetMemoryUse()
        {
            //var currentProcess = Process.GetCurrentProcess();
            //var counter = new PerformanceCounter("Process",
            //    "Working Set - Private", currentProcess.ProcessName);
            //return $",Memory Use : {counter.NextValue() / 1024 / 1024:F3}MB";
            return $",Memory Use : {(GC.GetTotalMemory(false) / (1024 ))}MB";
        }
    }
}
