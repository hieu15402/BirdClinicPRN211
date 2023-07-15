using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class BookingRepository : IBookingRepository
	{
		public List<Booking> getAllBooking() => BookingDAO.getAllBooking();
	}
}
