using System;
using System.Collections.Generic;
using System.Web.Http;

namespace magic_api_app_project_name_magic.Controllers
{
	public class magic_controller_name_magicController : System.Web.Http.ApiController
	{
		[HttpGet]
		[Route("api/magic_controller_name_magic")]
		public String Get()
		{
			return "Hello API App!";
		}
	}
}
