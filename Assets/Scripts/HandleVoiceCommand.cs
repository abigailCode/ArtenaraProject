using UnityEngine;

public class HandleVoiceCommand : MonoBehaviour {
    [SerializeField] GameObject windowObject;
    [SerializeField] GameObject interfaceObject;

    public void HandleCommand(string[] values)
    {
        Debug.Log("Command received: " + values[0] + " " + values[1]);
        if (values[0] == "window" && values[1] == "true")
        {

       
            Debug.Log("Window is true");
            windowObject.SetActive(true);
        }
        else if (values[0] == "interface" && values[1] == "true")
        {
            Debug.Log("Interface is true");
            interfaceObject.SetActive(true);
        }
        else if (values[0] == "window" && values[1] == "false")
        {
            Debug.Log("Windows is false");
            windowObject.SetActive(false);
        }
        else if (values[0] == "interface" && values[1] == "false"){
            Debug.Log("Interface is false");
            interfaceObject.SetActive(false);
        }
        else Debug.Log("Command not recognized");
    }
}
