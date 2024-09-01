using System;

namespace PaymentConsole
{
    /// <summary>
    /// Модель платежного терминала
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            // Параметры программы
            var limit = 100000; // Допустимый лимит, рублей
            var serviceFee = 9; // Размер комиссии, %

            Console.WriteLine("Выберите вид платежа: ");
            var PaymentType = Console.ReadLine();

            switch (PaymentType)
            {
                case "Кредит":
                    serviceFee = 5;
                    break;
                case "Ипотека":
                    serviceFee = 0;
                    break;
                case "Техосмотр":
                    serviceFee = 10;
                    break;
                case "Страховой взнос":
                    serviceFee = 3;
                    break;
                default:
                    serviceFee = 10;
                    break;
            }
            Console.WriteLine("Взимается комиссия {0}%", serviceFee);
            Console.Write("Введите сумму для пополнения счёта: ");
            var sumString = Console.ReadLine();

            /*
                1. Преобразуем строку в число
                2. Если введенная строка является числом и оно больше нуля, то
                2.1. если лимит превышен, выдаем соответствующее сообщение
                2.2. иначе рассчитываем комиссию и сообщаем об успешном платеже
            */

            double sum;
            var success = double.TryParse(sumString, out sum);

            bool result = success && sum > 0;


            if (result)
            {
                if (sum < limit)
                {
                    var feeValue = sum * serviceFee / 100;
                    Console.WriteLine("Платеж проведен успешно.");
                    Console.WriteLine("Комиссия составила {0} р.", feeValue);

                    Console.WriteLine("Введите промокод: ");
                    var PromoCode = Console.ReadLine();

                    switch (PromoCode)
                    {
                        case PromoCode == "abcde" || sum < 10000:
                         Сonsole.writeline("вам начислен бонус");
                    }

                    //if (sum > 1000 || promocode == "abcde") ;
                    //{
                    //    console.writeline("вам начислен бонус");
                    //}
                }
                else
                {
                    Console.WriteLine("Введенная сумма превышает допустимый лимит ({0} р.)", limit);
                }

                Console.ReadKey();
            }

            if (!success)
            {
                Console.WriteLine("Вы ввели некорректную сумму");
                Console.ReadKey();

            }
        }
    }
}
