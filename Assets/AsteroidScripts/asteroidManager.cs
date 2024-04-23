using System.Collections.Generic;
using UnityEngine;

public class asteroidManager : MonoBehaviour
{
    [SerializeField] int spawnCount;
    [SerializeField] float spawnDistance = 20;
    [SerializeField] startAsteroid[] asteroidPrefabs;

    List<startAsteroid> asteroids = new();

    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0, asteroidPrefabs.Length);
            startAsteroid prefab = asteroidPrefabs[randomIndex];
            startAsteroid newAsteroid = Instantiate(prefab);
            asteroids.Add(newAsteroid);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spawnDistance;


            newAsteroid.transform.position = position;
        }
    }
    public void RemoveAsteroid(startAsteroid asteroid)
    {
        asteroids.Remove(asteroid);
        if(asteroids.Count == 0)
        {
            Debug.Log("STAGE CLEAR");
        }
    }
}
