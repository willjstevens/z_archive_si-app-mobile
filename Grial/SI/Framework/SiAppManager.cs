using System;
using SI.Service;
using SI.Util;

using SI.Model;
using SI.DTO;


namespace SI.Framework
{
	public class SiAppManager
	{
		public static SiAppManager manager = new SiAppManager();
		public Session session { get; private set; }
		public AccountService accountService { get; private set; }
		public IntuitionService intuitionService { get; private set; }


		private SiAppManager()
		{
			init();
		}

		public void init()
		{
			session = new Session();
			SiHttpClient siHttpClient = new SiHttpClient();
			// circular reference but, it is convenient
			session.siHttpClient = siHttpClient;
			siHttpClient.session = session;

			// setup the account service
			accountService = new AccountService();
			accountService.session = session;
			accountService.siHttpClient = siHttpClient;

			// setup the intuition service
			intuitionService = new IntuitionService();
			intuitionService.session = session;
			intuitionService.siHttpClient = siHttpClient;

		}


	}
}

