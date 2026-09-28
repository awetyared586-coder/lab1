

class Lab
{
    static void Main()
    {
        //string input = "34538cbgb76hfuy7ffhr21422534352762";
        Console.Write("inter string: ");
        string input = Console.ReadLine();
        long total = 0; ;
        //Console.WriteLine("input="+input);


        for (int  i=0; i<input.Length; i++)
        {
            //Console.WriteLine(input[i]); 
            if (!char.IsDigit(input[i])) continue;

            for (int j = i + 2; j<input.Length;j++)
            {
                //Console.WriteLine(input[j]);
                if (input[j] != input[i]) continue;
                //Console.WriteLine("match found :" + input.Substring(i,j-i+1));

                bool onliyDigit = true;
               
      
                for (int n = i+1; n <j; n++)
                {
                    if (!char.IsDigit(input[n]) || input[n] == input[i])
                    {
                        onliyDigit = false;
                        break;
                    }
                }
                if (!onliyDigit) continue;
                long number = long.Parse(input.Substring(i, j - i + 1));
                total += number;

                for (int k = 0; k < input.Length; k++)
                {
                    if (k >= i && k<=j )
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(input[k]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(input[k]);



                    }
                }
                Console.WriteLine();

            }
        }
        Console.WriteLine();
        Console.WriteLine("Total =" + total);


    }

}

