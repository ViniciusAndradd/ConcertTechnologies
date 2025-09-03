using CrudMaquinas.Context;
using CrudMaquinas.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudMaquinas.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        private readonly AppDbContext _context;
        public MachineRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task CreateMachine(Machine machine)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMachine(Machine machine)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Machine>> GetAllMachines()
        {
            return await _context.Machines
                        .Select(machine => new Machine
                        {
                            Id = machine.Id,
                            Name = machine.Name,
                            Location = machine.Location,
                            Status = machine.Status,
                        }).ToListAsync();
        }

        public Task GetMachinesByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMachine(Machine machine)
        {
            throw new NotImplementedException();
        }
    }
}
