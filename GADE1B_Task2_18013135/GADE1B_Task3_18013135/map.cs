using System;

namespace GADE1B_Task3_18013135
{
    class map
    {
        //CLASS VARIABLES
        char[,] arrMap = new char[20, 20];
        public Unit[] ArrUnits;

        int sumUnits;

        //CLASS CONSTRUCTORS
        public map(int _sumUnits)
        {
            sumUnits = _sumUnits;
        }

        //CLASS METHODS
        public void RandomBattlefield()
        {
            int randomX, randomY;


            ArrUnits = new Unit[sumUnits];
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                for (int k = 0; k < 20; k++)
                {
                    arrMap[i, k] = ',';

                }

            }

            for (int i = 0; i < sumUnits; i++)
            {


                randomX = rnd.Next(0, 20);
                randomY = rnd.Next(0, 20);

                int random;
                random = rnd.Next(1, 5);

                if (random == 1)
                {


                    MeleeUnits Unit = new MeleeUnits(randomX, randomY, 100, 1, 5, 1, "Team1", 'X', false);
                    arrMap[Unit.xPos, Unit.yPos] = Unit.symbol;
                    ArrUnits[i] = Unit;

                }
                else if (random == 2)
                {
                    MeleeUnits Unit = new MeleeUnits(randomX, randomY, 100, 1, 5, 1, "Team2", 'x', false);
                    arrMap[Unit.xPos, Unit.yPos] = Unit.symbol;
                    ArrUnits[i] = Unit;
                }
                else if (random == 3)
                {
                    RangedUnits Unit = new RangedUnits(randomX, randomY, 80, 1, 3, 1, "Team1", 'O', false);
                    arrMap[Unit.xPos, Unit.yPos] = Unit.symbol;
                    ArrUnits[i] = Unit;
                }
                else
                {
                    RangedUnits Unit = new RangedUnits(randomX, randomY, 80, 1, 3, 1, "Team2", 'o', false);
                    arrMap[Unit.xPos, Unit.yPos] = Unit.symbol;
                    ArrUnits[i] = Unit;
                }




            }



        }


        public string MapDisplay()
        {
            string mapString;
            mapString = " ";

            for (int i = 0; i < 20; i++)
            {
                for (int k = 0; k < 20; k++)
                {
                    mapString = mapString + arrMap[i, k];
                }
                mapString += "\n";

            }



            return mapString;

        }

        public void MapUpdate(Unit unitMove, int xOld, int yOld)
        {
            string unitType = unitMove.GetType().ToString();
            string[] Type = unitType.Split('.');
            unitType = Type[Type.Length - 1];

            if (unitType == "MeleeUnit")
            {

                MeleeUnits un = (MeleeUnits)unitMove;
                arrMap[xOld, yOld] = ',';

                arrMap[un.xPos, un.yPos] = un.symbol;

            }
            if (unitType == "RangedUnit")
            {

                RangedUnits un = (RangedUnits)unitMove;
                arrMap[xOld, yOld] = ',';

                arrMap[un.xPos, un.yPos] = un.symbol;
            }
        }
    }
}

