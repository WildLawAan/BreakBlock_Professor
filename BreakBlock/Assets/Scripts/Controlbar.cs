using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlbar : MonoBehaviour
{
    // Start is called before the first frame update

    public int MoveSpeed = 10; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            this.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left * MoveSpeed * Time.deltaTime *-1);

        }

    }
}
