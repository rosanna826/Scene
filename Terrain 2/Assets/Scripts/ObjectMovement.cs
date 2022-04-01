using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 10f;
        human.transform.position = new Vector3 (200, 103, value);
    }

    public void MoveRight()
    {
        value = value + 10f;
        human.transform.position = new Vector3 (200, 103, value);
    }

    public void MoveUp()
    {
        value = value + 10f;
        human.transform.position = new Vector3 (200, value, 81);
    }

    public void MoveDown()
    {
        value = value - 10f;
        human.transform.position = new Vector3 (200, value, 81);

    }

    public void RotateLeft()
       {
           human.transform.Rotate(20f, 20f, 0f);

       }
    
    public void GrowUp()
       {
           human.transform.localScale = human.transform.localScale + sizeChange;
       }

    public void GrowDown()
       {
           human.transform.localScale = human.transform.localScale - sizeChange;
       }


    public void Reset()
       {
            human.transform.position = new Vector3(200,103,81);
            human.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
            human.transform.localScale = new Vector3(10,10,10);

       }

}
