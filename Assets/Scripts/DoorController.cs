using System.Collections;
using UnityEngine;

public class DoorController : MonoBehaviour {

    void Start() {
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound() {
        yield return new WaitForSeconds(1);

        GetComponent<AudioSource>().mute = false;
        GetComponent<AudioSource>().Play();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name != "Player") return;
        ChangeScene();
    }

    public void ChangeScene() {
        if (GameManager.instance.phase == 0) {
            SceneController.instance.LoadScene("Game2");
            GameManager.instance.Finish(12);
        }
        else {
            SceneController.instance.LoadScene("Victory");
        }
        Destroy(gameObject);
    }
}
