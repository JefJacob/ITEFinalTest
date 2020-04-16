using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITEFinalTest.Entities;
using ITEFinalTest.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITEFinalTest.WebAPI.Controllers
{
    [Route("api/iteFinaltest/coach/v1")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly CoachLogic _logic;

        public CoachController()
        {
            _logic = new CoachLogic();
        }
        [HttpGet]
        public ActionResult<CoachEntity> Get(int id)
        {
            CoachEntity coach = _logic.Read(id);
            if (coach != null)
            {
                return Ok(coach);
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult Post([FromBody] CoachEntity coach)
        {
            try
            {
                _logic.Create(coach);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CoachEntity coach)
        {
            try
            {
                _logic.Update(coach);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _logic.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}