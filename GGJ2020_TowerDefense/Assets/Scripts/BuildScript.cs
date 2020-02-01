using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    public bool ACTIVE;
    void Start()
    {
        ACTIVE = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (ACTIVE)
            {
                ACTIVE = false;
            }
            else
            {
                ACTIVE = true;
            }
        }

        if (ACTIVE == false)
        {
            if (gameObject.activeInHierarchy)
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
        }
    }


}
