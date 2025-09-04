using Microsoft.AspNetCore.Mvc;
using CrudMaquinas.Entities;
using System.Globalization;

namespace CrudMaquinas.Repositories
{
    public interface IMachineRepository
    {
        public Task CreateMachine(Machine machine);
        public Task UpdateMachine(Machine machine);
        public Task DeleteMachine(int id);
        public Task<IEnumerable<Machine>> GetAllMachines();
        public Task<Machine> GetMachineById(int id);
        public Task<IEnumerable<Machine>> GetMachinesByStatus(string status);
    }
}
