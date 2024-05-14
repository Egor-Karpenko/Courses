using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLab
{
    public class Film
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string LeadActor { get; set; }
        public string Format { get; set; }
        public double Price { get; set; }

        // Віртуальний метод для виведення інформації про купівлю
        public virtual void PrintPurchaseInfo()
        {
            Console.WriteLine($"Спосіб купівлі: Не вказано");
        }
    }

    // Похідний клас для покупки Blu-Ray
    public class BluRayFilm : Film
    {
        public string DeliveryMethod { get; set; }
        public string PaymentMethod { get; set; }

        // Реалізація віртуального методу для виведення інформації про купівлю Blu-Ray
        public override void PrintPurchaseInfo()
        {
            Console.WriteLine($"Код: {Code}");
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Режисер: {Director}");
            Console.WriteLine($"Рік: {Year}");
            Console.WriteLine($"Головний актор: {LeadActor}");
            Console.WriteLine($"Спосіб купівлі: Blu-Ray");
            Console.WriteLine($"Спосіб доставки: {DeliveryMethod}");
            Console.WriteLine($"Спосіб оплати: {PaymentMethod}");
            Console.WriteLine($"Ціна: {Price}");

        }
    }

    // Похідний клас для онлайн-продажу
    public class OnlineFilm : Film
    {
        public string CardType { get; set; }
        public string EmailAddress { get; set; }

        // Реалізація віртуального методу для виведення інформації про онлайн-продаж
        public override void PrintPurchaseInfo()
        {
            Console.WriteLine($"Код: {Code}");
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Режисер: {Director}");
            Console.WriteLine($"Рік: {Year}");
            Console.WriteLine($"Головний актор: {LeadActor}");
            Console.WriteLine($"Спосіб купівлі: Онлайн");
            Console.WriteLine($"Тип картки: {CardType}");
            Console.WriteLine($"Адреса email: {EmailAddress}");
            Console.WriteLine($"Ціна: {Price}");
        }
    }
}
