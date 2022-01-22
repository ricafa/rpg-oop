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
        public override string attack(){
            return this.name + " atacou com magia.";
        }
    }
}