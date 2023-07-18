﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IServiceRepository
	{
		List<Service> getAllService();
		void UpdateService(Service service);
		void CreateService(Service service);
		List<Service> getAllServiceCus();
		public Service GetServiceById(int id);

    }
}
