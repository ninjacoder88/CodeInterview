using System;
using System.Collections.Generic;

namespace CodeInterview.Demos
{
    public class FindOverlappingSquares
    {
        public FindOverlappingSquares()
        {
            Squares = new List<Square>
                {
                    new Square(){
                        Id = 1,
                        Corners = new List<Point>
                            {
                                new Point(0,1),
                                new Point(0,3),
                                new Point(2,3),
                                new Point(2,1)
                            },
                    },
                    new Square(){
                        Id = 2,
                        Corners = new List<Point>{
                            new Point(1,0),
                            new Point(1,2),
                            new Point(3,2),
                            new Point(3,0)
                        }
                    },
                    new Square(){
                        Id = 3,
                        Corners = new List<Point>{
                            new Point(2,0),
                            new Point(2,1),
                            new Point(3,0),
                            new Point(3,1)
                        }
                    }
                };
        }

        public List<Square> Squares {get;}

        public List<Tuple<Square, Square>> Find()
        {
            List<Tuple<Square, Square>> overlappingSquares = new List<Tuple<Square, Square>>();

            for(int i = 0; i < Squares.Count; i++)
            {
                var s1 = Squares[i];
                for(int j = 0; j < i; j++)
                {
                    var s2 = Squares[j];

                    for(var c1 = 0; c1 < s1.Corners.Count; c1++)
                    {
                        var xlt = 0;
                        var xgt = 0;
                        var ylt = 0;
                        var ygt = 0;
                        var p1 = s1.Corners[c1];

                        for(var c2 = 0; c2 < s2.Corners.Count; c2++)
                        {
                            var p2 = s2.Corners[c2];

                            if(p1.X < p2.X)
                            {
                                xlt++;
                            }
                            else
                            {
                                xgt++;
                            }

                            if(p1.Y < p2.Y)
                            {
                                ylt++;
                            }
                            else
                            {
                                ygt++;
                            }
                        }

                        if(xlt > 2 || xgt > 2 || ylt > 2 || ygt > 2)
                        {
                            //not overlapping
                        }
                        else
                        {
                            overlappingSquares.Add(new Tuple<Square, Square>(s1, s2));
                        }
                    }
                }
            }

            return overlappingSquares;
        }
    }

    public class Square
    {
        public int Id {get;set;}
        public List<Point> Corners {get;set;}
    }

    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X {get;}
        public int Y {get;}
    }
}