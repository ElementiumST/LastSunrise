using UnityEngine;

namespace components
{
    [RequireComponent(typeof(Movable))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class UserMoveControl : MonoBehaviour
    {
        private Movable _movable;
        private Rigidbody2D _body;
        void Start()
        {
            _movable = GetComponent<Movable>();
            _body = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (_movable.canMove)
            {
                 float moveHor = Input.GetAxisRaw("Horizontal");
                 float moveVert = Input.GetAxisRaw("Vertical");
                 Vector2 move = new Vector2(moveHor, moveVert);
                 _body.MovePosition(_body.position + move * (_movable.moveSpeed * Time.deltaTime));
            }
        }
    }
}
