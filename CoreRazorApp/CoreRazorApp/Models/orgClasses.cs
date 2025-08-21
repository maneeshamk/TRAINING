using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;

namespace CoreRazorApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OrgLocation
    {
        [Key,Column(Order =1)]
        public int OrgId { get; set; }


        [Key, Column(Order = 2)]
        public string Location { get; set; }

    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("org")]
        public int OrgId { get; set; }
        public Organization org { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("dept")]
        public int DeptId { get; set; }
        public Department dept { get; set; }
    }
}

