namespace Abstraido_jogorpg
{
public class wizard : Hero
    {

        public void teste(string heroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = heroType;

        }
        public override string Attack (){
            return this.Name + "Lançou Magia";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){

            
        return this.Name +"Lançou magia super efetiva com bonus de " + Bonus;
        }else{
          return this.Name + "Lançou uma magia com força fraca com bonus de" + Bonus;  
        }
    }
        }
    }

