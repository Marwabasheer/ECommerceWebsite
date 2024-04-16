﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ECommerceWebsite.Admin
{
	public class Connection
	{
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter sda;
		DataTable dt;

		public static string getConnection()
		{
			return ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
		}
		public static bool isValidExtension(string fileName)
		{
			bool isValid = false;
			string[] fileExtension = { ".jpg", ".png", ".jpeg" };
			foreach( string file in fileExtension)
			{

				if (fileName.Contains(file))
				{
					isValid = true;
					break;
				}
			}
			return isValid;
		}

		public static string getUniqueId()
		{
			Guid guid = Guid.NewGuid();
			return guid.ToString();
		}
		public static string getImageUrl(Object url)
		{
			string url1 = string.Empty;
			if(string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
			{
				url1 = "../Images/No_image.png";
			}
			else
			{
				url1 = string.Format("../{0}", url);
			}
			return url1;
		}
	}
}