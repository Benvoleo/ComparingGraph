using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ComparingGraph
{
    public class Comparing
    {
        /// <summary>
        /// Main ligic of Graph
        /// </summary>
        public class Graph
        {

            /// <summary>
            /// for draw
            /// </summary>
            public DrawGraph G;

            /// <summary>
            /// all peaks
            /// </summary>
            public List<Vertex> V = new List<Vertex>();

            /// <summary>
            /// all facets
            /// </summary>
            public List<Edge> E = new List<Edge>();

            /// <summary>
            /// name of file
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// count of peaks
            /// </summary>
            public int NumberOfDots { get; set; }

            /// <summary>
            /// count of facets
            /// </summary>
            public int NumberOfFacets { get; set; }

            /// <summary>
            /// MFO graph list
            /// </summary>
            public List<int> MFO = new List<int>();

            /// <summary>
            /// matrix of MFO
            /// </summary>
            public int[,] Matrix { get; set; }

            /// <summary>
            /// check graph for eulerian 
            /// </summary>
            public bool IsEulerian { get; set; }

            /// <summary>
            /// eulerian way
            /// </summary>
            public List<int> eulerianWay = new List<int>();

            /// <summary>
            /// clear all fields
            /// </summary>
            public void ClearAllData()
            {
                Name = "Error";
                NumberOfDots = 0;
                NumberOfFacets = 0;
                IsEulerian = false;
                E.Clear();
                V.Clear();
                G.clearSheet();
                eulerianWay.Clear();
                MFO.Clear();
            }

            /// <summary>
            /// check for connect
            /// </summary>
            private bool IsConnected()
            {
                int[] VertexState = new int[NumberOfDots];
                bool flag = false;
                int k = 0;
                int finalCount = 0;


                for (int i = 0; i < NumberOfDots; i++)
                    VertexState[i] = 1;


                VertexState[0] = 2;


                do
                {
                    flag = true;

                    for (int i = 0; i < NumberOfDots; i++)
                        if (VertexState[i] == 2) 
                        {
                            VertexState[i] = 3; 
                            k = i;
                            break;
                        }

                    for (int i = 0; i < NumberOfDots; i++)
                        if (Matrix[k,i] == 1 && VertexState[i] == 1)
                            VertexState[i] = 2; 
                                            
                    for (int i = 0; i < NumberOfDots; i++)
                        if (VertexState[i] == 2)
                            flag = false;

                } while (flag == false);

                for (int i = 0; i < NumberOfDots; i++)
                    if (VertexState[i] == 1)
                        finalCount++;

                if (finalCount == 0)
                    return true;
                else
                    return false;

            }

            public void longRoute()
            {
                
            }

            /// <summary>
            /// check graph for eulerian 
            /// </summary>
            /// <returns></returns>
            public void EulerianOrNot()
            {

                int OddDots = 0;

                for (int i = 0; i < NumberOfDots; i++)
                {
                    int tmp = 0;
                    for (int j = 0; j < NumberOfDots; j++)
                    
                        if (Matrix[i, j] == 1)
                            tmp++;

                    if (tmp % 2 != 0)
                        OddDots++;
                }

                if (OddDots <= 2 && IsConnected())
                    FindEulerian();
                else
                    IsEulerian = false;
                
            }

            /// <summary>
            /// check graph for eulerian way
            /// </summary>
            private void FindEulerian()
            {
                string result = "";
                List<int> NodeList = new List<int>();

                int[,] tmp = new int[NumberOfDots,NumberOfDots];

                for (int i = 0; i < NumberOfDots; i++)
                {
                    for (int j = 0; j < NumberOfDots; j++)
                    {
                        tmp[i, j] = Matrix[i, j];
                    }
                }

                for (int i = 0; i < NumberOfDots; i++)
                    NodeList.Add(i);

                int key = 0;

                for (int i = 0; i < NumberOfDots; i++)
                {
                    int N = 0;
                    for (int j = 0; j < NumberOfDots; j++)
                    {
                        if (tmp[i, j] == 1)
                            N++;
                    }
                    if (N % 2 != 0)
                    {
                        key = i;
                        break;
                    }
                }

                Stack<int> tempPath = new Stack<int>();

                Stack<int> finalPath = new Stack<int>();

                int start = NodeList[key];      
                tempPath.Push(NodeList[key]);   

                try
                {
                    while (tempPath.Count != 0)
                    {
                        for (int i = 0; i < NumberOfDots; i++)
                        {
                            if (tmp[start, i] == 1)                 
                            {
                                tempPath.Push(NodeList[i]);           
                                tmp[start, i] = 0;                 
                                tmp[i, start] = 0;                  

                                if (!hasNeighbour((int)tempPath.Peek(), tmp)) 
                                {                                       
                                    while (tempPath.Count!= 0 && !hasNeighbour((int)tempPath.Peek(), tmp) )
                                    {
                                        finalPath.Push(tempPath.Pop()); 
                                    }
                                    start = (int)finalPath.Peek();      
                                }
                                else                                  
                                {
                                    start = i;                      
                                    break;
                                }
                            }
                        }
                    }

                    foreach (int o in finalPath)
                    {
                        result += Convert.ToString(o) + " ";
                        eulerianWay.Add(o+1);
                        IsEulerian = true;
                    }
                    NumberOfFacets = finalPath.Count - 1;
                }
                catch (Exception ex)
                {
                   
                }
            }

            /// <summary>
            /// check for meighbours
            /// </summary>
            /// <param name="currentPeak">name of current peak</param>
            /// <param name="tmp">Копия матрицы смежности</param>
            /// <returns></returns>
            private bool hasNeighbour(int currentPeak, int[,]tmp)
            {
                for (int i = 0; i < NumberOfDots; i++)
                {
                    if (tmp[currentPeak, i] == 1)
                        return true;
                }
                return false;
            }

            /// <summary>
            /// MFO -> matrix
            /// </summary>
            /// <returns>boolean</returns>
            public bool ConvertMFOtoMatrix()
            {
                try
                {
                    int c = 0;
                    for (int i = 0; i < MFO.Count; i++)
                        if (MFO[i] == 0)
                            c++;

                    if (c == 0)
                    {
                        MessageBox.Show("MFO-Error. A has no or (0) separator delimiter", "Error FO");
                        ClearAllData();
                        return false;
                    }
                    else
                    {
                        c++;
                        NumberOfDots = c; 
                        Matrix = new int[c, c];
                        int k = 0;

                        for (int i = 0; i < c; i++)                 
                        {
                            for (int j = 0; j <= NumberOfDots; j++) 
                            {
                                if (k == MFO.Count || MFO[k] == 0) 
                                    j = c;

                                else if (MFO[k] == j)               
                                {
                                    Matrix[i, j - 1] = 1;
                                    k++;
                                    j = 0;
                                }
                            }
                            k++;
                        }
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("Check your file", "Input Error");
                    ClearAllData();
                    return false;
                } 
            }

            /// <summary>
            /// visualize graph
            /// </summary>
            public void Visualize()
            {
                
                int N = 360 / NumberOfDots;
                double x = 0;
                double y = 0;

                int startX = G.centrX,
                    startY = G.centrY;

                for (int i = 0; i < NumberOfDots; i++)
                {
                    x = G.RTr * Math.Cos(((0 - N) * i) * Math.PI / 180);
                    y = G.RTr * Math.Sin(((0 - N) * i) * Math.PI / 180);
                         
                    Vertex v = new Vertex(startX + Convert.ToInt32(x), startY + Convert.ToInt32(y));
                    V.Add(v);
                }

                int[,] tmp = new int[NumberOfDots, NumberOfDots];

                for (int i = 0; i < NumberOfDots; i++)
                    for (int j = 0; j < NumberOfDots; j++)
                        tmp[i, j] = Matrix[i, j];                

                for (int i = 0; i < NumberOfDots; i++)
                    for (int j = 0; j < NumberOfDots; j++)
                        if (tmp[i, j] == 1)
                        {
                            Edge e = new Edge(i,j);
                            E.Add(e);
                            tmp[i, j] = 0;
                            tmp[j, i] = 0;
                        }
                
                G.DrawAllGraph(V,E);
            }

            /// <summary>
            /// draw eulerian way
            /// </summary>
            public void DrawWay()
            {
                G.DrawWay(V, eulerianWay);
            }

            /// <summary>
            /// read graph from file
            /// </summary>
            public bool ReadFromFile()
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Read MFO file";
                openFile.Filter = "txt files (*.txt)|*.txt";
                openFile.RestoreDirectory = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (FileToMFO(openFile))
                    {
                        if(ConvertMFOtoMatrix())
                            return true;
                        else 
                            return false;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// save graph to file
            /// </summary>
            public void SaveToFile(string st)
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.Title = "Save img " + st + " as ...";
                saveFile1.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png";
                saveFile1.RestoreDirectory = true;
                saveFile1.FileName = $"{st}";

                if (saveFile1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFile1.FileName;
                    string str = fileName.Remove(0, fileName.Length - 3);
                    switch (str)
                    {
                        case "bmp":
                            G.bitmap.Save(fileName, ImageFormat.Bmp);
                            break;

                        case "gif":
                            G.bitmap.Save(fileName, ImageFormat.Gif);
                            break;

                        case "jpg":
                            G.bitmap.Save(fileName, ImageFormat.Jpeg);
                            break;

                        case "tif":
                            G.bitmap.Save(fileName, ImageFormat.Tiff);
                            break;

                        case "png":
                            G.bitmap.Save(fileName, ImageFormat.Png);
                            break;

                        default:
                            break;
                    }
                }
            }

            /// <summary>
            /// From file to MFO
            /// </summary>
            /// <param name="dialog">Открытый файл</param>
            /// <returns></returns>
            private bool FileToMFO(OpenFileDialog dialog)
            {
                string fileN = "";
                string AllText = "";

                string[] ArrayWithData = new string[500];

                List<int> OutputArray = new List<int>();
                try
                {
                    fileN = dialog.FileName;
                    AllText = File.ReadAllText(fileN);
                    ArrayWithData = AllText.Split(' ');

                    for (int i = 0; i < ArrayWithData.Length; i++)
                    {
                        if(ArrayWithData[i]!= "")
                            OutputArray.Add(Convert.ToInt32(ArrayWithData[i]));
                    }

                    Name = fileN;
                    int[] a = new int[ArrayWithData.Length];
                    MFO = OutputArray;
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error from input data", "Error!");
                    ClearAllData();
                    return false;
                }                
            }
        }

        public class Vertex
        {
            public int x, y;
            public Vertex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public class Vertex1
            {
                public int x, y;

                public Vertex1(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
            }
        }

        public class Edge
        {
            public int v1, v2;

            public Edge(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }

        public class DrawGraph
        {
            private Graph graph;

            public Bitmap bitmap;

            private Pen blackPen;

            private Pen redPen;

            private Pen greenPen;

            private Graphics gr;

            private Font GraphFont;

            private Brush GraphBrush;

            private PointF point;

            public int centrX, centrY;

            public int RTr = 205;

            public int R = 10;

            public DrawGraph(int width, int height, Graph Grap)
            {
                graph = Grap;
                bitmap = new Bitmap(width, height);
                gr = Graphics.FromImage(bitmap);

                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                clearSheet();

                blackPen = new Pen(Color.Black);
                blackPen.Width = 2;

                redPen = new Pen(Color.Red);
                redPen.LineJoin = LineJoin.Miter;
                redPen.Width = 10;
                redPen.EndCap = LineCap.ArrowAnchor;

                greenPen = new Pen(Color.Green);
                greenPen.Width = 4;

                GraphFont = new Font("Arial", 10, FontStyle.Bold);
                GraphBrush = Brushes.Black;

                centrX = bitmap.Width / 2;
                centrY = bitmap.Height / 2;
            }

            public void clearSheet()
            {
                gr.Clear(Color.White);
                gr.Clear(Color.Transparent);
            }

            public Bitmap GetBitmap()
            {
                return bitmap;
            }

            public void DrawWay(List<Vertex> Ver, List<int> Way)
            {
                for (int i = 0; i < Way.Count - 1; i++)
                {
                    Edge e = new Edge(Way[i], Way[i + 1]);
                    
                    DrawEdge(Ver[Way[i]-1], Ver[Way[i+1]-1], e, redPen);
                }
            }

            public void DrawVertex(int x, int y, string number)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 6, y - 6);
                gr.DrawString(number, GraphFont, GraphBrush, point);
            }

            public void DrawEdge(Vertex V1, Vertex V2, Edge E, Pen pen)
            {
                if (E.v1 == E.v2)
                {
                    gr.DrawArc(pen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                    point = new PointF(V1.x - (int)(2.75 * R), V1.y - (int)(2.75 * R));
                    DrawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                }
                else
                {
                    gr.DrawLine(pen, V1.x, V1.y, V2.x, V2.y);
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    DrawVertex(V1.x, V1.y, (E.v1 ).ToString());
                    DrawVertex(V2.x, V2.y, (E.v2 ).ToString());
                }
            }
            public void DrawAllGraph(List<Vertex> V, List<Edge> E)
            {
                
                gr.Clear(Color.Transparent);
              
                for (int i = 0; i < E.Count; i++)
                {
                    if (E[i].v1 == E[i].v2)
                    {
                        gr.DrawArc(greenPen, (V[E[i].v1].x - 2 * R), (V[E[i].v1].y - 2 * R), 2 * R, 2 * R, 90, 270);
                    }
                    else
                    {
                        gr.DrawLine(greenPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                    }
                }

                for (int i = 0; i < V.Count; i++)
                {
                    DrawVertex(V[i].x, V[i].y, (i + 1).ToString());
                }

                
                graph.NumberOfFacets = E.Count;
            }
        }
    }
}
