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
        }
    }
}
