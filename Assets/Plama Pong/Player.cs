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

    public float fireTime = 1f;
    public float firePower = 100f;
    
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
            nextFireTime = Time.time + fireTime;
        }
        move();
    }

    void move()
    {
        var movement = Time.deltaTime * velocity * rb.mass * Input.GetAxis(moveAxis);
        this.rb.AddForce(new Vector2(0, movement), ForceMode2D.Impulse);
        //this.rb.velocity = new Vector2(0, movement);
    }
    void shoot()
    {
        var go = Instantiate(pushParticle, new Vector3(shootStart.position.x, shootStart.position.y, 0f), Quaternion.identity);
        var gorb = go.GetComponent<Rigidbody2D>();
        var dir =  gorb.position - rb.position;
        dir.y += Random.Range(-0.01f, .01f) * firePower ;
        //dir.Normalize();
        gorb.AddForce(dir * firePower, ForceMode2D.Impulse);

    }
}
