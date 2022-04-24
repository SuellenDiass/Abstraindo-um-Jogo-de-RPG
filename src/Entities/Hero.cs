namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public abstract class Hero    // classe avstract vc nao pode herdar, mas outras classes utilizem
    {
        public Hero (string Name,int Level,string HeroType)  // atalho construtor ctor
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }
        public string Name;

        public int Level;

        public string HeroType;

        public override string ToString(){
            return this.Name + " "+ this.Level+ " " + this.HeroType + " ";

        }
        public virtual string Attack(){   // virtual permite alteraçao pela classe utilizada
            return this.Name + "Atacou com a sua espada"; 
        }
    }
}