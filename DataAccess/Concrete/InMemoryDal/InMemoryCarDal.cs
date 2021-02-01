using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
	public class InMemoryCarDal : ICarServiceDal
		
	{
		List<Car> _cars;
		public InMemoryCarDal()
		{
			_cars = new List<Car>
			{
				new Car{Id=1,BrandId=234456,DailyPrice=300.000,ColorId=111,ModelYear=2019,Description="Volkswagen Passat "},
				new Car{Id=2,BrandId=235356,DailyPrice=150.000,ColorId=121,ModelYear=2017,Description="Renault Clio"},
				new Car{Id=3,BrandId=255356,DailyPrice=200.000,ColorId=131,ModelYear=2017,Description="BMW i8"},
				new Car{Id=4,BrandId=245356,DailyPrice=230.000,ColorId=142,ModelYear=2017,Description="Mercedes A180"},
				new Car{Id=5,BrandId=238356,DailyPrice=170.000,ColorId=142,ModelYear=2017,Description="Opel Astra"}
			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
			
		}

		public void Delete(Car car)
		{
			Car CarToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
			_cars.Remove(CarToDelete);
			
		
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetByCategoryId(int categoryId)
		{
			return _cars.Where(p => p.Id == categoryId).ToList();
		}

		public void Update(Car car)
		{
			Car CarToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
			CarToUpdate.DailyPrice = car.DailyPrice;
			CarToUpdate.BrandId = car.BrandId;
			CarToUpdate.ColorId = car.ColorId;
			CarToUpdate.ModelYear = car.ModelYear;
			CarToUpdate.Description = car.Description;
		}
	}
}
