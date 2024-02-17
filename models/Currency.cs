using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp_lessons.models
{
    public struct student
        {
            public int id_stud {get; set;}
            public string name_stud {get; set;}
            public string sure_name {get; set;}
            public string isure_name2 {get; set;}
        }

    public struct subject
        {
            public int id_subj {get; set;}
            public string name_subj {get; set;}
            public string volume_of_lectures {get; set;}
            public string volume_of_practise {get; set;}
        }

    public struct lessons_plane
        {
            public int id_stud {get; set;}
            public string id_subj {get; set;}
            public string grade {get; set;}
        }
}
