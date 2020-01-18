using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnClick : MonoBehaviour
{
    public GameObject ObjToEnable;
    // Start is called before the first frame update
    void Start()
    {
        ObjToEnable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ObjToEnable.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            ObjToEnable.SetActive(false);
        }
    }
}
