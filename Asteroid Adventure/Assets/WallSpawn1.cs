using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn1 : MonoBehaviour
{
    [SerializeField]
    private GameObject wallPrefab;
    
    [SerializeField]
    private float wallInterval = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnWall(wallInterval, wallPrefab));
    }

    private IEnumerator spawnWall(float interval, GameObject wall)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(wall, new Vector3(-118, 202, 210), Quaternion.identity);
        StartCoroutine(spawnWall(interval,wall));

    }
}
