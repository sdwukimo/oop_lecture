﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_8_1
{
    class Cat : Animal
    {
        //Fields
        new private static int amount=0;
        //Constructors
        public Cat():base()
        {
            amount++;
        }
        public Cat(string name):base(name)
        {
            amount++;
        }
        public Cat(string name,int shout):base(name,shout)
        {
            amount++;
        }
        //繼承隱藏 hide inherited attribute
        new public static int Amount
        {
            get { return amount; }
        }

        public string Hello()
        {
            return "hello";
        }
        //override Methods
        public override string Shout()
        {
            string str = "我的名字叫" + name;
            for (int i = 0; i < ShoutNum; i++) //ShoutNum 是屬性非欄位
            {
                str += " 喵~";
            }
            return str;
        }
        public static Cat Create(string name,int shouts)
        {
            Cat cat=null;
            if (shouts <= 0)
                return cat;
            else
            {
                cat = new Cat(name,shouts);
                return cat;
            }
        }
    }
}
