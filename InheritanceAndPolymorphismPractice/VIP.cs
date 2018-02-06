using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
     public class VIP : Membership// : (Fill in blank) = Inherent
    {
        //fields
        //invisible

        //Properties
        public bool IsSwanky { get; set; }

        //Constructors
        public VIP()
        {
            //default constructors
        }
    
        public VIP(bool isSwanky)
        {
            this.IsSwanky = isSwanky;//This is optional because IsSwanky is in in pascal case == camel case
        }      //^^^^refers to properties when field is invisible otherwise should be camel case == camel case


        //Methods
        public override void Activate()
        {
            IsSwanky = true;

            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You are already a big deal");
            }
        }


    }
}
