using Meta.WitAi.Requests;
using Oculus.Voice;
using UnityEngine;

[RequireComponent(typeof(AppVoiceExperience))]  
public class VoiceListener : MonoBehaviour {
    AppVoiceExperience voiceExperience;

    void Start() {
        voiceExperience = GetComponent<AppVoiceExperience>();
        voiceExperience.VoiceEvents.OnComplete.AddListener(OnVoiceTranscription);
        voiceExperience.Activate();
    }

    void OnVoiceTranscription(VoiceServiceRequest _) {
        voiceExperience.Activate();
    }
}
