using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class swordman:hero//Класс мечник
    {
        public swordman(string name)//Конструктор класса мечник
        {
            this.setHealth(250);
            this.setName(name);
            this.setLives(5);
        }

        public override int skill()//Способность "Удар мечом", возвращает 225 урона
        {
            return 225;
        }
    }

}
