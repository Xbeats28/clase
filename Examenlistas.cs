﻿using System;
using System.Linq;

                    int count1 = 0;
                    foreach (int s in listd) { Console.Write(s + " || "); }


                    List<int> list2 = new List<int>(listd);//Diego Fernandez Lorenzo
                    Console.WriteLine("nueva lista");
                    foreach (int s in listd) { Console.Write(s + " || "); }
                    List<int> list3 = new List<int>();//Diego Fernandez Lorenzo
                    
                    foreach(int i in listd)
                    {

                        if(i<0)
                        {
                            list3.Add(i);


                        }
                     
                    }
                    foreach (int s in list3) { Console.Write(s + " || "); }
                    Console.WriteLine("sin duplicados");
                    HashSet<int> set = new HashSet<int>(listd);
                    foreach (int s in set) { Console.Write(s + " || "); }