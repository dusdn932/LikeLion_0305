using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    class LOL
    {
        public string Name;
        public int Health;
        public LOL()
        {
            Name = "Unknown";
            Health = 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 기본 공격을 합니다.");
        }
        public virtual void Heal(LOL target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    class ad_ch : LOL
    {
        public ad_ch()
        {
            Name = "공격력챔피언";
            Health = 60;
        }
        public override void Attack()
        {
            Console.WriteLine("상대챔피언/미니언/에픽몬스터를 공격을 합니다(공격력이 높음)");
        }
    }
    class ap_ch : LOL
    {
        public ap_ch()
        {
            Name = "주문력챔피언";
            Health = 60;
        }
        public override void Attack()
        {
            Console.WriteLine("상대챔피언/미니언/에픽몬스터를 공격을 합니다(주문력이 높음)");
        }
    }
    class heal_ch : LOL
    {
        public heal_ch()
        {
            Name = "힐 챔피언";
            Health = 50;
        }
        public override void Attack()
        {
            Console.WriteLine("상대챔피언/미니언/에픽몬스터를 공격을 합니다(굉장히 약함;;;)");
        }
        public override void Heal(LOL target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다. (생명유닛만 가능)");
        }
    }
    class minion : LOL
    {
        public minion()
        {
            Name = "미니언";
            Health = 10;
        }
        public override void Attack()
        {
            Console.WriteLine("상대 미니언을 떄리고 상대챔프가 자신의 팀 챔프를 떄릴때 그챔피언을공격합니다.");
        }
        public override void Move()
        {
            Console.WriteLine("상대 미니언에게 다가가다가 자신을 때린 챔피언에게 서서히 움직입니다.");
        }
    }
    class epic_mon : LOL
    {
        public epic_mon()
        {
            Name = "에픽몬스터";
            Health = 150;
        }
        public override void Attack()
        {
            Console.WriteLine("자신을 공격하는 챔피언을 공격합니다.");
        }
        public override void Move()
        {
            Console.WriteLine("자신을 때린 챔피언에게 서서히 움직입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<LOL> lol_units = new List<LOL>();
            lol_units.Add(new ad_ch());
            lol_units.Add(new ap_ch());
            lol_units.Add(new heal_ch());
            lol_units.Add(new minion());
            lol_units.Add(new epic_mon());
            foreach(var units in lol_units)
            {
                units.Move();
                units.Attack();
                Console.WriteLine();
            }
            heal_ch healch = new heal_ch();
            healch.Heal(lol_units[0]);
            healch.Heal(lol_units[1]);
        }
    }
}
