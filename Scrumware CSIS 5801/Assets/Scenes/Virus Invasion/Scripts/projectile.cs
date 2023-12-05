using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionPrefab;
    private pointManager pointManager;
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<pointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            
            Destroy(gameObject);
            pointManager.UpdateScore(50);
        }
        if(other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
            
        }
    }
}
