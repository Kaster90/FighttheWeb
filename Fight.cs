class Fight{
	public string StartFight(){
		while(state == InCombat){

				//sometask as we wait for input; ////////////////has to be changed

				Enemy.gethit(Hero.Attack(object[] Keywordstring, String Attack));

				if(Enemies.alive()){
					Hero.getHit(Enemey.Attack(object[] KeywordsValue));
					if(Hero.alive()==0){
						state = GameOver;
						return state;
					}
				}
				else if(Enemies.alive()==0){
					Loot.getloot();
					state = OutofCombat;
					return state;
				}
				
		}	
	}
	
}
