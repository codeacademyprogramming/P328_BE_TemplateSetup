using Homework.Models;
using System.Collections.Generic;

namespace Homework.DataAccess
{
    public static class Data
    {
        public static List<Group> Groups = new List<Group>()
        {
            new Group{Id=1,No = "P123"},
            new Group{Id=2,No = "P124"},
            new Group{Id=3,No = "P125"},
            new Group{Id=4,No = "P126"},
            new Group{Id=5,No = "P127"},
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student{Id = 1,Name = "Hikemt",Surname ="Abbasov",Point = 86},
            new Student{Id = 2,Name = "Tofiq",Surname ="Abbasov",Point = 46},
            new Student{Id = 3,Name = "Nermin",Surname ="Abbasova",Point = 96},
            new Student{Id = 4,Name = "Bayram",Surname ="Quliyev",Point = 80},
            new Student{Id = 5,Name = "Nergiz",Surname ="Ceferova",Point = 56},
            new Student{Id = 6,Name = "Abdulla",Surname ="Quliyev",Point = 46},
        };
    }
}
