using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace StaticBlogExample
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
            .Factory
            .CreateWeb(args)
            .AddSetting(WebKeys.ExcludedPaths,
                new List<NormalizedPath>
                {
                    new NormalizedPath("input/admin"),
                })
            .RunAsync();
    }
}
