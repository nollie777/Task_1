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

	public int getWidth
	{
		get { return width; }
		set { width = value; }
	}

	public int getHeight
	{
		get { return height; }
		set { heightt = value; }
	}

	public Enemy[] getEnemies
	{
		get { return enemies; }
		set { enemies = value; }
	}

	public Main(int minWidth, int maxWidth, int maxHeight, int minHeight)
	{

		width = rando.Next(minWidth, maxWidth);

		height = rando.Next(minHeight, maxHeight);

		char[,] Tile = new Tile[width, height];

		Enemy[] enemies = new enemies[width, height];

		

	}

	private Tile Create(TileEnum type)
    {

		X = rando.Next(minWidth, maxWdith);

		Y = rando.Next(minHeight, maxHeight);



    }

}








