using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject projectile;
    float spawnCooldown;
    public Transform [] spawnPoints;
    // Find parent object put children object ino array
    // Start is called before the first frame update
    void Start()
    {
        spawnCooldown = 5;
        spawnPoints = gameObject.GetComponentsInChildren<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCooldown > 0){
            spawnCooldown -= Time.deltaTime;
        }
        else{
            Instantiate(projectile, spawnPoints[Random.Range(1,7)].transform.position, Quaternion.identity);
            spawnCooldown = Random.Range(1.0f, 3.0f); 
        }
    }
}
