using UnityEngine;

namespace RoboBattle
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;

        [SerializeField] private float speed = 5f;


        private void FixedUpdate()
        {
            SetSpeed();
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), SetVerticalVector(), Input.GetAxis("Vertical"));

            Move(move, 5f);
        }

        public void Move(Vector3 direction, float speed)
        {
            characterController.Move(direction * speed * Time.deltaTime);
        }

        private float SetVerticalVector()
        {
            if (Input.GetKey(KeyCode.Space)) return 1f;
            if (Input.GetKey(KeyCode.LeftControl)) return -1f;
            return 0f;
        }

        private void SetSpeed()
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 10f;
            }
            else
            {
                speed = 5f;
            }
        }
    }
}