using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    public void Spawn()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[randomIndex], transform.position, Quaternion.identity);
    }
}
