﻿using EFCoreWithAsp.netCore.Models;
using EFCoreWithAsp.netCore.ViewModels;

namespace EFCoreWithAsp.netCore.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);
        Task<List<EmployeeViewModel>> GetAllAsync();
        Task AddAsync(EmployeeViewModel employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int Id);

        Task<List<Department>> GetAllDepartments();
    }
   
}
