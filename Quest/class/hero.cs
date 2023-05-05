using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class hero //Базовый класс герой
    {
        private string name;//Имя героя
        private int health;//Здоровье героя
        private int lives;//Жизни героя

        public string getName()//Получение имени
        {
            return name;
        }

        public int getHealth()//Получение здоровья
        { 
            return health;
        }

        public void setName(string name)//Присваивает имя
        {
            this.name = name;
        }

        public void setHealth(int health)//Присваивает здоровье
        {
            this.health = health;
        }

        public int getLives()//Получение количества жизней
        {
            return this.lives;
        }

        public void setLives(int live)//Присваивает количества жизней
        {
            this.lives = live;  
        }

        public virtual int skill()//Способность
        {
            return 0;
        }
    }
}
