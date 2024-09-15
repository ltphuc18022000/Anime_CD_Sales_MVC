using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeCD.DataAccess.Data;
using AnimeCD.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AnimeCD.DataAccess.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationDbContext _db;
		internal DbSet<T> dbSet; // DbSet là một tập hợp các thực thể được theo dõi trong bộ nhớ, nó là một phần của Entity Framework Core

		public Repository(ApplicationDbContext db)
		{
			_db = db;
			this.dbSet = _db.Set<T>();
			//_db.Categories = dbSet;
		}

		public void Add(T entity)
		{
			dbSet.Add(entity); // Thêm một thực thể mới vào tập hợp

		}

		public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
		{
			IQueryable<T> query = dbSet; // Tạo một câu lệnh truy vấn
			query = query.Where(filter); // Lọc các thực thể dựa trên điều kiện
			return query.FirstOrDefault(); // Trả về phần tử đầu tiên của tập hợp hoặc một giá trị mặc định nếu tập hợp không chứa phần tử nào
		}

		public IEnumerable<T> GetAll()
		{
			IQueryable<T> query = dbSet;
			return query.ToList();
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entity)
		{
			dbSet.RemoveRange(entity);
		}
	}
}
