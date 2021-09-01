using Shiny.Jobs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShinyTest.ShinyConfig
{
    public class FirstJob : IJob
    {
        public async Task Run(JobInfo jobInfo, CancellationToken cancelToken)
        {
            //Console.WriteLine("Passando aqui..");
            await Task.Run(() => System.Diagnostics.Debug.WriteLine($"Service sended at {DateTime.Now.ToString("G")}"));
        }
    }
}