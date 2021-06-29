using RESTAPI.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI.Server.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
