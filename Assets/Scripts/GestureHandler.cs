using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandler : MonoBehaviour, IMixedRealityGestureHandler<Vector3>
{

    [SerializeField] GameObject prefabToInstantiate;
    [SerializeField] MixedRealityInputAction actionToInstantiate = MixedRealityInputAction.None;
    [SerializeField] Transform mixedRealitySceneContent;
    GameObject instancedPrefabCopy;
    Vector3 initialPrefabCopyPosition;

    public void OnEnable()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityGestureHandler<Vector3>>(this);
    }

    public void OnDisable()
    {
        CoreServices.InputSystem?.UnregisterHandler<IMixedRealityGestureHandler<Vector3>>(this);
    }

    public void DestroyInstancedPrefab()
    {
        Debug.Log("PLEASE WORK");
        if (instancedPrefabCopy != null)
        {
            Destroy(instancedPrefabCopy);
            instancedPrefabCopy = null;
        }
    }

    public void OnGestureCanceled(InputEventData eventData)
    {
        Debug.Log("PLEASE WORK");
        if (actionToInstantiate == eventData.MixedRealityInputAction)
        {
            DestroyInstancedPrefab();
        }
    }

    public void OnGestureCompleted(InputEventData<Vector3> eventData)
    {
        Debug.Log("PLEASE WORK");
        if (actionToInstantiate == eventData.MixedRealityInputAction)
        {
            DestroyInstancedPrefab();
        }
    }

    public void OnGestureCompleted(InputEventData eventData)
    {
        Debug.Log("PLEASE WORK");
        if (actionToInstantiate == eventData.MixedRealityInputAction)
        {
            DestroyInstancedPrefab();
        }
    }

    public void OnGestureStarted(InputEventData<Vector3> eventData)
    {
        Debug.Log("PLEASE WORK");
        if (actionToInstantiate == eventData.MixedRealityInputAction && prefabToInstantiate != null)
        {
            instancedPrefabCopy = Instantiate(prefabToInstantiate);
            instancedPrefabCopy.transform.parent = mixedRealitySceneContent;
            Vector3 newPosition = Camera.main.transform.position + Camera.main.transform.forward * 2.0f;
            instancedPrefabCopy.transform.position = newPosition;
            initialPrefabCopyPosition = newPosition;
        }
    }

    public void OnGestureStarted(InputEventData eventData)
    {
        Debug.Log("PLEASE WORK");
    }

    public void OnGestureUpdated(InputEventData<Vector3> eventData)
    {
        Debug.Log("PLEASE WORK");
        if (actionToInstantiate == eventData.MixedRealityInputAction && instancedPrefabCopy != null)
        {
            instancedPrefabCopy.transform.position = initialPrefabCopyPosition + eventData.InputData;
        }
    }

    public void OnGestureUpdated(InputEventData eventData)
    {
        Debug.Log("PLEASE WORK");
    }
}
