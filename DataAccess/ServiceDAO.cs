using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class ServiceDAO
	{
		public static List<Service> getAllService()
		{
			var list = new List<Service>();
			try
			{
				using(var context = new BirdClinicContext())
				{
					list = context.Services.ToList();
				}
			}catch (Exception ex)
			{

			}
			return list;
		}
	}
}
