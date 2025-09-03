using CrudMaquinas.Repositories;
using Microsoft.AspNetCore.Mvc;
using CrudMaquinas.Entities;

namespace CrudMaquinas.Controllers
{
    public class MachinesController : Controller
    {
        private readonly MachineRepository _machineRepository;
        public MachinesController(MachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Machine>>> GetAllMAchines()
        {
            try
            {
                var machines = await _machineRepository.GetAllMachines();
                return Ok(machines);
            }
            catch(Exception ex)
            {
                return BadRequest("Ocorreu um erro ao buscar as máquinas. Tente novamente mais tarde!");
            }
        }
        
    }
}
