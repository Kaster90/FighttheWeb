class Enemies{
	private int health;
	private int damage;
	

	//Attack	
	public int Attack(object[] KeywordsValue)
	{
		Random r = new Random();
		int k = r.Next(1,5);
		if (k<1)
		{
			this.damage = KeywordsValue[0].getInt();
		}
		else if(k<2)
		{
			this.damage = KeywordsValue[1].getInt();
		}
		else if(k<3)
		{
			this.damage = KeywordsValue[2].getInt();
		}
		else
		{
			this.damage = KeywordsValue[3].getInt();
		}
		return this.damage;
	}
	
	//get hit
		void gethit(int dmg){
		this.health = this.health-dmg;	
	}
	
	
	
	//setter
		void sethealth(int TrustFlowVal){
		this.health = TrustFlowVal;
	}
	
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

	
	
	
	
	
