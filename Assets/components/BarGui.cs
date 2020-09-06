using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace components
{
    [RequireComponent(typeof(CharacterСharacteristicsController))]
    public class BarGui : MonoBehaviour
    {
        private CharacterСharacteristicsController _characteristics;
        [FormerlySerializedAs("Chosen bar")] [SerializeField]
        private GameObject bar;

        public float PercentFactor = 0;
        private void Start()
        {
            _characteristics = GetComponent<CharacterСharacteristicsController>();
        }

        private void OnGUI()
        {
            if(bar == null) return;
            bar.transform.localScale = new Vector3(_characteristics.HealthData.GetHealthPercent(), 1, 1);
            bar.transform.localPosition = new Vector3( 
                _characteristics.HealthData.GetHealthPercent()*PercentFactor-PercentFactor
                , 0, 0);
        }
    }
}