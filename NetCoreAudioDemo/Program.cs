using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.NodeServices;
using System;
using System.IO;

namespace NetCoreAudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			if (args.Length == 0)
			{
				Console.WriteLine("No audio file specified");
				return;
			}

			var webHost = BuildWebHost(Directory.GetCurrentDirectory(), args);
			var nodeServices = (INodeServices)webHost.Services.GetService(typeof(INodeServices));

			for (int i = 0; i < args.Length; i++)
			{
				// Each argument is a file name
				Console.WriteLine($"Attempting to play {args[i]}");
				var playbackResult = nodeServices.InvokeExportAsync<string>("./play-audio", "play", args[i]).Result;
				Console.WriteLine(playbackResult);
			}
		}

		public static IWebHost BuildWebHost(string pathToContentRoot, string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
				.UseContentRoot(pathToContentRoot)
				.UseStartup<Startup>()
				.Build();
		}
	}
}
