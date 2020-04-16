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
    [Route("api/iteFinaltest/athlete/v1")]
    [ApiController]
    public class AthleteController : ControllerBase
    {
        private readonly AthleteLogic _logic;

        public AthleteController()
        {
            _logic = new AthleteLogic();
        }
        [HttpGet]
        public ActionResult<AthleteEntity> Get(int id)
        {
            AthleteEntity athlete = _logic.Read(id);
            if (athlete != null)
            {
                return Ok(athlete);
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult Post([FromBody] AthleteEntity athlete)
        {
            try
            {
                _logic.Create(athlete);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] AthleteEntity athlete)
        {
            try
            {
                _logic.Update(athlete);
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