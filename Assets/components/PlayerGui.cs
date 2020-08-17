using System;
using UnityEngine;
using UnityEngine.UI;

namespace components
{
    [RequireComponent(typeof(CharacterСharacteristicsController))]
    public class PlayerGui : MonoBehaviour
    {
        private CharacterСharacteristicsController _characteristics;
        private GameObject _healthBar;
        public float PercentFactor = 50;
        public float PercentSurcharge = 90;
        public bool ReloadHP = false;
        private void Start()
        {
            _healthBar = GameObject.Find("HealthBar");
            _characteristics = GetComponent<CharacterСharacteristicsController>();

        }

        private void OnGUI()
        {
            if (ReloadHP)
            {
                _characteristics.HealthData.Heal(-20);
                ReloadHP = false;
            }
            
            _healthBar.transform.localScale = new Vector3(_characteristics.HealthData.GetHealthPercent(), 1, 1);
            _healthBar.transform.localPosition = new Vector3( 
                _characteristics.HealthData.GetHealthPercent()*PercentFactor+PercentSurcharge
                , 0, 0);
        }
    }
}