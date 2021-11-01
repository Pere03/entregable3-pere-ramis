using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 myPosition;

    // Start is called before the first frame update
    void Start()
    {
        myPosition = new Vector3(0, 0, 0);
        transform.position = myPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += new Vector3(2, 2, 2);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation *= Quaternion.Euler(45, 0, 45);
        }

    }

}
