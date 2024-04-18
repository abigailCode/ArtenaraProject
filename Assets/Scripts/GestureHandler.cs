using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandler : MonoBehaviour, IMixedRealityGestureHandler<Vector3>
{
    void OnEnable()
    {
        CoreServices.InputSystem?.RegisterHandler<IMixedRealityGestureHandler<Vector3>>(this);
    }

    public void OnGestureCompleted(InputEventData<Vector3> eventData)
    {

    }

    void IMixedRealityGestureHandler<Vector3>.OnGestureUpdated(InputEventData<Vector3> eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMixedRealityGestureHandler<Vector3>.OnGestureCompleted(InputEventData<Vector3> eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMixedRealityGestureHandler.OnGestureStarted(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMixedRealityGestureHandler.OnGestureUpdated(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMixedRealityGestureHandler.OnGestureCompleted(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void IMixedRealityGestureHandler.OnGestureCanceled(InputEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
