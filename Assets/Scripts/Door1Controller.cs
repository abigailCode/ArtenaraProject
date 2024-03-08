using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Controller : MonoBehaviour
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
        if (GameManager.instance.phase == 0)
        {
            GameManager.instance.Finish(8);
            SceneController.instance.LoadScene("Game2");
        }else
        {
            SceneController.instance.LoadScene("Victory");
        }
    }
}
