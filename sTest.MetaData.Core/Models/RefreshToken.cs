﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("RefreshTokens", Schema = "app_security")]
    public class RefreshToken
    {
        [Key] public string Token { get; set; }

        public string JwtId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool Used { get; set; }

        public bool Invalidated { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))] public ApplicationUser User { get; set; }
    }
}
