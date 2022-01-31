public class Arus
    {
        public Arus(string name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Arus(){
            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public  override string  ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;  
        }
        public string Attack(){
            return this.Name + "Atacou com sua espada";
        }
    }
