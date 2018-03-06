using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;
using SI.DTO;
using SI.Util;

namespace SI.Model
{
	public class DesignViewModel
	{
		public IntuitionDto intuitionDto { get; set; }

		public DesignViewModel()
		{
			intuitionDto = new IntuitionDto();
			intuitionDto.intuition = new Intuition();
			intuitionDto.intuition.intuitionText = "HELLO 3";


			Logger.info("*************: WJS wjs LOADING");  
			Debug.WriteLine("INFO: *************: WJS wjs LOADING 2");


			loadEmbeddedResource();
		}

		public void loadEmbeddedResource()
		{
			var assembly = typeof(DesignViewModel).GetTypeInfo().Assembly;

			// load intuition object
			Stream stream = assembly.GetManifestResourceStream("SI.Data.intuition.json");
			string json = "";
			using (var reader = new System.IO.StreamReader(stream)) {
				json = reader.ReadToEnd();
			}
			Logger.info("*************: JSON:  " + json);
			this.intuitionDto = JsonConvert.DeserializeObject<IntuitionDto>(json);
		}

	}
}
