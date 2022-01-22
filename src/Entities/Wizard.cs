namespace rpg_oop.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard()
        {
        }

        public Wizard(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }
        public string attack(int bonus){
            if(bonus>6)
            {
                return this.name + " lançou magia super efetiva com bonus de "+bonus;
            }
            else
            {
                return this.name + " lançou magia com força fraca de "+bonus;
            }
        }
    }
}