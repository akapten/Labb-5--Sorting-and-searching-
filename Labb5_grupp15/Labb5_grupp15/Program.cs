using System.Diagnostics;
using System.Globalization;

namespace Labb5_grupp15
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Exempelarrayer för testning
            
            int[] slumpArray = { 864, 394, 776, 911, 430, 41, 265, 988, 523, 497, 414, 940, 802, 849, 310, 991, 488, 366, 597, 913, 929, 223, 516, 142, 288, 143, 773, 97, 633, 818, 256, 931, 545, 722, 829, 616, 923, 150, 317, 101, 747, 75, 920, 870, 700, 338, 483, 573, 103, 23 }; 
            int[] sorteradArray = { 23, 41, 75, 97, 101, 103, 142, 143, 150, 223, 256, 265, 288, 310, 317, 338, 362, 366, 394, 414, 430, 483, 488, 497, 516, 523, 545, 573, 597, 616, 633, 700, 722, 747, 773, 776, 802, 818, 829, 849, 864, 870, 911, 913, 920, 923, 929, 931, 940, 991 }; 
            int[] omvändSorteradArray = { 991, 940, 931, 929, 923, 920, 913, 911, 870, 864, 849, 829, 818, 802, 776, 773, 747, 722, 700, 633, 616, 597, 573, 545, 523, 516, 497, 488, 483, 430, 414, 394, 366, 362, 338, 317, 310, 288, 265, 256, 223, 150, 143, 142, 103, 101, 97, 75, 41, 23 }; 
            int[] nästanSorteradArray = { 23, 41, 75, 97, 101, 103, 142, 143, 150, 223, 256, 265, 288, 310, 317, 338, 362, 366, 394, 414, 430, 483, 488, 497, 516, 523, 545, 573, 597, 616, 633, 700, 722, 747, 773, 776, 802, 818, 829, 849, 864, 870, 911, 913, 920, 923, 929, 931, 940, 991 }; 

            // Testa sorteringsalgoritmer
            TestaSorteringsAlgoritmer(slumpArray, "Slumpmässig Array");
            TestaSorteringsAlgoritmer(sorteradArray, "Sorterad Array");
            TestaSorteringsAlgoritmer(omvändSorteradArray, "Omvänd Sorterad Array");
            TestaSorteringsAlgoritmer(nästanSorteradArray, "Nästan Sorterad Array");

            // Testa sökalgoritmer
            TestaSökalgoritmer(sorteradArray);
        }

        private static void TestaSorteringsAlgoritmer(int[] array, string arrayTyp)
        {
            Console.WriteLine($"\nTestar sorteringsalgoritmer med {arrayTyp}:");

            int[] arrayKopia;

            // Bubblesortering
            arrayKopia = (int[])array.Clone();
            sorteringsalgoritmer.BubbleSort(arrayKopia);
            Console.WriteLine("Bubblesortering:");
            SkrivUtArray(arrayKopia);

            // Insertionsortering
            arrayKopia = (int[])array.Clone();
            sorteringsalgoritmer.InsertionSort(arrayKopia);
            Console.WriteLine("Insertionsortering:");
            SkrivUtArray(arrayKopia);

            // Selectionsortering
            arrayKopia = (int[])array.Clone();
            sorteringsalgoritmer.SelectionSort(arrayKopia);
            Console.WriteLine("Selectionsortering:");
            SkrivUtArray(arrayKopia);

            // Heapsortering
            arrayKopia = (int[])array.Clone();
            sorteringsalgoritmer.Heapsort(arrayKopia);
            Console.WriteLine("Heapsortering:");
            SkrivUtArray(arrayKopia);

            // Quicksortering
            arrayKopia = (int[])array.Clone();
            sorteringsalgoritmer.Quicksort(arrayKopia, 0, arrayKopia.Length - 1);
            Console.WriteLine("Quicksortering:");
            SkrivUtArray(arrayKopia);
        }
        
        private static void TestaSökalgoritmer(int[] sorteradArray)
        {
            Console.WriteLine("\nTestar sökalgoritmer:");

            int nyckeltest = 414;
            int nyckeltest1 = 75;
            int nyckeltest2 = 802;

            // Linjärsökning
            int resultat = LinearSearch.Search(sorteradArray, nyckeltest);
            Console.WriteLine($"Linjärsökning: Nyckel {nyckeltest} hittades vid index {resultat}");

            // Binärsökning
            resultat = BinarySearch.Search(sorteradArray, nyckeltest1);
            Console.WriteLine($"Binärsökning: Nyckel {nyckeltest1} hittades vid index {resultat}");

            // Interpoleringssökning
            resultat = InterpolationSearch.Search(sorteradArray, nyckeltest2);
            Console.WriteLine($"Interpoleringssökning: Nyckel {nyckeltest2} hittades vid index {resultat}");
        }
        
        private static void SkrivUtArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
