using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private GameObject spawnPoint;

    public void Spawn()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[randomIndex], spawnPoint.transform.position, Quaternion.identity);
    }
}
