using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace components
{
    public class Health : MonoBehaviour
    {
        [FormerlySerializedAs("Max Health Point")] [SerializeField] 
        private int maxHealthPoint;

        private float _health;
        
        [FormerlySerializedAs("Regeneration")] [SerializeField] 
        private float regeneration;

        public void Heal(float value)
        {
            if (value + _health > maxHealthPoint)
            {
                _health = maxHealthPoint;
            }
            else
            {
                _health += value;
            }
        }

        public bool IsFullHp() => Math.Abs(_health - maxHealthPoint) > 0;

        public void Damage(float value)
        {
            if (value > _health)
            {
                // TODO on death event
            }
            else
            {
                _health -= value;
            }
        }

        private void Start()
        {
            _health = maxHealthPoint;
        }

        private void FixedUpdate()
        {
            _health += regeneration * Time.deltaTime;
        }
    }
}