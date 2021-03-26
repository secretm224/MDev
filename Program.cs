using System;
using Newtonsoft.Json;

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

    public class stringTest
    {
        public string TestMethod(string s){
            string result = "";
            string[] arr = s.Split(" ");
            int[] rst = null;

            if(arr.Length > 0){

                rst = Array.ConvertAll(arr,t =>int.Parse(t));
                Array.Sort(rst);  
                result = rst[0].ToString() + " " + rst[rst.Length-1].ToString();
            }
            return result;

        }    
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            //test area 
            /*
            stringTest st = new stringTest();
            string result = st.TestMethod("1 2 3 4");
            Console.WriteLine(result);
            int[]a = {1,2};
            int[]b = {3,4};
 
           int test =  arraytest(a,b);
           Console.WriteLine(test);


            Account account = new Account();
            account.Name ="Moon";
            account.Email ="secretm224@gmail.com";
            account.DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc);

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);

            Console.WriteLine(json);    
            */

            ProTestCase1("try hello world");
        }

        public static int arraytest(int[]A , int[] B){

            int answer = 0;
             if(A.Length > 0 && B.Length > 0 && A.Length == B.Length){
                for(int i=0; i< A.Length; i++){
                   
                        answer = answer + (A[i] * B[i]);
                        Console.WriteLine(answer);
                    
                }
            }
            return answer;
        }

        public class Account
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime DOB { get; set; }
        }

        public static string ProTestCase1(string str)
        {
            string answer = "";
            if(str != null){
                if(str.IndexOf(' ') > -1){
                    string[] temp = str.Split(' ');
                    if(temp.Length > 0){
                        for(int i = 0; i<temp.Length; i++){
                            if(temp[i] != null){
                                char[] char__arr = temp[i].ToCharArray();
                                if(char__arr.Length > 0){
                                    for(int j=0; j<char__arr.Length; j++){
                                        if(j%2 ==0){
                                            char__arr[j] = Char.ToUpper(char__arr[j]);     
                                        }
                                    }

                                    Console.WriteLine(char__arr.ToString());
                                    answer = answer + string.Join("",char__arr) + " ";

                                }
                            }
                        }
                    }
                }    
            }

            Console.WriteLine(answer);
            return answer;     
        }

    }
}
