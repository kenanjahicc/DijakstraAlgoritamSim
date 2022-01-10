using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDijkstraAlgoritamKenan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        
        private static String Print(int[] distance, int verticesCount)
        {
            String ispis="";
            

            for (int i = 0; i < verticesCount; ++i)
               ispis=ispis+distance[i].ToString()+"\n";
             
            return ispis;
        }

        public static String Dijkstra(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            return Print(distance, verticesCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            textBox1.Text = r.Next(25).ToString();
            textBox3.Text = r.Next(25).ToString();
            textBox4.Text = r.Next(25).ToString();
            textBox5.Text = r.Next(25).ToString();
            textBox6.Text = r.Next(25).ToString();
            textBox2.Text = r.Next(25).ToString();
            textBox7.Text = r.Next(25).ToString();
            textBox8.Text = r.Next(25).ToString();
            textBox9.Text = r.Next(25).ToString();
            textBox10.Text = r.Next(25).ToString();
            textBox11.Text = r.Next(25).ToString();
            textBox12.Text = r.Next(25).ToString();
            textBox13.Text = r.Next(25).ToString();
            textBox14.Text = r.Next(25).ToString();
            textBox15.Text = r.Next(25).ToString();
            textBox16.Text = r.Next(25).ToString();
            textBox17.Text = r.Next(25).ToString();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            
            Node n1=new Node (a,                         int.Parse(textBox1.Text) , int.Parse(textBox4.Text), a                         );
            Node n2=new Node (a,                         int.Parse(textBox2.Text) , int.Parse(textBox5.Text), int.Parse(textBox1.Text)  );
            Node n3=new Node (a,                         int.Parse(textBox3.Text) , int.Parse(textBox6.Text), int.Parse(textBox2.Text)  );
            Node n4=new Node (a,                         a                        , int.Parse(textBox7.Text), int.Parse(textBox3.Text)  );
                                                         
            Node n5=new Node (int.Parse(textBox4.Text),  int.Parse(textBox8.Text) , int.Parse(textBox11.Text), a                        );
            Node n6=new Node (int.Parse(textBox5.Text),  int.Parse(textBox9.Text) , int.Parse(textBox12.Text), int.Parse(textBox8.Text) );
            Node n7=new Node (int.Parse(textBox6.Text),  int.Parse(textBox10.Text), int.Parse(textBox13.Text), int.Parse(textBox9.Text) );
            Node n8=new Node (int.Parse(textBox7.Text),  a                        , int.Parse(textBox14.Text), int.Parse(textBox10.Text));
            
            Node n9=new Node (int.Parse(textBox11.Text), int.Parse(textBox15.Text), a                        , a                        );
            Node n10=new Node(int.Parse(textBox12.Text), int.Parse(textBox16.Text), a                        , int.Parse(textBox15.Text));
            Node n11=new Node(int.Parse(textBox13.Text), int.Parse(textBox17.Text), a                        , int.Parse(textBox16.Text));
            Node n12=new Node(int.Parse(textBox14.Text), a                        , a                        , int.Parse(textBox17.Text));

            int[,] graph = {
                           {  0,      n1.rn,  0    , 0,      n1.dn,  0,      0,      0,      0,0,0,0},                                 
                           {  n2.ln,  0    ,  n2.rn, 0,      0,      n2.dn,  0,      0,      0,0,0,0},
                           {  0,      n3.ln,  0    , n3.rn,  0,      0,      n3.dn,  0,      0,0,0,0},
                           {  0,      0    ,  n4.ln, 0,      0,      0,      0    ,  n4.dn,  0,0,0,0},

                           {  n5.tn,  0,      0,     0,      0      ,n5.rn , 0     , 0,     n5.dn,      0,      0,    0},
                           {  0,      n6.tn,  0,     0,      n6.ln  ,0     , n6.rn , 0,         0,  n6.dn,      0,    0},
                           {  0,      0,      n7.tn, 0,      0      ,n7.ln , 0     , n7.rn,         0,      0,  n7.dn,    0},
                           {  0,      0,      0,     n8.tn,  0      ,0     , n8.ln , 0,         0,      0,      0,    n8.dn},
                                       
                           {  0,0,0,0,  n9.tn,0       ,0       ,0       ,0        ,n9.rn    ,0         ,0          },
                           {  0,0,0,0,  0    ,n10.tn  ,0       ,0       ,n10.ln   ,0        ,n10.rn    ,0          },
                           {  0,0,0,0,  0    ,0       ,n11.tn  ,0       ,0        ,n11.ln   ,0         ,n11.rn     },
                           {  0,0,0,0,  0    ,0       ,0       ,n12.tn  ,0        ,0        ,n12.ln    ,0          }
                           };

            int currcity = 0;
            currcity = int.Parse(comboBox1.Text) - 1;

            label14.Text = Dijkstra(graph, currcity, 12);

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
