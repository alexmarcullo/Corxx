using Corxx.Infra;
using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corxx.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async new Task<IActionResult> Response(object result, ICollection<Notification> notifications)
        {
            if(!notifications.Any())
            {
                try
                {
                    await _unitOfWork.CommitAsync();

                    return Ok(new
                    {
                        success = true,
                        data = result,
                        errors = new string[0]
                    });
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();

                    return BadRequest(new
                    {
                        success = false,
                        data = ex.Message,
                        errors = new string[0]
                    });
                }
            }
            else
            {
                _unitOfWork.Rollback();

                return BadRequest(new
                {
                    success = false,
                    data = "",
                    errors = notifications
                });
            }
        }
    }
}
