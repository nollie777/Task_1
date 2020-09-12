using System;

abstract class Enemy : Character 
{
	public Enemy(int xPos,int yPos, int Damage, int hp,int _maxHP, char symbol) : base(xPos, yPos ,symbol)
	{

		HP = hp;

		damage = Damage;

		maxHP = _maxHP;

	}

	protected Random rando = new Random(); 

	public override string ToString()
	{
		return (String.Format("(0) at [(1), (2)] ((3))", this.GetType().Name, X, Y, Damage));
	}
}

class Goblin : Enemy
{
	public Goblin(int Xpos, int Ypos, int damage = 1, int hp = 10, char symbol = 'G') : base(X, Y, HP, symbol)
    {

		X = Xpos;
		Y = Ypos;
		
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
}
