using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

    public int car_count = 3;
    public float car_f = 10.2f ;
    public bool car_bool = true ;
    private int car1 = 12;
    public int[] student = { 1, 2, 3, 4 };
    private int i;


    public void main()
    {
        Debug.Log(student[2]);

    }



    private void Start()
    {
        print(car_count);
        print(car_f);
        print("What happened!");
    }



    private void Update()
    {
        car_count += 1;
        Fuck(car_count);

        //chance(10, "幹!");
        //chance(20, "靠!", 2.222f);

        chance(1 , "2" , 3f , 4f);
        chance(1, "2", 4f);
        chance(1, "2", d:4f);

        Text(1);

    }


    public void Fuck(int count)
    {
        //car_count += 1;
        print("Fuck count:" + count);
        print("1" + 2 + 3 + 4);
        print("1" + 2 + 4);
        
    }


    public void chance(int a, string b , float c = 10.0f, float d = 9.99f)
    {
        print(a + "|"+ b + "|"+ c+ "|"+ d);
    }


    public int Text(int s)
    {
        return s;
    }
}
