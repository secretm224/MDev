﻿using System;

namespace Skil
{
    public static class Skil_level_1
    {
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


        public static int[] solution(int[,] v)
        {
            int[] answer={0,0};
            
            if(v.Length > 0){
                Console.WriteLine("Test");        
                for(int i=0; i< v.GetLength(0); i++){
                    for(int j=0; j<v.GetLength(1); j++){
                        
                        
                    }
                }  
            }
            
            System.Console.WriteLine("Hello C#");

            return answer;
        }


        public class check {
            public int x;
            public int y;


        }

        





        
    }

}
