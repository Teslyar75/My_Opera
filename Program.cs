/*Задание 1: Создайте класс «Пьеса», который должен хранить следующую информацию: 
 *  название пьесы;
 *  Ф.И.О. автора; 
 *  жанр;
 *  год.
 * Реализуйте в классе методы и свойства, необходимые для работы класса.
 * Добавьте в класс деструктор. Напишите код тестирования функциональности класса.
 * Напишите код для деструктора.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class My_Opera
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    
    public My_Opera(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void DisplayInformation()
    {

        Console.WriteLine($"Заголовок: {Title}");
        Console.WriteLine($"Авторr: {Author}");
        Console.WriteLine($"Жанр: {Genre}");
        Console.WriteLine($"Год написания произведения: {Year}");
    }

    ~My_Opera()
    {
        Console.WriteLine($"Пьеса под названием '{Title}' удалена.");
    }
}

class Program
{
    static void Main()
    {
        My_Opera play1 = new My_Opera("1984", "Джордж Оруэлл", "Антиутопия", 1949);
        play1.DisplayInformation();

        My_Opera play2 = new My_Opera("Скотный двор", "Джордж Оруэлл", "Антиутопия", 1945);
        play2.DisplayInformation();

        Console.ReadKey();
    }
}
