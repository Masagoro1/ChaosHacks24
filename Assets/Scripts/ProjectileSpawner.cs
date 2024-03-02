using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject projectile;
    float spawnCooldown;
    // Start is called before the first frame update
    void Start()
    {
        spawnCooldown = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCooldown > 0){
            spawnCooldown -= Time.deltaTime;
        }
        else{
            Debug.Log("Instantiate");
            spawnCooldown = 3;
        }
    }
}
