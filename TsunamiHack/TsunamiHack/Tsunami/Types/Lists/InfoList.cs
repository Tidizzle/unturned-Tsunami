﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsunamiHack.Tsunami.Types.Lists
{
    [Obsolete]
    public abstract class InfoList
    {
        public List<string> UserList;

        public virtual string GetUserByIndex(int index)
        {
            return index > UserList.Count ? null : UserList[index];
        }

        public virtual string GetUserByName(string name)
        {
            if (!UserList.Contains(name)) return null;
            var index = UserList.IndexOf(name);
            return UserList[index];
        }

        public virtual List<string> GetFullList()
        {
            return UserList;
        }

        public virtual bool Contain(string item)
        {
            return UserList.Contains(item);
        }

    }
}
