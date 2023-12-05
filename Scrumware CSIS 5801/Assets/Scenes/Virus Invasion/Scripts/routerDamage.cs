using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class routerDamage : MonoBehaviour

{
    public GameObject routerDamagePrefab;
    public int routerLives = 5;
    private pointManager pointManager;
   
    // Start is called before the first frame update
    void Start()
    {
         pointManager = GameObject.Find("PointManager").GetComponent<pointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy Projectile") {
            routerLives = routerLives - 1;
            Destroy(other.gameObject);
            if(routerLives == 1) {
                Instantiate(routerDamagePrefab, transform.position, Quaternion.identity);
            }
            if(routerLives == 0){
                Destroy(other.gameObject);
                Destroy(gameObject);
                pointManager.UpdateScore(-100);            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.tag == "Enemy"){
            routerLives -=1;
            
            Destroy(gameObject);
            if(routerLives == 1) {
                Instantiate(routerDamagePrefab, transform.position, Quaternion.identity);
            }
            if(routerLives == 0){
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        
    }
    
}
}
