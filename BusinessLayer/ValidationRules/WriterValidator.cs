using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soydı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen bir Mail adresi giriniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterName).Length(2,30).WithMessage("Kullanıcı adı 2 ve 30 arasında olmalı");
        }
        public bool IsValidPassword(string pass)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(pass);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
