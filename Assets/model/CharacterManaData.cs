namespace model
{
    public class CharacterManaData
    {
        private float _manaPoints;
        private float _manaRegeneration;
        private int _maxManaPoints;

        public CharacterManaData(float manaRegeneration, int maxManaPoints)
        {
            _manaRegeneration = manaRegeneration;
            _maxManaPoints = maxManaPoints;
            _manaPoints = maxManaPoints;
        }
    }
}