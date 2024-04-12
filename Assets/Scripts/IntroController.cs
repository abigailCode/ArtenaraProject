using UnityEngine;

public class IntroController : MonoBehaviour {
    [SerializeField] GameObject[] texts;
    int index = 0;

    void Start() {
        AudioManager.instance.PlayMusic("intro");
        texts[index].SetActive(true);
    }

    public void ShowNext() {
        texts[index].SetActive(false);
        if (index == 2) index = 0;
        texts[++index].SetActive(true);
    }

    public void ShowPrev() {
        texts[index].SetActive(false);
        if (index == 0) index = 2;
        texts[--index].SetActive(true);
    }

    public void GoToMenu()
    {
        SceneController.instance.LoadScene("Menu");
    }
}
