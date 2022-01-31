namespace Abstraido_jogorpg
{
public class Hero
    {
        public Hero(string name, int Level, string HeroType){
            this. Name = Name;
            this. Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){
            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;  
        }
        public virtual string Attack(){
            return this.Name + "Lançou Magia com bonus de ataque de + Bonus";
        }
    }
}
