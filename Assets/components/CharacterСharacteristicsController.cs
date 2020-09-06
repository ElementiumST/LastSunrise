using model;
using UnityEngine;
using UnityEngine.Serialization;

namespace components
{
    public class CharacterСharacteristicsController : MonoBehaviour
    {
        [FormerlySerializedAs("Health data")] [SerializeField] 
        private CharacterHealthData healthData;

        [SerializeField] private int _health;
        [SerializeField] private int _healthRegeneration;

        private void Start()
        {
            healthData = new CharacterHealthData(_health, _healthRegeneration);
        }

        private void Update()
        {
            healthData.Regenerate(Time.deltaTime);   
        }

        public CharacterHealthData HealthData
        {
            get => healthData;
        }
    }
}