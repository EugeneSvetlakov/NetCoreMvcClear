using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetCoreMvcClear.Data.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcClear.Data.Models
{
    public class Order : BaseEntity
    {
        [Display(Name = "Имя")]
        [StringLength(25, MinimumLength = 5)]
        [Required(ErrorMessage = "Длина имени 5-25 символов")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(25, MinimumLength = 5)]
        [Required(ErrorMessage = "Длина фамилии 5-25 символов")]
        public string Surname { get; set; }

        [Display(Name = "Почтовый адрес")]
        [StringLength(250, MinimumLength = 15)]
        [Required(ErrorMessage = "Длина почтового адреса 15-250 символов")]
        public string Addr { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, MinimumLength = 10)]
        [Required(ErrorMessage = "Длина номера телефона 10-15 знаков")]
        public string Phone { get; set; }

        [Display(Name = "E-mail адрес")]
        [DataType(DataType.EmailAddress)]
        [StringLength(60, MinimumLength = 6)]
        [Required(ErrorMessage = "Длина e-mail адреса 6-60 символов")]
        public string EmailAddr { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
