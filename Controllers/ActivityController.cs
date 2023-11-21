using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoNET.DTOs;
using TrabajoNET.Infrastructure;
using TrabajoNET.Services;

namespace TrabajoNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAll")]

        public async Task<IActionResult> GetAll()
        {
            return ResponseFactory.CreateSuccessResponse(200, await _unitOfWork.ActivityRepository.GetAll());
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(ActivityRegisterDTO activityRegisterDTO)
        {
            var result = await _unitOfWork.ActivityRepository.InsertActivity(activityRegisterDTO);
            if (result)
            {

                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(201, "La Actividad se registro correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(int id, ActivityRegisterDTO activityRegisterDTO)
        {
            var result = await _unitOfWork.ActivityRepository.UpdateActivity(activityRegisterDTO, id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "La Actividad se actualizo correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.ActivityRepository.DeleteActivity(id);
            if (result)
            {
                await _unitOfWork.Complete();
                return ResponseFactory.CreateSuccessResponse(200, "La Actividad se Elimino correctamente");
            }
            return ResponseFactory.CreateErrorResponse(400, "Error Contactar a sistema");

        }

    }
}