using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace components
{

    public class Movable : MonoBehaviour
    {
        [FormerlySerializedAs("Move Speed")] [SerializeField]
        public float moveSpeed = 1;
        public bool canMove = true;
        void Start()
        {
            
        }

        private void FixedUpdate()
        {
            
        }
    }
}