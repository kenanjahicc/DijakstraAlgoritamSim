using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDijkstraAlgoritamKenan
{
    class Node
    {
        public int tn;
        public int rn;
        public int dn;
        public int ln;
        public Node(int tn1, int rn1, int dn1, int ln1) {
            tn = tn1;
            rn = rn1;
            dn = dn1;
            ln = ln1;
        }
    }
}
