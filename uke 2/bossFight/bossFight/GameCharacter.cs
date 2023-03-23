using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bossFight
{
    internal class GameCharacter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }

        public GameCharacter(string name, int health, int strength, int stamina) 
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }
        public void Fight(GameCharacter reciver)
        {
            if (this.Stamina <= 0)
            {
                this.Recharge();
                return;
            }
            if (this.Name== "Boss") { 
                this.Strength = Program.RngNum(0,31);
            }

            reciver.Health = reciver.Health - this.Strength;
            this.Stamina = this.Stamina - 10;
            Console.WriteLine(this.Name + " hitt " + reciver.Name + " for " + this.Strength + " " + reciver.Name +
                " health is now " + reciver.Health);
        }
        
        public void Recharge()
        {
            if (this.Name == "Boss")
            {
                Console.WriteLine(this.Name + " is recharging");
                this.Stamina = 10;
            }
            else if (this.Name == "Hero")
            {
                Console.WriteLine(this.Name + " is recharging");
                this.Stamina = 40;
            }
        }
    }
}
