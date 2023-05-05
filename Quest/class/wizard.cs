using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Wizard:hero//Класс маг
    {
       public Wizard(string name)//Конструктор класса маг
       {
            this.setHealth(200);
            this.setName(name);
            this.setLives(3);
       }

        public override int skill()//Способность "Шар огня", возвращает 300 урона
        {
            return 300;
        }    
      
    }
}
