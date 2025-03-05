using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /*//부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        protected int Health;
    
        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다.");
        }
        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }
        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 공격합니다.!(공격력이 약함)");
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다.(기계유닛만 가능)");
        }
    }
    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }
        public override void Attack()
        {
            Console.WriteLine("Marine이 소총으로 공격합니다.");
        }
    }
    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명유닛만 가능)");
        }
    }
    class Tank: Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }
        public override void Attack()
        {
            Console.WriteLine("Tank가 시즈모드로 강력한 포격");
        }
        public override void Move()
        {
            Console.WriteLine("탱크가 천천히 움직입니다.");
        }

    }*/

    /*class Skill
    {
        public string Name; //스킬이름
        public int ManaCost; //마나소모량
        public int Cooldown; //재사용 대기 시간(밀리초)
        public int LastUsedTime; //마지막 사용 시간(TickCount 기준)
        public Skill(string name, int manaCost, int cooldown)
        {
            Name = name;
            ManaCost = manaCost;
            Cooldown = cooldown * 1000; //초를 밀리초로 변환
            LastUsedTime = 0; //처음엔 사용하지 않은 상태
        }
        //스킬 사용 가능 여부 확인
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;
            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! (필요 MP : {ManaCost})");
                return false;
            }
            if (currentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown = (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{Name} 스킬은 아직 사용할 수 없습니다.(남은시간 : {remainingTime}초)");
                return false;

            }
            return true;
        }
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;
            playerMana -= ManaCost;//플레이어 마나 참조로 외부값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount; //현재 시간을 저장
            Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Unit> units = new List<Unit>();
            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());
            //모든 유닛을 순회하며 다형성 적용
            foreach(var unit in units)
            {
                unit.Move(); //이동
                unit.Attack();//공격\
                Console.WriteLine();
            }
            SCV scv = new SCV();
            scv.Heal(units[3]);//탱크수리

            Medic medic = new Medic();
            medic.Heal(units[1]);*/
            /*int playerMana = 200; //플레이어의 초기 마나
            //스킬 목록(배열 사용)
            Skill[] skills = new Skill[]
            {
                new Skill("파이어볼" , 20, 3),  //마나 20소모 3초 쿨다운
                new Skill("얼음창" , 15, 2),    //마나 15소모 2초 쿨다운
                new Skill("썬더볼트" , 30, 4)   //마나 30소모 4초 쿨다운
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP : {playerMana}");
                Console.WriteLine("사용 가능한 스킬: ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost}, 쿨다운 {skills[i].Cooldown / 1000}s)");
                }
                Console.WriteLine("0.종료");
                Console.Write("사용할 스킬 번호를 입력하세요: ");
                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());
                    if (skillIndex == 0) break;
                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                catch
                {

                    Console.WriteLine("숫자를 입력하세요!");
                }
                Thread.Sleep(500); //CPU과부화 방지
            }
            Console.WriteLine("게임 종료");*/
        }
    }
}

