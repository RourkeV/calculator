using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    
    public class brain
    {
        public List<String> equation = new List<String>();

        String num;

        public bool afterEqual = false;


        public void oneClick()
        {
            num += 1.ToString();
        }
        public void twoClick()
        {
            num += 2.ToString();
        }
        public void threeClick()
        {
            num += 3.ToString();
        }
        public void fourClick()
        {
            num += 4.ToString();
        }
        public void fiveClick()
        {
            num += 5.ToString();
        }
        public void sixClick()
        {
            num += 6.ToString();
        }
        public void sevenClick()
        {
            num += 7.ToString();
        }
        public void eightClick()
        {
            num += 8.ToString();
        }
        public void nineClick()
        {
            num += 9.ToString();
        }
        public void zeroClick()
        {
            num += 0.ToString();
        }
        public String eqlClick()
        {
            afterEqual = true;

            equation.Add(num);

            int finalResult = readEqn();


            

            num = "";

            return finalResult.ToString();
        }
        public void plusClick()
        {
            equation.Add(num);
            equation.Add("+");
            num = "";
        }

        public int readEqn()
        {
            
            createList();
            int final = executeEqn();

            return final;

        }

        public List<int> numbers = new List<int>();
        public List<String> operations = new List<String>();

        public void createList()
        {
            

            foreach (var value in equation)
            {
                switch (value)
                {
                    case "+":
                        operations.Add(value);
                        break;
                    default:
                        numbers.Add(int.Parse(value));
                        break;
                }
            }
        }
        public int executeEqn()
        {

            int answer = numbers[0];
            int i;
            for (i = 0; i < numbers.Count()-1; i++)
            {
                switch (operations[i])
                {
                    case "+":
                        answer += numbers[i+1];
                        break;
                    default:
                        break;
                }
            }
            numbers.Clear();
            equation.Clear();
            operations.Clear();
            i = 0;
            return answer;
        }
    }
}
