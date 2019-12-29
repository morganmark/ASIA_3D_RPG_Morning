using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;
public class player : MonoBehaviour
{

    [Header("動畫參數")]
    public string RunCheck = "RunCheck";
    public string JumpCheck = "JumpCheck";
    public string AtkCount = "AtkCount";
    public string DamageCount = "DamageCount";
    public string DeadCheck = "DeadCheck";

    public int HP = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    public int AC = 0;//attack counter
    public float attack = 10;
    // Update is called once per frame
    void Update()
    {
        if(AC >= 150)
        {
            attack = 2.0f*attack;
        }else if(AC >=100){
            attack = 1.5f*attack;
        }else if(AC >=50){
            attack = 1.2f * attack;
        }
        else{

        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
        }
    }
    //public class Keyevent
}