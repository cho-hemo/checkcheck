namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {    2023.01.05      Add new feature user input / Beta
            Console.WriteLine("이 프로그램은 cm를 inch로 바꿔줍니다.");
            Console.WriteLine("몇 cm인지 입력해주세요.");
            int cm;
            int.TryParse(Console.ReadLine(), out cm);
            // }    2023.01.05      Add new feature user input / Beta
            Ruler ruler = new Ruler(cm) ;
            ruler.Run();
        }
    }
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Ruler(int cmValue)
        {
            Centimeter= cmValue;
        }
        public void Run()
        {
            Console.WriteLine($"{Centimeter}센티미터는 {Inch}인치입니다.");
        }
    }
}