using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        //private bool maleOrFemale;
        //private String eyeColor;
        //private String hairColor;
        //private int heightCategory;
        public enum Gender { male, female }
        public enum EyeColor { black, green, blue}
        public enum HairColor { black, blond, white}
        public enum Height { tall, medium, taller}


        public Gender genderEnum { get; set; }
        public EyeColor eyeColorEnum { get; set; }
        public HairColor hairColorEnum { get; set; }
        public Height heightEnum { get; set; }

        //constructor
        public Human(Gender pgender, EyeColor peyeColor, HairColor phairColor, Height pheight)
        {
            this.genderEnum = pgender;
            this.eyeColorEnum = peyeColor;
            this.hairColorEnum = phairColor;
            this.heightEnum = pheight;
        }

        //public Human(bool maleOrFemale String eyeColor, String hairColor, int heightCategory)
        //{
        //    this.maleOrFemale = maleOrFemale;
        //    this.eyeColor = eyeColor;
        //    this.hairColor = hairColor;
        //    this.heightCategory = heightCategory;
        //}


        public String GetDescription()
        {
            String description = "You got a " + genderEnum;
            description = description + ", with " + eyeColorEnum + " eyes";
            description = description + ", " + hairColorEnum + " hair";
            description = description + ", who is " + heightEnum;

            return description;
        }

        //public String GetGenderDescription()
        //{
        //    if (maleOrFemale)
        //    {
        //        return "man";
        //    }
        //    else
        //    {
        //        return "woman";
        //    }
        //}

        //public String GetHeightDescription()
        //{
        //    switch (heightCategory)
        //    {
        //        case 0:
        //            return "Very short";
        //        case 1:
        //            return "Short";
        //        case 2:
        //            return "Medium height";
        //        case 3:
        //            return "Tall";
        //        case 4:
        //            return "Very tall";
        //        default:
        //            return "Unknown height";
        //    }
        //}
    }
}
