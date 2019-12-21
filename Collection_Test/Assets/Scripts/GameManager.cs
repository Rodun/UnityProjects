using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<string, string> Login_Dictionary;

    void Start()
    {
        Login_Dictionary = new Dictionary<string, string>();
        Login_Dictionary.Add("홍길동", "12341234");
        Login_Dictionary.Add("이순신", "Abcd234");
        Login_Dictionary.Add("유관순", "1234Power");
        
        foreach(KeyValuePair<string, string> keyValuePair in Login_Dictionary)
        {
            Debug.Log("ID: " + keyValuePair.Key + " PW: " + keyValuePair.Value);
        }

        Debug.Log(Login_Dictionary.ContainsKey("이순신"));
        Debug.Log(Login_Dictionary.ContainsKey("세종대왕"));

        Login_Dictionary.ContainsValue("12341234");
    }


    void Update()
    {
        
    }
}
