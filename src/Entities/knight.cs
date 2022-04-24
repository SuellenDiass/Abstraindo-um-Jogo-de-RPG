namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class knight : Hero  
    // herdar de hero, metodo construtor mesmo nome classe, classe abstrata abstrai para que outras classes herdam
    {
        public knight(string Name,int Level,string HeroType) : base(Name, Level, HeroType){} // classe abstrata
        public override string Attack() => $"{this.Name} Lançou Magia.";
  public string Attack(int Bonus)
  {
    if (Bonus > 6)
    {
      return $"{this.Name} Lançou Magia super efetiva Com bonus de {Bonus}";
    }
    else
    {
      return $"{this.Name} Lançou Magia com força fraca com bonus de {Bonus}";
    }
  }
    }
}