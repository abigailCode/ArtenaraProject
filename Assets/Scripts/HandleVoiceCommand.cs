using UnityEngine;

public class HandleVoiceCommand : MonoBehaviour {
    [SerializeField] GameObject windowObject;
    [SerializeField] GameObject interfaceObject;

    public void HandleCommand(string[] values)
    {
        if (values[0] == "window" && values[1] == "true")
            windowObject.SetActive(true);
        else if (values[0] == "interface" && values[1] == "true")
            interfaceObject.SetActive(true);
        else if (values[0] == "window" && values[1] == "false")
            windowObject.SetActive(false);
        else if (values[0] == "interface" && values[1] == "false")
            interfaceObject.SetActive(false);
        else Debug.Log("Command not recognized");
    }
}
