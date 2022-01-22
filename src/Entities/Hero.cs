namespace rpg_oop.src.Entities
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public string heroType;
        public Hero(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.name+" "+this.level+" "+this.heroType;
        }
        
        public virtual string attack()
        {
            return this.name+" atacou com sua espada ";
        }
    }
}