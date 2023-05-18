namespace HW04
{
    internal class Program
    {

        class A
        {
            public virtual int ABC()
            {
                return 1;
            }
        }

        class B :A
        {
            public override int ABC()
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            A b = new B();
            int abc = b.ABC();

            Console.WriteLine(abc);
        }
    }
}