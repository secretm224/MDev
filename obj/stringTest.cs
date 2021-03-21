namespace Mdev.obj
{
    public class stringTest
    {
        public string TestMethod(string s){
            string result = "";
            int[] arr = s.Split(" ");
            if(arr.Length > 0){
                Array.Sort(arr);  
                result = arr[0].ToString() + " " + arr[arr.Length].ToString();
            }
            return result;

        }    
    }

    static void main(){

       stringTest str = new stringTest();
       string rest = str.TestMethod("1 2 3 4");
       console.WriteLine(rest);

    }
}