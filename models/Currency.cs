using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Dynamic;
using System.ComponentModel;

namespace Sharp_lessons.models
{
    public class Student
        {
            public int Id_stud {get; set;}
            public string Name_stud {get; set;}
            public string Sure_name {get; set;}
            public string Sure_name2 {get; set;}
        }

    public class Subject
        {
            public int id_subj {get; set;}
            public string Name_subj {get; set;}
            public int Volume_of_lectures {get; set;}
            public int Volume_of_practise {get; set;}
        }

    public class Lessons_plane
        {
            public int Id_stud {get; set;}
            public int Id_subj {get; set;}
            public int Grade {get; set;}
        }

    public class New_mark
        {
            public int id_stud { get; set; }
            public int id_subj { get; set;}
            public int grade { get; set;}
            public void set_mark(New_mark a)
            {
                string markJson = JsonSerializer.Serialize(a, typeof(New_mark));
                StreamWriter file = File.CreateText("struct.json");
                file.WriteLine(markJson);
                file.Close();
            }
        }
}

// string json = @"{

        //     'student':{
        //         [
        //             'id_stud':1,
        //             'name_stud':'Alice',
        //             'sure_name':'None',
        //             'sure_name2':'None'
        //         ],
        //         [
        //             'id_stud':2,
        //             'name_stud':'Bane',
        //             'sure_name':'None',
        //             'sure_name2':'None'
        //         ],
        //         [
        //             'id_stud':3,
        //             'name_stud':'Jhoe',
        //             'sure_name':'None',
        //             'sure_name2':'None'
        //         ],
        //         [
        //             'id_stud':4,
        //             'name_stud':'Kane',
        //             'sure_name':'None',
        //             'sure_name2':'None'
        //         ]
        //     },

        // 'subject':{
        //             [
        //                 'id_subj':1,
        //                 'name_subj':'Math',
        //                 'volume_of_lectures':32,
        //                 'volume_of_practise':104
        //             ],
        //             [
        //                 'id_subj':2,
        //                 'name_subj':'History',
        //                 'volume_of_lectures':32,
        //                 'volume_of_practise':104
        //             ],
        //             [
        //                 'id_subj':3,
        //                 'name_subj':'Informatics',
        //                 'volume_of_lectures':64,
        //                 'volume_of_practise':128
        //             ],
        //             [
        //                 'id_subj':4,
        //                 'name_subj':'literature',
        //                 'volume_of_lectures':32,
        //                 'volume_of_practise':104
        //             ]
        // },

        //     'lessons_plane':{
        //             [
        //                 'id_stud':1,
        //                 'id_subj':1,
        //                 'grade':5
        //             ]
        //     }";
