using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*//상속 1
    class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.!");
        }
    }*/
    /*//상속2
    class Player
    {
        public string name;
        public void Render()
        {
            Console.WriteLine("플레이어" + name);
        }
    }
    class Wizard : Player
    {
        public string job;
        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /* //상속 1
             Dog myDog = new Dog();
             myDog.Name = "바둑이"; //부모 클래스의 속성 사용
             myDog.Eat(); //부모 클래스의 메서드 호출 가능
             myDog.Bark();//자기 메서드 호출 가능*/
            /*//상속 2
            Player P = new Player();
            P.name = "홍길동";
            P.Render();
            Wizard w = new Wizard();
            w.job = "마법사";
            w.Render(); //홍길동안나옴
            w.name = "대마법사";
            w.Render();
            w.Render2();*/
        }
    }
}
