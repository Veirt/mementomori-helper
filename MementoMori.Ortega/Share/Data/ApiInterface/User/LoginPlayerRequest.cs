﻿using MessagePack;

namespace MementoMori.Ortega.Share.Data.ApiInterface.User
{
	[OrtegaApi("user/loginPlayer", false, true)]
	[MessagePackObject(true)]
	public class LoginPlayerRequest : ApiRequestBase
	{
		public string Password
		{
			get;
			set;
		}

		public long PlayerId
		{
			get;
			set;
		}

		public LoginPlayerRequest()
		{
		}
	}
}
