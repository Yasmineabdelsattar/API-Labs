using lab2_abi.DAL.Models;
using lab2_abi.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abi.DAL.Repos.DepartmentsRepo;

public interface IDepartmentsRepo: IGenericRepo<Department>
{
    List<Department> GetDepartmentsByName(string name);
}
