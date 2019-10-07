namespace GADE1B_Task3_18013135
{
    abstract class Buildings
    {
        protected int xPos, yPos, HP, maxHP;
        protected string team;
        protected char symbol;

        public Buildings(int _xPos, int _yPos, int _HP, int _MaxHP, string _team, char _symbol)
        {
            xPos = _xPos;
            yPos = _yPos;
            HP = _HP;
            maxHP = _MaxHP;
            team = _team;
            symbol = _symbol;
        }

        public abstract bool Death();
        public abstract string ToString();
    }
}
