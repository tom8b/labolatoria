namespace ConsoleApp1.Kubik
{
    public class KubikFibonacci : IFibonacci
    {
        public int CountValueOfElement(int elementNumber)
        {
            if(elementNumber == 0 || elementNumber == 1)
            {
                return 1;
            }

            int[] fibonacci = new int[elementNumber+1];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i <= elementNumber; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci[i - 2] = 0;
            }

            return fibonacci[elementNumber];
        }
    }
}
