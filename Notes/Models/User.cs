using System;
using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace MyMvc.Models
{
    public class User
    {
        //[Required(ErrorMessage="请输入用户名！")]
        [Required]
        [Display(Name="用户名")]
        public string username { get; set; }
        [Required]
        [Display(Name="密码")]
        public string passwd { get; set; }
        [Required]
        [Display(Name="邮箱")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        public string email { get; set; }
        public DateTime Add_Date { get; set; }
        public DateTime? Upd_Date { get; set; }
    }
}