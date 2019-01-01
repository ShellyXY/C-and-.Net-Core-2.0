using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public class Person:Object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WonderOfTheAncientWorld FavouriteAncientWonder;
        public WonderOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>;
    }
}
