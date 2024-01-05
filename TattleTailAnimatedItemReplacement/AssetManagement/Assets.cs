using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TattleTailAnimatedItemReplacement.AssetManagement
{
    public static class Assets
    {
        // Methods
        private static string GetAssemblyName()
        {
            char[] separator = new char[] { ',' };
            return Assembly.GetExecutingAssembly().FullName.Split(separator)[0];
        }

        public static void PopulateAssets() 
        {

            string name = GetAssemblyName() + ".AssetManagement.tattletailanimateditemreplacement";

        }



    }
}
