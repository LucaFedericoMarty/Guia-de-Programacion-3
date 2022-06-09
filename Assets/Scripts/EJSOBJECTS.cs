using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJSOBJECTS : MonoBehaviour
{
    public GameObject objal0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            al0(objal0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(comprobadorY(objal0));
        }
    }

    void al0(GameObject objectTo0)
    {
        objectTo0.transform.position = Vector3.zero;
    }

    bool comprobadorY(GameObject objectY)
    {
        bool YNEGATIVA = false;

        if (objectY.transform.position.y >= 0)
        {
            YNEGATIVA = true;
        }

        return YNEGATIVA;
    }
}
