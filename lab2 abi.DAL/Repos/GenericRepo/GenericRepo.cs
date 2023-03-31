using lab2_abi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Repos.GenericRepo;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly TicketContext _context;

    public GenericRepo(TicketContext context)
    {
        _context = context;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);

    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
