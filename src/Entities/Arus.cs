namespace rpg_oop
{
    public class Arus
    {
        public string name;
        public int level;
        public string heroType;
        public Arus(string name, int level, string heroType){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string ToString()
        {
            return this.name+" "+this.level+" "+this.heroType;
        }
    }
}