using UnityEngine;

public class HandleVoiceCommandWitAI : MonoBehaviour {
    [SerializeField] GameObject logoObject;
    [SerializeField] GameObject roombaObject;

    public void HandleCommand(string[] values)
    {
        Debug.Log("Command received: " + values[0]);
        if (values[0] == "LOGO" ) {
            Debug.Log("LOGO is true");
            logoObject.SetActive(true);
        } else if (values[0] == "RUMBA") {
            Debug.Log("ROOMBA is true");
            roombaObject.SetActive(true);
        } else if (values[0] == "GO" ) {
            Debug.Log("roomba is false");
            roombaObject.SetActive(false);
        }else Debug.Log("Command not recognized");
    }

    public void ShowPenguin()
    {
        logoObject.SetActive(true);
    }

    public void HidePenguin()
    {
        logoObject.SetActive(false);
    }
}
