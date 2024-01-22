
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Game {

    public Game() {
        HeroPlayer = new Hero();
        GameDungeon = new Dungeon();
    }

    public Hero HeroPlayer;

    public Dungeon GameDungeon;

    public void Initialise() {
        // TODO implement here
    }

    public void Update() { }

}