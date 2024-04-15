namespace _4M_33_sort1
{
    class Tablica
    {
        private int N;
        private int[] tab;
        private int ile = 0;
        public Tablica(int rozmiar)
        {
            N = rozmiar;
            tab = new int[N];
            Random r = new Random();
            for (int i =1 ; i < N; i++)
                tab[i] = r.Next(0,100);
            //sortuj();
            bogoSort();
        }
        private void bogoSort()
        {
            Random r = new Random();
            
            bool isSorted()
            {
                for(int i=0; i<N-1; i++)
                    if (tab[i] > tab[i+1])
                        return false;
                return true;
            }
            void shuffle()
            {
                ile++;
                if (ile % 100000000 == 0)
                    Console.WriteLine(ile);
                for(int i=0; i<N; i++)
                {
                    var a = r.Next(0,N);
                    var b = r.Next(0,N);
                    var temp = tab[a];
                    tab[a] = tab[b];
                    tab[b] = temp;
                }
            }

            while (! isSorted())
                shuffle();
        }
        private void sortuj()
        {
            for (var j = 1; j < N; j++)
            {
                var pmin = j;
                for(var i = j+1;i < N; i++)
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
            for(var i=0; i< N; i++)
                s += tab[i].ToString() + "; ";
            return $"prób: {ile}, tablica: {s}";
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
