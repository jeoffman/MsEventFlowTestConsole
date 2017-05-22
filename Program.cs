using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.EventFlow;

namespace MsEventFlowTestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			TraceSource _traceSource = new TraceSource("Metriks");
			var s1 = System.Environment.MachineName;
			var s2 = Dns.GetHostName();

			var u1 = System.Environment.UserName;
			var u2 = System.Environment.GetEnvironmentVariable("username");

			using(var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
			{
				System.Diagnostics.Trace.TraceWarning("TRACE: EventFlow is working!");
				_traceSource.TraceInformation("TRACE SOURCE: EventFlow is working!");
				_traceSource.TraceData(TraceEventType.Information, 0, new { MyMeasurement1 = 3 });
			}

			//Console.ReadLine();
		}
	}
}
