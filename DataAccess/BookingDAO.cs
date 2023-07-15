using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class BookingDAO
	{
		public static List<Booking> getAllBooking()
		{
			var bookingList = new List<Booking>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					bookingList = context.Bookings.Include(s => s.Status)
												  .Include(v => v.Service)
												  .Include(p => p.Patiend).ToList();
				}
			}
			catch (Exception ex)
			{

			}
			return bookingList;
		}
	}
}
