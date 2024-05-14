using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Базовий клас для фільмів
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
    public string City { get; set; }
    public string DepartmentNumber { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber { get; set; }
    public string FullName { get; set; }

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
        Console.WriteLine($"Спосіб купівлі: Online");
        Console.WriteLine($"Тип картки: {CardType}");
        Console.WriteLine($"Адреса email: {EmailAddress}");
        Console.WriteLine($"Ціна: {Price}");
    }
}



class Program
{
    // Створення колекції LinkedList для зберігання фільмів
    public static LinkedList<Film> films = new LinkedList<Film>();

    // Метод для виведення інформації про всі фільми у консоль
    public static void ToConsole()
    {
        // Виведення інформації про купівлю для кожного фільму
        foreach (var film in films)
        {
            film.PrintPurchaseInfo();
            Console.WriteLine();
        }
    }
    // Метод для купівлі фільму Blu-Ray
    public static void BuyBluRayFilm()
    {
        Console.WriteLine("Введіть номер фільму, який ви хочете купити: ");
        int filmNumber = Convert.ToInt32(Console.ReadLine());
        if (filmNumber > 0 && filmNumber <= films.Count)
        {
            var filmToBuy = films.ElementAt(filmNumber - 1);
            if (filmToBuy is BluRayFilm)
            {
                Console.WriteLine("Оберіть спосіб доставки:");
                Console.WriteLine("1. Нова Пошта");
                Console.WriteLine("2. Укр Пошта");
                Console.Write("Ваш вибір: ");
                string deliveryChoice = Console.ReadLine();

                string deliveryMethod;
                string city;
                string departmentNumber = "";
                string postalCode = "";
                string phoneNumber;
                string fullName;

                switch (deliveryChoice)
                {
                    case "1":
                        deliveryMethod = "Нова Пошта";
                        Console.WriteLine("Введіть ваше місто: ");
                        city = Console.ReadLine();
                        while (!city.All(char.IsLetter))
                        {
                            Console.WriteLine("Місто може містити тільки букви. Будь ласка, введіть правильне місто:");
                            city = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть номер відділення : ");
                        departmentNumber = Console.ReadLine();
                        while (departmentNumber.Length > 3 || !departmentNumber.All(char.IsDigit))
                        {
                            Console.WriteLine("Номер відділення має містити до 3 цифр. Будь ласка, введіть правильний номер відділення:");
                            departmentNumber = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть ваш номер телефону (: ");
                        phoneNumber = Console.ReadLine();
                        while (phoneNumber.Length != 11 || !phoneNumber.All(char.IsDigit))
                        {
                            Console.WriteLine("Номер телефону має містити 11 цифр. Будь ласка, введіть правильний номер телефону:");
                            phoneNumber = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть ваше ПІБ: ");
                        fullName = Console.ReadLine();
                        break;
                    case "2":
                        deliveryMethod = "Укр Пошта";
                        Console.WriteLine("Введіть ваше місто: ");
                        city = Console.ReadLine();
                        while (!city.All(char.IsLetter))
                        {
                            Console.WriteLine("Місто може містити тільки букви. Будь ласка, введіть правильне місто:");
                            city = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть поштовий індекс (5 цифр): ");
                        postalCode = Console.ReadLine();
                        while (postalCode.Length != 5 || !postalCode.All(char.IsDigit))
                        {
                            Console.WriteLine("Поштовий індекс має містити 5 цифр. Будь ласка, введіть правильний поштовий індекс:");
                            postalCode = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть ваш номер телефону (11 цифр): ");
                        phoneNumber = Console.ReadLine();
                        while (phoneNumber.Length != 11 || !phoneNumber.All(char.IsDigit))
                        {
                            Console.WriteLine("Номер телефону має містити 11 цифр. Будь ласка, введіть правильний номер телефону:");
                            phoneNumber = Console.ReadLine();
                        }
                        Console.WriteLine("Введіть ваше ПІБ: ");
                        fullName = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір способу доставки.");
                        return;
                }

                Console.WriteLine("Оберіть спосіб оплати:");
                Console.WriteLine("1. Visa");
                Console.WriteLine("2. Mastercard");
                Console.WriteLine("3. При отриманні");
                Console.Write("Ваш вибір: ");
                string paymentChoice = Console.ReadLine();

                string paymentMethod;

                switch (paymentChoice)
                {
                    case "1":
                        paymentMethod = "Visa";
                        break;
                    case "2":
                        paymentMethod = "Mastercard";
                        break;
                    case "3":
                        paymentMethod = "При отриманні";
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір способу оплати.");
                        return;
                }

                ((BluRayFilm)filmToBuy).DeliveryMethod = deliveryMethod;
                ((BluRayFilm)filmToBuy).City = city;
                ((BluRayFilm)filmToBuy).DepartmentNumber = departmentNumber;
                ((BluRayFilm)filmToBuy).PostalCode = postalCode;
                ((BluRayFilm)filmToBuy).PhoneNumber = phoneNumber;
                ((BluRayFilm)filmToBuy).FullName = fullName;
                ((BluRayFilm)filmToBuy).PaymentMethod = paymentMethod;

                Console.WriteLine("Дякуємо за покупку, очікуйте на дзвінок оператора");
            }
            else
            {
                Console.WriteLine("Цей фільм не доступний для покупки Blu-Ray.");
            }
        }
        else
        {
            Console.WriteLine("Неправильний номер фільму.");
        }
    }





    // Метод для купівлі фільму онлайн
    public static void BuyOnlineFilm()
    {
        Console.WriteLine("Введіть номер фільму, який ви хочете купити: ");
        int filmNumber = Convert.ToInt32(Console.ReadLine());
        if (filmNumber > 0 && filmNumber <= films.Count)
        {
            var filmToBuy = films.ElementAt(filmNumber - 1);
            if (filmToBuy is BluRayFilm)
            {
                Console.WriteLine("Введіть електронну пошту для отримання фільму: ");
                string deliveryMethod = Console.ReadLine();
                Console.WriteLine("Виберіть спосіб оплати: ");
                Console.WriteLine("1. Visa");
                Console.WriteLine("2. Mastercard");
                
                string paymentChoice = Console.ReadLine();

                string paymentMethod;

                switch (paymentChoice)
                {
                    case "1":
                        paymentMethod = "Visa";
                        break;
                    case "2":
                        paymentMethod = "Mastercard";
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір способу оплати.");
                        return;
                }


                ((BluRayFilm)filmToBuy).DeliveryMethod = deliveryMethod;
                ((BluRayFilm)filmToBuy).PaymentMethod = paymentMethod;
                Console.WriteLine(" Дякуємо , фільм вже відправлено");
            }
            else
            {
                Console.WriteLine("Цей фільм не доступний для покупки Blu-Ray.");
            }
        }
        else
        {
            Console.WriteLine("Неправильний номер фільму.");
        }
    }


    // Метод для додавання нового фільму
    public static void AddFilm()
    {
        Console.WriteLine("Введіть тип фільму (1 - Blu-Ray, 2 - Online): ");
        int filmType = Convert.ToInt32(Console.ReadLine());
        if (filmType == 1)
        {
            BluRayFilm film = new BluRayFilm();
            Console.WriteLine("Введіть назву фільму: ");
            film.Title = Console.ReadLine();
            Console.WriteLine("Введіть режисера: ");
            film.Director = Console.ReadLine();
            Console.WriteLine("Введіть рік випуску: ");
            film.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть головного актора: ");
            film.LeadActor = Console.ReadLine();
            Console.WriteLine("Введіть ціну: ");
            film.Price = Convert.ToDouble(Console.ReadLine());
            films.AddLast(film);
            Console.WriteLine("Фільм додано!");
        }
        else if (filmType == 2)
        {
            OnlineFilm film = new OnlineFilm();
            Console.WriteLine("Введіть назву фільму: ");
            film.Title = Console.ReadLine();
            Console.WriteLine("Введіть режисера: ");
            film.Director = Console.ReadLine();
            Console.WriteLine("Введіть рік випуску: ");
            film.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть головного актора: ");
            film.LeadActor = Console.ReadLine();
            Console.WriteLine("Введіть ціну: ");
            film.Price = Convert.ToDouble(Console.ReadLine());
            films.AddLast(film);
            Console.WriteLine("Фільм додано!");
        }
        else
        {
            Console.WriteLine("Неправильний тип фільму.");
        }
    }

    // Метод для видалення фільму за номером
    public static void RemoveFilm()
    {
        Console.WriteLine("Введіть номер фільму, який ви хочете видалити: ");
        int filmNumber = Convert.ToInt32(Console.ReadLine());
        if (filmNumber > 0 && filmNumber <= films.Count)
        {
            films.Remove(films.ElementAt(filmNumber - 1));
            Console.WriteLine("Фільм видалено!");
        }
        else
        {
            Console.WriteLine("Неправильний номер фільму.");
        }
    }

    // Метод для редагування фільму за номером
    public static void EditFilm()
    {
        Console.WriteLine("Введіть номер фільму, який ви хочете редагувати: ");
        int filmNumber = Convert.ToInt32(Console.ReadLine());
        if (filmNumber > 0 && filmNumber <= films.Count)
        {
            var filmToEdit = films.ElementAt(filmNumber - 1);
            if (filmToEdit is BluRayFilm)
            {
                BluRayFilm bluRayFilm = (BluRayFilm)filmToEdit;
                Console.WriteLine("Введіть нову назву фільму: ");
                bluRayFilm.Title = Console.ReadLine();
                Console.WriteLine("Введіть нового режисера: ");
                bluRayFilm.Director = Console.ReadLine();
                Console.WriteLine("Введіть новий рік випуску: ");
                bluRayFilm.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть нового головного актора: ");
                bluRayFilm.LeadActor = Console.ReadLine();
                Console.WriteLine("Введіть нову ціну: ");
                bluRayFilm.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Фільм відредаговано!");
            }
            else if (filmToEdit is OnlineFilm)
            {
                OnlineFilm onlineFilm = (OnlineFilm)filmToEdit;
                Console.WriteLine("Введіть нову назву фільму: ");
                onlineFilm.Title = Console.ReadLine();
                Console.WriteLine("Введіть нового режисера: ");
                onlineFilm.Director = Console.ReadLine();
                Console.WriteLine("Введіть новий рік випуску: ");
                onlineFilm.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть нового головного актора: ");
                onlineFilm.LeadActor = Console.ReadLine();
                Console.WriteLine("Введіть нову ціну: ");
                onlineFilm.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Фільм відредаговано!");
            }
        }
        else
        {
            Console.WriteLine("Неправильний номер фільму.");
        }
    }



    // Метод для відображення головного меню
    public static void MainMenu()
    {
        Console.WriteLine("1. Показати список фільмів");
        Console.WriteLine("2. Видалити фільм");
        Console.WriteLine("3. Додати фільм");
        Console.WriteLine("4. Редагувати фільм");
        Console.WriteLine("5. Пепреглянути замовлення");
        Console.WriteLine("6. Вийти");
        Console.Write("Ваш вибір: ");
    }

    // Метод для перевірки, чи користувач є адміністратором
    public static bool IsAdmin(string username, string password)
    {
        // Тут можна зробити перевірку аутентифікації, наприклад, шляхом перевірки
        // імені користувача та пароля в базі даних чи в іншому місці збереження
        // Для прикладу просто введемо жорстко закодовані дані
        return username == "admin" && password == "admin";
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        static void Main(string[] args)
        {
            // Зчитування даних з файлу JSON та десеріалізація у колекцію LinkedList
            // Код читання даних з файлу із фільмами

            bool exit = false;
            bool isAdminMode = false; // Змінна для визначення, чи ввімкнено режим адміністратора

            while (!exit)
            {
                if (!isAdminMode)
                {
                    // Режим користувача
                    // Код для режиму користувача, включаючи виведення меню користувача, купівлю фільмів тощо
                }
                else
                {
                    // Режим адміністратора
                    Console.WriteLine("Ви зараз в режимі адміністратора.");
                    Console.WriteLine("1. Переглянути список фільмів");
                    Console.WriteLine("2. Переглянути список замовлень");
                    Console.WriteLine("3. Вийти з режиму адміністратора");
                    Console.Write("Ваш вибір: ");
                    string adminChoice = Console.ReadLine();

                    switch (adminChoice)
                    {
                        case "1":
                            ToConsole();
                            break;
                        case "2":
                            ViewOrders();
                            break;
                        case "3":
                            AddFilm();
                            break;
                        case "4":
                            isAdminMode = false;
                            Console.WriteLine("Ви вийшли з режиму адміністратора.");
                            break;
                        default:
                            Console.WriteLine("Неправильний ввід. Спробуйте ще раз.");
                            break;
                    }
                }

                Console.WriteLine("Чи бажаєте вийти з програми? (Так/Ні)");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "так")
                    exit = true;
            }
        }

        // Зчитування даних з файлу JSON та десеріалізація у колекцію LinkedList
        string jsonFilePath = "films.json";
        if (File.Exists(jsonFilePath))
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray array = JArray.Parse(jsonData);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i].ToString().Contains("Blu-Ray"))
                {
                    BluRayFilm tmp = new BluRayFilm();
                    tmp = JsonConvert.DeserializeObject<BluRayFilm>(array[i].ToString());
                    films.AddLast(tmp);
                }
                else
                {
                    OnlineFilm tmp = new OnlineFilm();
                    tmp = JsonConvert.DeserializeObject<OnlineFilm>(array[i].ToString());
                    films.AddLast(tmp);
                }
            }
        }
        else
        {
            Console.WriteLine($"Файл {jsonFilePath} не знайдено.");
            return;
        }

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Ласкаво просимо!");
            Console.WriteLine("Будь ласка, увійдіть для продовження.");
            Console.Write("Користувач: ");
            string username = Console.ReadLine();
            Console.Write("Пароль: ");
            string password = Console.ReadLine();

            if (IsAdmin(username, password))
            {
                Console.WriteLine("Ви увійшли як адміністратор.");
                bool adminExit = false;
                while (!adminExit)
                {
                    MainMenu();
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            ToConsole();
                            break;
                        case "2":
                            RemoveFilm();
                            break;
                        case "3":
                            AddFilm();
                            break;
                        case "4":
                            EditFilm();
                            break;
                        case "5":
                            ViewOrders(); // Переглянути замовлення для адміністратора
                            break;
                        case "6":
                            adminExit = true;
                            break;
                        default:
                            Console.WriteLine("Неправильний ввід. Спробуйте ще раз.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ви увійшли як користувач.");
                bool userExit = false;
                while (!userExit)
                {
                    Console.WriteLine("1. Показати список фільмів");
                    Console.WriteLine("2. Купити фільм Blu-Ray");
                    Console.WriteLine("3. Купити фільм онлайн");
                    Console.WriteLine("4. Переглянути мої замовлення"); // Додано опцію для перегляду замовлень
                    Console.WriteLine("5. Вийти");
                    Console.Write("Ваш вибір: ");
                    string userChoice = Console.ReadLine();
                    switch (userChoice)
                    {
                        case "1":
                            ToConsole();
                            break;
                        case "2":
                            BuyBluRayFilm();
                            break;
                        case "3":
                            BuyOnlineFilm();
                            break;
                        case "4":
                            ViewOrders(); // Переглянути замовлення для користувача
                            break;
                        case "5":
                            userExit = true;
                            break;
                        default:
                            Console.WriteLine("Неправильний ввід. Спробуйте ще раз.");
                            break;
                    }
                }
            }

            Console.WriteLine("Чи бажаєте вийти з програми? (Так/Ні)");
            string exitChoice = Console.ReadLine().ToLower();
            if (exitChoice == "так")
                exit = true;
        }
    }

    // Метод для перегляду замовлень
    static void ViewOrders()
    {
        Console.WriteLine("Список замовлень:");

        // Переглянути кожен елемент колекції films і вивести інформацію про кожне замовлення
        foreach (var film in films)
        {
            // Перевірити, чи це замовлення Blu-Ray
            if (film is BluRayFilm)
            {
                var bluRayFilm = (BluRayFilm)film;
                Console.WriteLine($"Фільм Blu-Ray: {bluRayFilm.Title}");
                Console.WriteLine($"Спосіб доставки: {bluRayFilm.DeliveryMethod}");
                Console.WriteLine($"Спосіб оплати: {bluRayFilm.PaymentMethod}");
                Console.WriteLine($"Місто: {bluRayFilm.City}");
                Console.WriteLine($"Номер відділення: {bluRayFilm.DepartmentNumber}");
                Console.WriteLine($"Номер телефону: {bluRayFilm.PhoneNumber}");
                Console.WriteLine($"ПІБ: {bluRayFilm.FullName}");
                Console.WriteLine();
            }
            // Перевірити, чи це замовлення онлайн
            else if (film is OnlineFilm)
            {
                var onlineFilm = (OnlineFilm)film;
                Console.WriteLine($"Фільм онлайн: {onlineFilm.Title}");
                Console.WriteLine($"Тип картки: {onlineFilm.CardType}");
                Console.WriteLine($"Адреса email: {onlineFilm.EmailAddress}");
                Console.WriteLine();
            }
        }
    }
    // Додайте змінну, щоб визначити, чи зараз в режимі адміністратора
    static bool isAdminMode = false;

    // Основний метод програми
    


}