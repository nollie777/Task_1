using System;

public class Map
{
	public Map()
	{



	}

	private char[,] Tile;

	Hero Player = new Hero();

	private Enemy[] enemies = new Enemy[];

	private int widht = new int();

	private int height = new int();

	private Random rando = new Random();

	public char[,] getTile
	{
		get { return Tile; }
		set { Tile = value; }
	}
}
