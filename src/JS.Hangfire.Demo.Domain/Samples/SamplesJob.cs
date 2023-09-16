using System;
using System.Threading.Tasks;
using Hangfire;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Emailing;

namespace JS.Hangfire.Demo.Samples;

[Queue("samples")]
public class SamplesJob
    : AsyncBackgroundJob<int>, ITransientDependency
{
    public SamplesJob()
    {
        
    }
    public override  Task ExecuteAsync(int id)
    {
        Console.WriteLine($"SamplesJob: {id}");
        return Task.CompletedTask;
    }
}

