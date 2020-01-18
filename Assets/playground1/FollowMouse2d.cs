using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (shouldFolowMouse)
        {
            //   this.transform.position.Set(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z);
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            this.transform.position = pos;
        }
        print(Input.mousePosition);
    }

}

