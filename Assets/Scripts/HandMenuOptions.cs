using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuOptions : MonoBehaviour
{
    public GameObject prefabSelected;

    public void ShowPrefab()
    {
        prefabSelected.SetActive(true);
    }

    public void HidePrefab()
    {
        prefabSelected.SetActive(false);
    }

    public void AnimatePrefab()
    {
        prefabSelected.GetComponent<Animator>().enabled = !prefabSelected.GetComponent<Animator>().enabled;
    }

    public void RotatePrefab(int direction)
    {

        prefabSelected.transform.Rotate(0, 45*direction, 0);
    }
}
