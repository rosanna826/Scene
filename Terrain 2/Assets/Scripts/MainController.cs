using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 1f;
        human.transform.position = new Vector3 (0, 0, value);
    }

    public void MoveRight()
    {
        value = value + 1f;
        human.transform.position = new Vector3 (0, 0, value);
    }

    public void MoveUp()
    {
        value = value + 1f;
        human.transform.position = new Vector3 (0, value, 0);
    }

    public void MoveDown()
    {
        value = value - 1f;
        human.transform.position = new Vector3 (0, value, 0);

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
            human.transform.position = new Vector3(0,0,0);
            human.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
            human.transform.localScale = new Vector3(1,1,1);

       }

}
