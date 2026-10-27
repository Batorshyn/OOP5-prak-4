using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OOP5_prak_4
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        [JsonIgnore]
        public string PasswordHash { get; set; } = "";
    }
}
