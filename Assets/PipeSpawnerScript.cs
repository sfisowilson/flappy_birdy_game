using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2;
    private float SpawnDelay;
    public float spawnOffset = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnDelay < SpawnRate)
        {
            SpawnDelay = SpawnDelay + Time.deltaTime;
        }
        else
        {
            SpawnPipes();
            SpawnDelay = 0;
        }
    }

    private void SpawnPipes()
    {
        if (Pipe != null)
        {
            var highestPoint = transform.position.y + spawnOffset;
            var lowestPoint = transform.position.y - spawnOffset;
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
    }
}
