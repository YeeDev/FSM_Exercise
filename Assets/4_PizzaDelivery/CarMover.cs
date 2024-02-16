using UnityEngine;
using PZD.Audio;

namespace PZD.Movement
{
    [RequireComponent(typeof(CarAudio))]
    public class CarMover : MonoBehaviour
    {
        [SerializeField] float speed = 5f;
        [SerializeField] float turnSpeed = 4f;

        Rigidbody rb;
        Animator animator;
        CarAudio carAudio;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
            carAudio = GetComponent<CarAudio>();
        }

        public void Move(float zAxis)
        {
            Vector3 directionalSpeed = transform.forward.normalized * zAxis * speed;
            directionalSpeed.y = rb.velocity.y;
            rb.velocity = directionalSpeed;

            animator.SetFloat("zAxis", zAxis);
            carAudio.EngineSound(Mathf.Abs(zAxis) > 0 ? Mathf.Abs(zAxis) : -1);
        }

        public void Turn(float xAxis)
        {
            transform.rotation *= Quaternion.Euler(0, xAxis * turnSpeed, 0);
        }
    }
}