using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("MIUAUUUUU with " + other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            GameManager.instance.SetCount();
            Destroy(gameObject);
        }

    }
}
