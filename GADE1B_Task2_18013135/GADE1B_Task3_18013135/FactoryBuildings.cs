using System;
namespace GADE1B_Task3_18013135
{
    class FactoryBuildings : Buildings
    {

        public int xPos { get { return base.xPos; } set { base.xPos = value; } }
        public int yPos { get { return base.yPos; } set { base.yPos = value; } }
        public int HP { get { return base.HP; } set { base.HP = value; } }
        public int maxHP { get { return base.maxHP; } set { base.maxHP = value; } }
        public string team { get { return base.team; } }
        public char symbol { get { return base.symbol; } }


        public FactoryBuildings(int _xPos, int _yPos, int _HP, int _MaxHP, string _team, char _symbol) : base(_xPos, _yPos, _HP, _MaxHP, _team, _symbol)
        {

        }

        public override bool Death()
        {
            bool dead;

            if (this.HP <= 0)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }

            return dead;
        }
        public override string ToString()
        {
            string output = "";
            output = "Factory" + "\n" + "Health Points : " + this.HP + "\n" + "X-Position : " + this.xPos + "\n" + "Y-Position" + this.yPos;
            return output;
        }
    }
}
