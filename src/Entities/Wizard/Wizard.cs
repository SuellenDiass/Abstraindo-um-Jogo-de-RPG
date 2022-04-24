namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{

    public class Wizard : Hero          
    {
        public Wizard(string Name,int Level,string HeroType) : base(Name, Level, HeroType)
        {
        }

            public override string Attack (){
            return this.Name + "Lançou sua magia";
        }
         public string Attack (int Bonus){
            if(Bonus > 6){
            return this.Name + "Lançou sua magia super efetiva com bonus de" + Bonus;
            }else{
                return this.Name + "Lançou a magia com força fraca com bonus de" + Bonus;
            }
            
        }
    }
}