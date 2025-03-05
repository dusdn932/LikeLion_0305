using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    /*//상속3
    //메서드 오버라이딩(Overriding)
    //부모클래스의 메서드를 자식 클래스에서 재정의(override)하여 다른 동작을 수행할수있음
    class Animal
    {
        public string Name { get; set; }
        //가상(virtual)메서드 : 자식 클래스에서 재정의 가능
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        //부모 클래스의 메서드를 오버라이딩(재정의)
        public override void Speak()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }*/
    /*//상속4
    //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환 가능(컴파일러가 자동변환)
    //안전 : 데이터 손실 없이 변환 가능
    //다운 캐스팅(Downcasting)
    //명시적변환이 필요(타입)
    //불완전함 -> 실행중 InvalidcastException  발생가능
    //as is 키워드로 안전하게 변환가능
    public class Animal //부모클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }*/
    /*//상속5
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }*/
    /*//상속6
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모클래스의 메시지");
        }
    }
    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식클래스의 메시지");
            base.ShowMessage();//부모함수 실행
        }
    }*/
    /*//상속7
    class Player
    {
        protected string Name; //protected 부모랑 자식 상속관계에서만 사용하고싶을때 사용
        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("생성자입니다.");
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
    class Wizard : Player
    {
        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("자식 생성자입니다.");
        }

    }*/

    class Program
    {
        static void Main(string[] args)
        {
            /*//상속3
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak(); //부모클래스의 기본 메서드 시행

            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak();*/
            /*//상속4
            //업캐스팅
            Dog myDog = new Dog(); //자식클래스 객체 생성
            Animal myAnimal = myDog; //업캐스팅(Dog->animal)

            myAnimal.Speak(); //사용가능
            //myAnimal.Speak() 오류 업캐스팅후 자식 클래스의 메서드 접근 불가

            Animal myAnimal = new Dog();//업캐스팅 상태
            Dog myDog = (Dog)myAnimal;//다운캐스팅(명시적 변환)
            myDog.Bark(); //실행 
            Animal myAnimal2 = new Animal();
            //부모타입의 메모리를 다운캐스팅을 해야되는데 자식아래 자식을 해서 망가진다
            Dog myDog = (Dog)myAnimal2;

            Animal myAnimal = new Dog();//업캐스팅 상태
            //Dog myDog = (Dog)myAnimal;
            //is, as
            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark();
            }
            Dog myDog = myAnimal as Dog;
            if (myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }*/
            /*//상속5
            Animal myAnimal = new Dog();//업캐스팅
            myAnimal.Speak();//멍멍! 오버라이드된 메서드 실행
            Dog d = (Dog)myAnimal;
            d.WagTail();
            Animal myAni = new Animal();
            myAni.Speak();*/
            /*//상속6
            Child child = new Child();
            child.ShowMessage();*/
            /*//상속7
            Wizard p = new Wizard();
            p.Show();//부모를 먼저들렀다가 자식으로 와서 실행함
            */

        }
    }
}
