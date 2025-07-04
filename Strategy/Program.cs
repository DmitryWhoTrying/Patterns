﻿namespace Strategy
{
    //Идея стратегии:
    //Инкапсулировать каждый алгоритм из некоторого семейства, чтобы сделать их
    //взаимозаменяемыми

    //Достоинства:
    //Гибкость и масштабираемость
    //Open-Closed Principle

    //Недостатки
    //* Увеличение числа классов
    //* Клиентский код должен знать о стратегиях
    //* Избыточность кода
    //* 
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(1000, 100);
            game.makeDecision();
        }
    }
}
