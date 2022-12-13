using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses
{
    public class Hero
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory heroFactory)
        {
            weapon = heroFactory.CreateWeapon();
            movement = heroFactory.CreateMovement();
        }

        public void Run()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
