using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour {
    private float startTime;
    private float remainingTime = 160f; // Set initial time to 60 seconds (1 minute)
    private bool timerRunning = true;

    void Start() {
        startTime = Time.time;
    }

    void Update() {
        if (timerRunning) {
            remainingTime -= Time.deltaTime; // Decrement remaining time by deltaTime

            if (remainingTime <= 0) {
                remainingTime = 0; // Ensure timer doesn't go negative
                timerRunning = false; // Stop timer when it reaches 0
                SceneController.instance.LoadScene("GameOver");
            }

            string minutes = ((int)remainingTime / 60).ToString("00");
            string seconds = (remainingTime % 60).ToString("00");

            GetComponent<TMP_Text>().text = minutes + ":" + seconds;
        }
    }

    public void StopTimer() {
        timerRunning = false;
    }
}
