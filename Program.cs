using System;

namespace Mdev
{
    public class Solution {
        public int solution(string s) {
            int answer = 0;
            string sign = "+";
            if(s.Length >=1 && s.Length <=5){
               if(s.IndexOf("-")>-1 || s.IndexOf("+") > -1){
                  sign = s[0].ToString();
                  //Console.WriteLine(sign);  
                  answer = Int32.Parse(s.Substring(1,s.Length-1));
                  if(sign != ""){
                     if(sign == "+"){
                        answer = +answer;         
                     }else if(sign == "-"){
                         
                         answer = -answer;
                     }

                  }
               }
            }

            return answer;
        }   
    }

    public class Solution2{
    public int[] solution(int n, int m) {
        int _gcd = gcd(n,m);
        int[] answer = new int[]{_gcd,n*m/_gcd};
        return answer;
    }
    
        public int gcd(int a , int b){
            return (a%b == 0?b:gcd(b,a%b));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sol = new Solution();
            string str = "+1234";
            int result = sol.solution(str);  
            Console.WriteLine(result);
            string str2 = "-1234";
            int result2 = sol.solution(str2);
            Console.WriteLine(result2);

            Solution2 sol2 = new Solution2();
            int[] sol2_result = sol2.solution(4,12);
            Console.WriteLine(sol2_result.ToString());

        }
    }
}
