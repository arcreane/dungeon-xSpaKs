
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum MonsterType
{
    Barbarian,
    Magician,
    Thief
}
public abstract class Monster : CommunicatingClass {

    public Monster() {
    }

    public int m_iLifePoints;

    public Weapon m_Weapon;

    public Weapon m_EfficientWeapon;

    /// <summary>
    /// @param p_Hero 
    /// @return
    /// </summary>
    public void Attack(Hero p_Hero) {
        // TODO implement here
        
    }

}