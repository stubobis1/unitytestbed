using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnEmissionEnd : MonoBehaviour
{
    public ParticleSystem partSys;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        //not working
        //if (obj == null)
        //    obj = this.GetComponentInParent<GameObject>();

        if (partSys == null)
            partSys = this.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!partSys.isPlaying)
            Destroy(obj);

    }
}
