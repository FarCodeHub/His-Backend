﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
