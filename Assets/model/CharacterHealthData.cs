namespace model
{
    public class CharacterHealthData
    {
        private int _maxHealthPoints;
        private float _healthPoints;
        private float _regenerationSpeed;

        public CharacterHealthData(int maxHealthPoints, int regenerationSpeed)
        {
            _maxHealthPoints = maxHealthPoints;
            _regenerationSpeed = regenerationSpeed;
            _healthPoints = 1;
        }

        public void AddHealthRegeneration(float value)
        {
            _regenerationSpeed += value;
        }
        /// <summary>
        /// Добавляет к регенирации здоровья значение, равное проценту от текущий регенирации
        /// </summary>
        /// <param name="percent">Значение процента в виде 0.1(10%), 0.2(20%), 0.5(50%), -0.12(-12%) и т.д.</param>
        public void AddHealthRegenerationPercent(int percent)
        {
            _regenerationSpeed += _regenerationSpeed * percent;
        }
    
        /// <summary>
        /// Возвращает процент от здоровья персонажа
        /// </summary>
        /// <returns>число, обозначающее процент от здоровья персонажа</returns>
        public float GetHealthPercent()
        {
            return _healthPoints / _maxHealthPoints;
        }
        public void AddMaxHealth(int value)
        {
            _maxHealthPoints += value;
        }

        public void Heal(float value)
        {
            if (_healthPoints + value >= _maxHealthPoints)
                _healthPoints = _maxHealthPoints;
            else
                _healthPoints += value;
        }

        public void Regenerate(float deltaTime)
        {
            Heal(_regenerationSpeed*deltaTime);
        }
    }
}