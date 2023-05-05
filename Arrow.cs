using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    //variable for arrow's speed
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //destroy arrow in 5 sec
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //arrow flies up (regarding its own transform)
        transform.position += speed * transform.up * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // find component Ememy in the one touching you, if you do - make them take damage
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage();
        }
        // and destroy arrow
        Destroy(gameObject);
    }

}
