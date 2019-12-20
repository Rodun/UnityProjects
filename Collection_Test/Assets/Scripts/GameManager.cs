using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        List<string> student_list = new List<string>();

        student_list.Add("홍길동");
        student_list.Remove("홍길동");
        student_list.Add("박혁거세");
        student_list.Add("선덕여왕");
        student_list.Contains("박혁거세");
        

        List<string> new_student = student_list.FindAll(student => (student.Length >= 4));

        foreach ( string _stu in new_student)
        {
            Debug.Log(_stu);
        }        

        //Debug.Log(student_list.FindAll(student => (student.Length >= 4)));

        
    }


    void Update()
    {
        
    }
}
