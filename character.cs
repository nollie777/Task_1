using System;

public class Hero : Character
{
	public Hero(int Xpos, int Ypos, int hp, int _maxhp, int damage = 2, char symbol = 'H') : base(X, Y, HP, maxHP)
	{

		X = Xpos;

		Y = Ypos;

		HP = hp;

		maxHP = _maxhp;

	}

	override ReturnMove()
    {
		string inputmove;

		switch (inputmove)
        {

        }
    }

	public override string ToString()
	{
		return (String.Format("Player Stats: HP: (0)/(1) Damage: (2) [(3), (4)]", HP, maxHP, X, Y, Damage));
	}
}
