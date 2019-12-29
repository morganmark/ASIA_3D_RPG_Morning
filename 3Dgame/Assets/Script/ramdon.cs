using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdon : MonoBehaviour
{

    public int r = -10;

    public Transform test1;
    // Start is called before the first frame update
    void Start()
    {
        print(Random.value);
        print(Mathf.PI);
        print(Mathf.Abs(r));

        test1.localPosition = new Vector3(1, 1, 1);
        test1.localScale = Vector3.one* 3;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetKeyDown(KeyCode.Space));
        wasd();
        jump();
        attack();

        test1.transform.Rotate(0, 0, 0, Space.Self);
    }

    private void wasd()
    {
        if (Input.GetAxis("Horizontal") ==1){
            print("d + >");
        }
        else if(Input.GetAxis("Horizontal") == -1){
            print("a + <");
        }
        else
        {
            print("0");
        }
        if (Input.GetAxis("Vertical") == 1)
        {
            print("w + up");
        }
        else if (Input.GetAxis("Vertical") == -1)
        {
            print("s + down");
        }
        else
        {
            print("0");
        }
    }
    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("jump");
        }
    }
    private void attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("attack");
        }
    }
    
}
