using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Repository;

namespace ProyectoWebApiAprendizaje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidasController : ControllerBase
    {
        ApplicationDbContext db;

        public PartidasController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Post(Partida partida)
        {

        }
        public void update(Partida partida)
        {

        }
        public Partida GetId(int id)
        {
            return new Partida();
        }
        public Partida GetAll()
        {
            return new Partida();
        }
    }
}