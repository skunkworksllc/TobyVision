using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.LifeCam;
using System.Drawing;
using System.Windows;
using AForge.Video;
using AForge.Video.DirectShow;
//using AForge.Imaging;
//using AForge.Imaging.Filters;
using AForge;


namespace TobyVision
{


    //this class wraps up the instantiation of  Camera SDK and comunication with the camera
    //it is to connect to and grab images from the Camera. Used for that and that ONLY
    class MVCamera
    {

        private bool go;
        private TobyVision caller;
        private Bitmap bitmap;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;


        public MVCamera(TobyVision caller)
        {
            this.caller = caller;
            bitmap = new Bitmap(1, 1);
            InitCamera();
        }

        private void InitCamera()
        {
            this.go = false;

            try
            {
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                FinalFrame = new VideoCaptureDevice(CaptureDevice[1].MonikerString);// specified web cam and its filter moniker string
                FinalFrame.NewFrame += new NewFrameEventHandler(UpdateCurrentFrame);// click button event is fired, 
                FinalFrame.Start();
                go = true;
            }
            catch (Exception e)
            {
                caller.DisplayMessage(e.Message.ToString());
            }

        }

        private void UpdateCurrentFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
        }


        public Bitmap GetBitmap() { return new Bitmap(bitmap, bitmap.Width, bitmap.Height); }

        public bool SeemsGoodToGo() { return go; }

        public void Trash()
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
            GC.SuppressFinalize(this);
        }


    }


}
