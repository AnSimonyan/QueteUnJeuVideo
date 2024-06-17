using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueteUnJeuVideo
{
    public class Character
    {
        public string Name { get; }
        public int AttackForce { get; }
        public int DefenseForce { get; }
        public int PointOfLive { get; set; }

        public bool isAlive => PointOfLive > 0;

        public Character(string name, int attackForce, int defenseForce, int pointOfLive)

        {
            Name = name;
            AttackForce = attackForce;
            DefenseForce = defenseForce;
            PointOfLive = pointOfLive;
        }

        public void Attack(Character attacked)
        {
            attacked.PointOfLive = attacked.PointOfLive + attacked.DefenseForce - AttackForce ;
        }
        
    }
}
