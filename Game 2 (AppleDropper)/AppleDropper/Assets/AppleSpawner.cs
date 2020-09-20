using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject enemyPrefab;
    public float spawnRate;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
    void Spawn()
    {
        GameObject newEnemy = Instantiate<GameObject>(enemyPrefab);
        newEnemy.transform.position = transform.position;
        Invoke("Spawn", 1.0f);
     
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("edge"))
        {
            speed *= -1.0f;
        }
    }

}
