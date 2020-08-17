using model;
using UnityEngine;
using UnityEngine.Serialization;

namespace components
{
    public class CharacterСharacteristicsController : MonoBehaviour
    {
        [FormerlySerializedAs("Health data")] [SerializeField] 
        private CharacterHealthData healthData;

        private void Start()
        {
            healthData = new CharacterHealthData(20, 4);
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