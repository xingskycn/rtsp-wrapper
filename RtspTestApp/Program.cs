using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RtspTestApp
{
    //modelled after http://www.live555.com/liveMedia/doxygen/html/testRTSPClient_8cpp-source.html
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {

            var app = new RtspTest();
            app.OpenUrl("rtsp://127.0.0.1:8554/mind");
            app.Start();
        }
    }
}
