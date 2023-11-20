using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class routerDamage : MonoBehaviour

{
    public GameObject routerDamagePrefab;
    public int routerLives = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.gameObject.tag == "Enemy" || other.collider.gameObject.tag == "Projectile"){
            routerLives -=1;
            if(other.collider.gameObject.tag == "Enemy"){
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
}
