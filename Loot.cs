public class Loot
	{
		public int healthpotion =25;
		public int incHealth = 20;
		public int incdmg =10;
		
		void getloot(object Website){
			int lootfactor = Website.getInt();
			Random r = new Random();
			int k = r.Next(1,101);
			int j = r.Next(1,4);
			if (lootfactor>k)
			{
				if(j==1)
				{
					//health potion
					Hero.sethealth(Hero.gethealth()+healthpotion);
				}
				else if(j==2)
				{
					//max health (heart)
					Hero.setmaxhealth (Hero.getmaxhealth()+incHealth);
				}
				else if(j==3)
				{
					//weapon
					Hero.setbaseDmg(Hero.getbaseDmg()+incdmg);
				}
			
			}
			

		}
}
