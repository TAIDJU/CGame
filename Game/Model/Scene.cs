﻿using System;
using System.Collections.Generic;

namespace Model
{
    public class Scene
    {
        public Character PlayerCharacter { get; }
        public List<Character> Enemies { get; }


        public Scene(Character playerCharacter, List<Character> enemies)
        {
            PlayerCharacter = playerCharacter;
            Enemies = enemies;
        }


        public static Scene GetTestScene() => new Scene(
            new Character("Bibon", new Health(100),new Damage(8)),
            new List<Character>()
            {
                new Character("Tugoserya", new Health(15), new Damage(10)),
                new Character("Foxiris", new Health(15), new Damage(10)),
                new Character("Harambe", new Health(15), new Damage(10)),
            }
        );


        public void DisplayScene()
        {
            if (PlayerCharacter == null) return;
            if (Enemies == null) return;
            if (Enemies.Count == 0) return;
            
            
            PlayerCharacter.Display();


            foreach (Character character in Enemies)
            {
                character.Display();
            }
        }
    }
}