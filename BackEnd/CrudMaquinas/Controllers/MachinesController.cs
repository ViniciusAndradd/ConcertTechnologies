using CrudMaquinas.Repositories;
using Microsoft.AspNetCore.Mvc;
using CrudMaquinas.Entities;

namespace CrudMaquinas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : Controller
    {
        private readonly MachineRepository _machineRepository;
        public MachinesController(MachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Machine>>> GetAllMachines()
        {
            try
            {
                var machines = await _machineRepository.GetAllMachines();
                return Ok(machines);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao buscar as máquinas. Tente novamente mais tarde!");
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateMachine(string name, string location, string status)
        {
            var machine = new Machine
            {
                Name = name,
                Location = location,
                Status = status
            };
            try
            {
                await _machineRepository.CreateMachine(machine);
                return Ok("Máquina criada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao criar a máquina. Tente novamente mais tarde!");
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMachine(int id, string name, string location, string status)
        {
            var machine = new Machine
            {
                Id = id,
                Name = name,
                Location = location,
                Status = status
            };
            try
            {
                await _machineRepository.UpdateMachine(machine);
                return Ok("Máquina atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao atualizar a máquina. Tente novamente mais tarde!");
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMachine(int id)
        {
            try
            {
                await _machineRepository.DeleteMachine(id);
                return Ok("Máquina deletada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao deletar a máquina. Tente novamente mais tarde!");
            }

        }

        [HttpGet("ById")]
        public async Task<ActionResult<Machine>> GetMachineById(int id)
        {
            try
            {
                var machine = await _machineRepository.GetMachineById(id);
                if (machine == null)
                {
                    return NotFound("Máquina não encontrada!");
                }
                return Ok(machine);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao buscar a máquina. Tente novamente mais tarde!");
            }
        }

        [HttpGet("ByStatus")]
        public async Task<ActionResult<IEnumerable<Machine>>> GetMachinesByStatus(string status)
        {
            try
            {
                var machines = await _machineRepository.GetMachinesByStatus(status);
                return Ok(machines);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao buscar as máquinas. Tente novamente mais tarde!");
            }
        }
    }
}
