using dallibrary;
using helperlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

using RouteAttribute = System.Web.Http.RouteAttribute;

namespace phase2EOP.Controllers
{
    public class departmentController : ApiController
    {
        // GET: department
        deptmethods mode = null;
        public departmentController()
        {
            mode = new deptmethods();

        }
        List<department> ms = new List<department>();
        [Route("Getalldeps")]
        public IEnumerable<department> Get()
        {
            List<DeptMaster> rs = mode.getdeptMasters();
            foreach (var item in rs)
            {
                department m = new department();
                m.deptcode = item.deptcode;
                m.deptname = item.deptname;
                ms.Add(m);
            }
            return ms;
        }

        // GET: api/dept/5
        [Route("finddepts/{id}")]
        public department Get(int id)
        {
            DeptMaster r = mode.finddept(id);
            department m = new department();
            m.deptcode = r.deptcode;
            m.deptname = r.deptname;
            return m;
        }

        // POST: api/dept
        [Route("adddepts")]
        public HttpResponseMessage Post([FromBody] department value)
        {
            DeptMaster m = new DeptMaster();
            m.deptcode = Convert.ToInt32(value.deptcode);
            m.deptname = value.deptname;
            bool k = mode.adddeptmaster(m);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }


        }

        // PUT: api/dept/5
        [Route("updatedepts/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] department value)
        {
            DeptMaster m = new DeptMaster();
            m.deptcode = Convert.ToInt32(value.deptcode);
            m.deptname = value.deptname;
            bool k = mode.updatemaster(id, m);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }

        // DELETE: api/dept/5
        [Route("removedepts/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool k = mode.removemaster(id);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}