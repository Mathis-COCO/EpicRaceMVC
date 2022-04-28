namespace Models
{
    using System;
    using System.Collections.Generic;
   
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
    }
}
