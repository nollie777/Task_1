using System;

public class Hero : Character
{
	public Hero(int Xpos, int Ypos, int hp, int _maxhp, int damage = 2, char symbol = 'H') : base(X, Y, HP, symbol)
	{

		X = Xpos;
		Y = Ypos;

		HP = hp;

		maxHP = _maxhp;


	}

	override ReturnMove()
	{

		int randmove;

		randmove = rando.Next(0, 5);

		switch (randmove)
		{
			case 0:
				return movement.none;
				break;

			case 1:
				return movement.up;
				break;

			case 2:
				return movement.down;
				break;

			case 3:
				return movement.left;
				break;

			case 4:
				return movement.right;
				break;
		}

	}

	public override string ToString()
	{
		return (String.Format("Player Stats: HP: (0)/(1) Damage: (2) [(3), (4)]", HP, maxHP, X, Y, Damage));
	}
}
