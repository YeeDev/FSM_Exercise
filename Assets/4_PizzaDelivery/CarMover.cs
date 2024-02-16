using UnityEngine;

namespace PZD.Movement
{
    public class CarMover : MonoBehaviour
    {
        [SerializeField] float speed = 5f;
        [SerializeField] float turnSpeed = 4f;

        Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Move(float zAxis)
        {
            Vector3 directionalSpeed = transform.forward.normalized * zAxis * speed;
            directionalSpeed.y = rb.velocity.y;
            rb.velocity = directionalSpeed;
        }

        public void Turn(float xAxis)
        {
            transform.rotation *= Quaternion.Euler(0, xAxis * turnSpeed, 0);
        }
    }
}