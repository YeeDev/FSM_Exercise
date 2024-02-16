using UnityEngine;

namespace PZ.Controls
{
    public class CarControl : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float turnSpeed;

        Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetButton("Vertical"))
            { transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Horizontal") * turnSpeed, 0); }
        }

        private void FixedUpdate()
        {
            Vector3 directionalSpeed = transform.forward.normalized * Input.GetAxis("Vertical") * speed;
            rb.velocity = directionalSpeed;
        }
    }
}