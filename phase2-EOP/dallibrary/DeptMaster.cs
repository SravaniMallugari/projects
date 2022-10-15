using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dallibrary
{
    public class DeptMaster
    {
        [Key]
        [Required]
        public int deptcode { get; set; }
        [MaxLength(30, ErrorMessage = "Cannot be more than thirty words")]
        public string deptname { get; set; }


        public virtual ICollection<EmpProfile> GetEmpProfiles
        {
            get;
            set;
        }
    }
    public class EmpProfile
    {
        [Key]
        [Required]
        public int EmpCode
        {
            get;
            set;
        }
        [MaxLength(30, ErrorMessage = "Can't be more than 30")]
        public string EmpName
        {
            get;
            set;
        }

        public DateTime DOB
        {
            get;
            set;
        }
        [EmailAddress]
        public string email
        {
            get;
            set;
        }

        public int deptcode
        {
            get;
            set;
        }

        [ForeignKey("deptcode")]
        public virtual DeptMaster DeptMaster
        {
            get;
            set;
        }
    }
    public class employ : DbContext
    {
        public employ() : base("employ")
        {
            Database.SetInitializer<employ>(new DropCreateDatabaseIfModelChanges<employ>());
        }
        public virtual DbSet<DeptMaster> DeptMasters { get; set; }
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; }

    }
}