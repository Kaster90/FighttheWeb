public static class AttackBonus{
	
	private AttackBonus(){}
	public static int calculateBonus(Object[] Keywordstring, String Attack){
		private int Bonus = 0;
		private int Bonussum = 0;
		for(int i=0
		; i<=3; i++)
		{
			switch (Keywordstring[i].getString())
			{
				case Adult:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus =10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Arts:
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 5;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Business:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 10;
					break;
					case Distort:
					Bonus =10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Computers:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 10;
					break;
					case Distort:
					Bonus = 0;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Games:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 0;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Health:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Home:			
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 10;
					break;
					case Distort:
					Bonus = 0;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case News:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Recreation:
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 0;
					break;
				}
				return Bonus
				
				case Reference:
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Regional:
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Science:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Shopping:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 10;
					break;
					case Distort:
					Bonus =10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Society:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case Sports:
				switch (Attack){
					case Hack:
					Bonus = 0;
					break;
					case Ridicule:
					Bonus = 10;
					break;
					case Overstock:
					Bonus = 10;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;
				
				case World:
				switch (Attack){
					case Hack:
					Bonus = 10;
					break;
					case Ridicule:
					Bonus = 0;
					break;
					case Overstock:
					Bonus = 0;
					break;
					case Distort:
					Bonus = 10;
					break;
				}
				Bonussum=Bonussum+Bonus;
				break;

				
				
			}
		}
		return Bonussum;
	}
}
