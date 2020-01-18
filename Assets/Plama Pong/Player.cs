using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string moveAxis;
    public string shootButton;
    public float velocity;

    public Transform shootStart;
    public GameObject pushParticle;
    public Rigidbody2D rb;

    public float FireTime = 1f;
    
    void Start()
    {
        if (this.rb == null)
            this.rb = GetComponent<Rigidbody2D>();
        nextFireTime = Time.time;
    }


    float nextFireTime;
    void Update()
    {

        if (Input.GetButton(shootButton) && Time.time > nextFireTime)
        {
            shoot();
            nextFireTime = Time.time + FireTime;
        }
        move();
    }

    void move()
    {
        var movement = Time.deltaTime * velocity * Input.GetAxis(moveAxis);
        this.rb.AddForce(new Vector2(0, movement), ForceMode2D.Impulse);
    }
    void shoot()
    {
        var go = Instantiate(pushParticle, new Vector3(shootStart.position.x, shootStart.position.y, 0f), Quaternion.identity);
        var gorb = go.GetComponent<Rigidbody2D>();
        var dir =  gorb.position - rb.position;
        //dir.Normalize();
        gorb.AddForce(dir * 1f, ForceMode2D.Impulse);

    }
}
