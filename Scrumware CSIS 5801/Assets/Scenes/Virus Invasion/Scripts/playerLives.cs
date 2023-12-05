using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int lives = 1;
    private pointManager pointManager;
    void Start()
    {
         pointManager = GameObject.Find("PointManager").GetComponent<pointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.tag == "Enemy"){
            Destroy(other.collider.gameObject);
            lives -= 1;
            if (lives <= 0){
                Destroy(gameObject);
                pointManager.UpdateScore(-100);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Enemy Projectile"){
            Destroy(collision.gameObject);
            lives -= 1;
            if (lives <= 0){
                Destroy(gameObject);
                pointManager.UpdateScore(-100);
            }

        }
        
    }
}
