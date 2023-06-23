﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Monster
    {
        // Fields
        private string _name;
        private int _strength;
        private int _defence;
        private int _health;
        private int _currentHealth;

        // Properties
        public string Name { get { return _name; } }
        public int Strength { get { return _strength; } }
        public int Defence { get { return _defence; } }
        public int Health { get { return _health; } }
        public int CurrentHealth
        {
            get { return _currentHealth; }
            set { _currentHealth = Math.Min(Math.Max(value, 0), _health); }
        }


        // Methods

        // Constructor

        public Monster(string name, int str, int def, int hp)
        {
            _name = name;
            _strength = str;
            _defence = def;
            _health = hp;
        }

    }
}