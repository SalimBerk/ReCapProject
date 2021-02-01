using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarServiceDal _carServiceDal;

		public CarManager(ICarServiceDal carServiceDal)
		{
			_carServiceDal = carServiceDal;
		}

		public List<Car> GetAll()
		{
			return _carServiceDal.GetAll();
			
			
		}
	}
}
