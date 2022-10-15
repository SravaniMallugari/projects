using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using dallibrary;
using helperlib;
using phase2EOP.Models;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace phase2EOP.Controllers
{
    public class employController : ApiController
    {
        // GET: employ
        // GET: api/Emp

        empmethods ms1 = null;
        public employController()
        {
            ms1 = new empmethods();
        }
        List<employee> mk = new List<employee>();
        [Route("GetAllEmpProfiles")]
        public IEnumerable<employee> Get()
        {
            List<EmpProfile> s1 = ms1.GetEmpProfilesall();
            foreach (var item in s1)
            {
                employee emp = new employee();
                emp.EmpCode = Convert.ToInt32(item.EmpCode);
                emp.EmpName = item.EmpName.ToString();
                emp.DOB = Convert.ToDateTime(item.DOB);
                emp.email = item.email.ToString();
                emp.deptcode = Convert.ToInt32(item.deptcode);
                mk.Add(emp);
            }
            return mk;
        }

        // GET: api/Emp/5
        [Route("Findprofiles/{id}")]
        public employee Get(int id)
        {
            employee emp = new employee();
            EmpProfile item = ms1.FindEmployee(id);
            emp.EmpCode = Convert.ToInt32(item.EmpCode);
            emp.EmpName = item.EmpName.ToString();
            emp.DOB = Convert.ToDateTime(item.DOB);
            emp.email = item.email.ToString();
            emp.deptcode = Convert.ToInt32(item.deptcode);
            return emp;

        }

        // POST: api/Emp
        [Route("AddEmpprofiles")]
        public HttpResponseMessage Post([FromBody] EmpProfile item)
        {
            EmpProfile emp = new EmpProfile
            {
                EmpCode = Convert.ToInt32(item.EmpCode),
                EmpName = item.EmpName.ToString(),
                DOB = Convert.ToDateTime(item.DOB),
                email = item.email.ToString(),
                deptcode = Convert.ToInt32(item.deptcode)
            };
            bool k = ms1.AddEmployee(emp);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }

        }

        // PUT: api/Emp/5
        [Route("Updateemp/{id}")]
        public HttpResponseMessage Put(int id, [FromBody] employee item)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = Convert.ToInt32(item.EmpCode);
            emp.EmpName = item.EmpName.ToString();
            emp.DOB = Convert.ToDateTime(item.DOB);
            emp.email = item.email.ToString();
            emp.deptcode = Convert.ToInt32(item.deptcode);
            bool k = ms1.UpdateEmployee(id, emp);
            if (k)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);

            }
        }

        // DELETE: api/Emp/5
        [Route("RemoveEmp/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            bool k = ms1.Removeemployee(id);
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
