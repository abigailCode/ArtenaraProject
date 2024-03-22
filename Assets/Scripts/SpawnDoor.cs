using System.Collections;
using UnityEngine;

public class SpawnDoor : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] float spawnDistance = 7.0f;

    public IEnumerator SpawnObjectInFront()
    {
        while (true)
        {
            Transform cameraTransform = Camera.main.transform;
            Vector3 lookDirection = cameraTransform.forward;

            RaycastHit hit;

            if (Physics.Raycast(cameraTransform.position, lookDirection, out hit, spawnDistance))
            {
                Vector3 spawnPosition = hit.point;
                GameObject instantiatedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
                instantiatedObject.transform.LookAt(cameraTransform);
                yield break;
            }

            yield return null;
        }
    }
}
