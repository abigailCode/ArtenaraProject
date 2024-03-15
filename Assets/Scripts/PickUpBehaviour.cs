using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
