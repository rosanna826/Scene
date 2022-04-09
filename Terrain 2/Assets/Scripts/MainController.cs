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
        //value = value - 1f;
        human.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        value = 1f;
        human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y, human.transform.position.z - value);

    }

    public void MoveRight()
    {
        //value = value + 1f;
        human.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
        value = 1f;
        human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y, human.transform.position.z + value);
    }

    public void MoveUp()
    {
        //value = value + 1f;
        value = 1f;
        human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y + value, human.transform.position.z);
    }

    public void MoveDown()
    {
        //value = value - 1f;
        value = 1f;
        human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y - value, human.transform.position.z);

    }

    public void RotateLeft()
       {
           human.transform.Rotate(0f, 0f, 20f);

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


    public void Update()

        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                //value = value + 1f;
                value = 1f;
                human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y + value, human.transform.position.z);
            }


               if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                //value = value - 1f;
                value = 1f;
                 human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y - value, human.transform.position.z);
            }

               if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //value = value - 1f;
                human.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
                value = 1f;
                human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y, human.transform.position.z - value);
            }

               if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                //value = value + 1f;
                human.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
                value = 1f;
                human.transform.position = new Vector3 (human.transform.position.x, human.transform.position.y, human.transform.position.z + value);
            }

                 if(Input.GetKeyDown(KeyCode.KeypadPlus))
            {
                human.transform.localScale = human.transform.localScale + sizeChange;
            }

               if(Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                human.transform.localScale = human.transform.localScale - sizeChange;
            }

               if(Input.GetKeyDown(KeyCode.Space))
            {
                 human.transform.Rotate(0f, 0f, 20f);

            }

                if(Input.GetKeyDown(KeyCode.Backspace))
            {
                human.transform.position = new Vector3(0,0,0);
                human.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
                human.transform.localScale = new Vector3(1,1,1);


            }


        }



}