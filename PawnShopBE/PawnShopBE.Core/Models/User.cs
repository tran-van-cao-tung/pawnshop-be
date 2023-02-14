﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Core.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public DateTime createTime { get; set; }
        public DateTime? updateTime { get; set; }
        //public byte status { get; set; }

        //relationship
        //public Guid RoleId { get; set; }
        //public Guid branchId { get; set; }
        //public Role role { get; set; }
        //public Branch branch { get; set; }
    }
}