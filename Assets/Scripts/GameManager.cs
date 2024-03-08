using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int pickupsCount = 0; 
    public static GameManager instance;
    public int goal=4;
    public int phase = 0;

    void Start()
    {
        if (instance == null) instance = this;
        else { Destroy(gameObject); return; }
        DontDestroyOnLoad(gameObject);
    
    }

    public void SetCount()
    {
        pickupsCount++;
        ChangeScoreText();
        if (pickupsCount == goal) GameObject.Find("Exit").transform.GetChild(0).gameObject.SetActive(true);

    } 

    public int GetCount() {  return pickupsCount; }

    public void Finish(int goal)
    {
        this.goal = goal;
        pickupsCount = 0;
        phase++;
    }

    public void ResetState()
    {
        pickupsCount = 0;
        phase = 0;
        goal = 4;
    }

    public void ChangeScoreText()
    {
        GameObject.Find("Counter").GetComponent<TMP_Text>().text = $"{pickupsCount}/{goal}";
    }
}
