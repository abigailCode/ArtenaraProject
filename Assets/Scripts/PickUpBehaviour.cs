using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehaviour : MonoBehaviour
{
    public AudioClip collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (SceneController.instance.currentScene != "Victory") GameManager.instance.SetCount();
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(gameObject);
        }

    }
}
