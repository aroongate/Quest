using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Archer:hero //Класс лучник
    {
        public Archer(string name)//Конструктор класса лучник
        {
            this.setHealth(150);
            this.setName(name);
            this.setLives(4);
        }

        public override int skill()//Способность "Мощный выстрел", возвращает урон 250
        {
            return 250;
        }
    }
}
