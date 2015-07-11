using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.Models
{
    public class User
    {
        [Required(ErrorMessage="请输入用户名！")]
        public string username { get; set; }
        [Required(ErrorMessage="请输入密码！")]
        public string passwd { get; set; }
        [Required(ErrorMessage="请输入邮箱！")]
        public string email { get; set; }
        public int confirm { get; set; }
        public string way { get; set; }
        public int Sync { get; set; }
        public DateTime Add_Date { get; set; }
        public DateTime? Upd_Date { get; set; }
    }
}