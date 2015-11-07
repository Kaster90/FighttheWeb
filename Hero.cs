class Hero{
	private int health;
	private int baseDmg;
	private enum Attack {Hack, Ridicule, Overstock, Distort};
	
	//Attack
	public int Attack(Object[] Keywordstring, String Attack)
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
	void sethealth(int maxhealth)
	{
		this.health = maxhealth;
	}
	void setbasedmg (int dmg)
	{
		this.baseDmg = dmg;
	}
	void setmaxhealth (int )
}
