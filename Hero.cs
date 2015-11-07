class Hero{
	private int health = 100;
	private int maxhealth = 100;
	private int baseDmg;
	private enum Attack {Hack, Ridicule, Overstock, Distort};
	
	//Attack
	public int Attack(object[] Keywordstring, String Attack)
	{
			int attackDmg= this.baseDmg;
			attackDmg = attackDmg+AttackBonus.calculateBonus(Keywordstring, Attack);
			return attackDmg;
	}
	
	
	//get hit
	void gethit(int dmg)
	{
		this.health = this.health-dmg;
	}
	
	//setter
	void sethealth(int newhealth)
	{
		this.health = newhealth;
	}
	void setbasedmg (int dmg)
	{
		this.baseDmg = dmg;
	}
	void setmaxhealth (int )

	//getter
	int gethealth()
	{
		return health;
	}
	
	bool alive()
	{
		if (gethealth()<0)
			return 0;
		else
			return 1;
	}
	
}

