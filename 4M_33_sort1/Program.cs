namespace _4M_33_sort1
{
    class Tablica
    {
        private int N;
        private int[] tab;
        public Tablica(int rozmiar)
        {
            N = rozmiar;
            tab = new int[N+1];
            Random r = new Random();
            for (int i = 1; i <= N; i++)
                tab[i] = r.Next(0,100);
            sortuj();
        }
        private void sortuj()
        {
            for (var j = 1; j < N; j++)
            {
                var pmin = j;
                for(var i = j+1;i <= N; i++)
                {
                    if (tab[i] < tab[pmin])
                        pmin = i;
                }
                var temp = tab[pmin];
                tab[pmin] = tab[j];
                tab[j] = temp;
            }
        }
        public override string ToString()
        {
            string s = "";
            for(var i=1; i<= N; i++)
                s += tab[i].ToString() + "; ";
            return $"{s}";
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Tablica t = new(10);
            Console.WriteLine(t);
        }
    }
}
