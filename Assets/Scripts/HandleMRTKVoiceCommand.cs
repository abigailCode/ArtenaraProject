using UnityEngine;

public class HandleMRTKVoiceCommand : MonoBehaviour {
    [SerializeField] GameObject windowObject;
    [SerializeField] GameObject interfaceObject;

    public void ShowWindow()
    {
        windowObject.SetActive(true);
    }

    public void HideWindow()
    {
        windowObject.SetActive(false);
    }

    public void ShowInterface()
    {
        interfaceObject.SetActive(true);
    }

    public void HideInterface()
    {
        interfaceObject.SetActive(false);
    }
}
