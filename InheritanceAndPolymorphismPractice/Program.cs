﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wizard wizardOne = new Wizard(true);

            //HogwartsStudent longbottom = new HogwartsStudent(7);

            //DeathEater malfoy = new DeathEater();

            //wizardOne.MakeMagic();
            //longbottom.MakeMagic();
            //malfoy.MakeMagic();

            Standard gymMember1 = new Standard(100);
            VIP gymMember2 = new VIP();

            gymMember1.Activate();
            gymMember2.Activate();










        }
    }
}
