using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
        [SerializeField] Transform hand;


        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            RotateHand();
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.Q))
            {
                dir.x = -1;
                animator.SetFloat("Direction", 3f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetFloat("Direction", 2f);
            }

            if (Input.GetKey(KeyCode.Z))
            {
                dir.y = 1;
                animator.SetFloat("Direction", 1f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetFloat("Direction", 0f);
            }

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
        void RotateHand()
        {
            float angle = Utility.AngleTowardsMouse(hand.position);
            hand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        }
    }
}
