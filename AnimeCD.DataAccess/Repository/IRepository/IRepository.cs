using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnimeCD.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		//T - Category
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T,bool>>filter); // filter: cần truyền vào một điều kiện để lấy dữ liệu

		void Add(T entity); // phương thức ADD truyền vào một đối tượng cần thêm vào Database
		void Remove(T entity); 
		void RemoveRange(IEnumerable<T> entity); // truyền nhiều đối tượng cần xóa trong Database

	}
}
