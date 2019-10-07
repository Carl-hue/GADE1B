namespace GADE1B_Task3_18013135
{
    abstract class Unit
    {
        protected int xPos, yPos, HP, maxHP, speed, attack, attackRange;
        protected string team;
        protected char symbol;
        protected bool isAttacking;

        public Unit(int _xPos, int _yPos, int _HP, int _speed, int _attack, int _attackRange, string _team, char _symbol, bool _isAttacking)
        {
            xPos = _xPos;
            yPos = _yPos;
            HP = _HP;
            maxHP = HP;
            speed = _speed;
            attack = _attack;
            attackRange = _attackRange;
            team = _team;
            symbol = _symbol;
            isAttacking = _isAttacking;

        }

        public abstract void Move(string direction);
        public abstract void Combat(Unit Enemy);
        public abstract void AttackRange(Unit Enemy);
        public abstract Unit ClosestUnit(Unit[] units);
        public abstract bool Death();
        public abstract string ToString();
    }
}
