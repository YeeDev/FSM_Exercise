using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PZD.Audio
{
    public class CarAudio : MonoBehaviour
    {
        [SerializeField] [Range(0.8f, 1.1f)] float minPitch = 0.9f;
        [SerializeField] [Range(0.9f, 1.3f)]float maxPitch = 1.2f;
        [SerializeField] [Range(0, 1)] float pitchChangeRate = 0.5f;

        AudioSource audioSource;

        private void Awake() => audioSource = GetComponent<AudioSource>();

        public void EngineSound(float speed)
        {
            audioSource.pitch += speed * pitchChangeRate;
            audioSource.pitch = Mathf.Clamp(audioSource.pitch, minPitch, maxPitch);
        }
    }
}