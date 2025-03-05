using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_02___Media_Player__WAV_files_
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new WorkerClass();
            worker.PlayWavFile();
        }


    }
}
