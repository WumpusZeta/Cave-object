using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cave
{
    class Cave
    {
        private String fileName;
        public Cave(String name)
        {
            fileName = name;
        }
        public int[] getNeighbors(int roomNumber)
        {
            int[] neighbors = { 25, 26, 2, 7, 6 };
            return neighbors;
        }
        public int[] getDoors(int roomNumber)
        {
            int[] doors = { 0, 0, 2, 7, 0, 0 };
            return doors;
        }
        public void createCave()
        {
            Console.WriteLine("Cave created.");
        }
    }
}
