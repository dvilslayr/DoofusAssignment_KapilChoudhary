using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public float SpawnTime = 5f;
    public float SpawnDelay = 2f;
    public GameObject SpawnObject;

    bool newGroundInstanciated;
    readonly List<Vector3> pos = new List<Vector3>() { new Vector3(9, 0, 0), new Vector3(-9, 0, 0), new Vector3(0, 0, 9), new Vector3(0, 0, -9) };

    private void GroundGenerator()
    {
        newGroundInstanciated = true;
        int index = Random.Range(0, pos.Capacity);
        Vector3 newpos = new Vector3(gameObject.transform.position.x + pos[index].x, 0, gameObject.transform.position.z + pos[index].z);
        Instantiate(gameObject, newpos, Quaternion.identity);
    }
    private void Beerus()         // This function is to destroy Pulpits
    {
        Destroy(this.gameObject);
    }

    private void Awake()
    {
        newGroundInstanciated = false;
    }
    private void Update()
    {
        
        if (SpawnTime > 0)
            {
                SpawnTime -= 1 * Time.deltaTime;
                
                if (!newGroundInstanciated && SpawnTime < SpawnDelay)
                {
                GroundGenerator();
                }
                if (SpawnTime <= 0)
                {
                    Beerus();
                    SpawnTime = 5f;
                }
            }

    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Destroyer")
        {
            Beerus();
        }
    }
    
   
}