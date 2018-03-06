using System;
using Newtonsoft.Json.Serialization;

namespace SI.Util
{
	public class BooleanJsonPropertyNamingStrategy : NamingStrategy 
	{
		public BooleanJsonPropertyNamingStrategy()
		{
		}



		protected override string ResolvePropertyName(string name)
		{
			throw new NotImplementedException();
		}


	}
}

