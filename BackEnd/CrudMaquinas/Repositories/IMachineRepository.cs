using Microsoft.AspNetCore.Mvc;
using CrudMaquinas.Entities;

namespace CrudMaquinas.Repositories
{
    public interface IMachineRepository
    {
        public Task CreateMachine(Machine machine);
        public Task DeleteMachine(Machine machine);
        public Task UpdateMachine(Machine machine);
        public Task<IEnumerable<Machine>> GetAllMachines();
        public Task GetMachinesByStatus(string status);
    }
}
