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
        public async Task CreateMachine(Machine machine)
        {
            _context.Machines.Add(machine);
            _context.SaveChanges();
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

        public async Task<Machine> GetMachineById(int id)
        {
            return await _context.Machines
                                 .FirstOrDefaultAsync(machine => machine.Id == id);
        }

        public async Task<IEnumerable<Machine>> GetMachinesByStatus(string status)
        {
            return await _context.Machines
                        .Where(machine => machine.Status == status)
                        .Select(machine => new Machine
                        {
                            Id = machine.Id,
                            Name = machine.Name,
                            Location = machine.Location,
                            Status = machine.Status,
                        }).ToListAsync();
        }

        public async Task UpdateMachine(Machine machine)
        {
            _context.Machines.Update(machine);
            _context.SaveChanges();
        }

        public async Task DeleteMachine(int id)
        {
            var machine = await GetMachineById(id);
            if (machine != null)
            {
                _context.Machines.Remove(machine);
                _context.SaveChanges();
            }
        }
    }
}
