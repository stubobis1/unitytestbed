using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDisableRemoveParticles : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particleSys;
    void Start()
    {
        if (particleSys == null)
            particleSys = this.GetComponent<ParticleSystem>();
    }

    bool wasDisabledLast = false;
    bool wasStoppedLast = false;

    // Update is called once per frame
    void Update()
    {

        if (wasDisabledLast)
        {
            particleSys.Stop();
            //particleSys.Clear(true);
            wasDisabledLast = false;
        }
        else {
            particleSys.Play();
            //particleSys.Emit(1);

        }

    }

    private void OnDisable()
    {
        wasDisabledLast = true;
    }
}
