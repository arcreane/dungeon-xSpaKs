
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


enum ProtectionType
{
    Cape, 
    Pendant, 
    Shield
}
public abstract class Protection : CommunicatingClass
{

    public Protection() {
    }

    /// <summary>
    /// @param MonsterInRoom 
    /// @return
    /// </summary>
    public bool CheckEfficiency(Monster MonsterInRoom) {
        // TODO implement here
        return false;
    }

}