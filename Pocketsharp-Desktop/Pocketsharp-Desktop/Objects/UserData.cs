using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pocketsharp_Desktop.Objects
{
    internal class UserData
    {
        public string? BaseUrl { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? JsonAuthRecord { get; set; }
        public string? JsonAuthResponse { get; set; }
    }
}