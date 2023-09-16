using System;
using System.Threading.Tasks;
using Hangfire;
using JS.Hangfire.Demo.Samples;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace JS.Hangfire.Demo.Web.Controllers;

public class SampleController : AbpController
{
    public SampleController()
    {
    }
    
    [HttpPost]
    [Route("test")]
    public async Task CreateAsync()
    {
        RecurringJob.AddOrUpdate<SamplesJob>(
            $"recurring-job-{Guid.NewGuid()}",
            x => x.ExecuteAsync(DateTime.Now.Minute),
            Cron.Minutely,
            TimeZoneInfo.Utc,
            queue: "queue-1"
        );

    }
}