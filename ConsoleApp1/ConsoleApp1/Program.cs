using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*order by(람다식을 곁들인)
            string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);
            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }
            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A: {firstName}");
            int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach (var d in data)
                Console.WriteLine(d);
             */
            /*//메서드 구문, 쿼리 구문
            int[] nums = { 5, 3, 8, 1 };
            //메서드구문
            var sortedMeshod = nums.OrderBy(n => n);
            //쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;


            Console.WriteLine("Meshod syntax : ");
            foreach (var n in sortedMeshod)
                Console.WriteLine(n);

            Console.WriteLine("Query syntax : ");
            foreach(var n in sortedQuery)
            {
                Console.WriteLine(n);
            }*/
            /*//Select()로 길이 추출
            string[] words = { "apple", "banana", "cherry" };
            var lengths = words.Select(w => w.Length);
            foreach(var length in lengths)
            {
                Console.WriteLine(length);
            }

            //select 개념
            //Ling 쿼리 연산자 중 하나
            //각 요소를 반환하여 새로운 컬렉션을 생성
            var upperWords = words.Select(w => w.ToUpper());
            foreach(var word in upperWords)
            {
                Console.WriteLine(word);
            }*/
            /*//sum, count, average, max, min 알고리즘
            
            int[] data = { 1, 2, 3, 4, 6,7 };
            //sum
            int sum = data.Sum();
            Console.WriteLine($"sum : {sum}");
            foreach(var d in data)
            {
                sum += d;
            }
            Console.WriteLine(sum);

            //count
            int count = data.Length;
            Console.WriteLine($"Count : {count}");

            //average
            double avg = (double)data.Average();
            Console.WriteLine($"Average : {avg:F2}");
            //Max
            int max = data.Max();
            Console.WriteLine($"Max : {max}");
            //min
            int min = data.Min();
            Console.WriteLine($"Min : {min}");*/
            /*//근삿값 구하기 :  NEAR 알고리즘
            //배열에서 특정 값에 가장 가까운 값을 찾는 예제
            int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];
            foreach(var d in data)
            {
                //Abs 절대값 함수
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }
            Console.WriteLine($"Nearest to {target} : {nearest}");*/
            /*//순위 구하기 Rank 알고리즘
            //각요소가 몇번째로 큰지 순위를 매기는 예제
            int[] scores = { 90, 70, 50, 80, 60 };
            for(int i = 0; i<scores.Length; i++)
            {
                int rank = 1;
                for(int j=0; j<scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score : {scores[i]}, Rank : {rank}");
            }*/
            /*//특정 값 검색하기 : Search 알고리즘
            int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");*/
            /*//그룹화하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화 하기
            //문자열 배열 선언 (과일 이름 리스트)
            string[] fruits = { "apple", "banana", "buleberry", "cherry", "apricot" };
            //LINQ의 GroupBy()를 사용하여 첫 글자를기준으로 그룹화
            var groups = fruits.GroupBy(f => f[0]); //첫글자로 그룹화
            //각 그룹을 순회하며 출력
            foreach(var group in groups)
            {
                //그룹의 Key(첫 글자) 출력
                Console.WriteLine($"Key : {group.Key}");
                //해당그룹에 속한 모든 요소 출력
                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }*/

        }
    }
}
