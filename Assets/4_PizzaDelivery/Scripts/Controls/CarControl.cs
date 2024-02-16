using UnityEngine;
using PZD.Movement;

namespace PZD.Controls
{
    [RequireComponent(typeof(CarMover))]
    public class CarControl : MonoBehaviour
    {
        float xAxis, zAxis;
        CarMover carMover;

        private void Awake() => carMover = GetComponent<CarMover>();

        private void Update()
        {
            ReadInput();
            Turn();
        }

        private void Turn()
        {
            if (Mathf.Abs(zAxis) > Mathf.Epsilon) { carMover.Turn(xAxis); }
        }

        private void FixedUpdate() => carMover.Move(zAxis);

        private void ReadInput()
        {
            xAxis = Input.GetAxis("Horizontal");
            zAxis = Input.GetAxis("Vertical");
        }
    }
}