using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Q4
{
    enum EColor
    {
        red,
        blue,
        grey,
        lightblue,
        orange,
        yellow,
        magenta,
        green
    }

    internal static class Program
    {
        static bool[,] matrixDiGraph = new bool[,]
        {
                /* RED *//* BLUE *//* GREY *//* LIGHTBLUE *//* ORANGE *//* YELLOW *//* MAGENTA *//* GREEN */
       /* RED */{ false ,   true,     true,       false,       false,      false,       false,      false },
       /* BLUE */{ false ,  false,    false,      true,        false,      true,        false,      false },
       /* GREY */{ false ,  false,    false,      true,        true,       false,       false,      false },
       /* LIGHTBLUE */{false,true,     true,      false,       false,      false,       false,      false },
       /* ORANGE */{false , false,    false,      false,       false,      false,       true,       false },
       /* YELLOW */{false , false,    false,      false,       false,      false,       false,      true },
       /* MAGENTA */{false ,false,    false,      false,       false,      true,        false,      false },
       /* GREEN */{false ,  false,    false,      false,       false,      false,       false,      false }

        };

        static int[][] listDiGraph = new int[][]
        {
        /* RED */ new int[] { (int) EColor.blue, (int)EColor.grey},
        /* BLUE */ new int[] { (int) EColor.lightblue, (int)EColor.yellow},
        /* GREY */ new int[] { (int) EColor.lightblue, (int)EColor.orange},
        /* LIGHTBLUE */ new int[] { (int) EColor.blue, (int)EColor.grey},
        /* ORANGE */ new int[] { (int) EColor.magenta},
        /* YELLOW */ new int[] { (int) EColor.green},
        /* MAGENTA */ new int[] { (int) EColor.yellow},
        /* GREEN */ null
        };

        static bool[] visited = new bool[Enum.GetNames(typeof(EColor)).Length];

        static void Main(string[] args)
        {
            DFS((int)EColor.red);
            Console.ReadKey();
        }

        static void DFS(int start)
        {
            visited[start] = true;
            Console.WriteLine((EColor)start);

            if (listDiGraph[start] != null)
            {
                foreach (int neighbor in listDiGraph[start])
                {
                    if (!visited[neighbor])
                    {
                        DFS(neighbor);
                    }
                }
            }
        }
    }
}
