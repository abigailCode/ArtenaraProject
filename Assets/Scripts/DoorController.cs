using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player") return;
        if (GameManager.instance.phase == 0)
        {
            GameManager.instance.Finish(12);
            SceneController.instance.LoadScene("Game2");
        }else
        {
            SceneController.instance.LoadScene("Victory");
        }
    }
}
