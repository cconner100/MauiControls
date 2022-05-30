// -----------------------------------------------------------------------
//  <copyright file="ZtMenuItems.cs" company="Dominion Enterprise">
//        Copyright (c) Dominion Enterprise LLC. All rights reserved.
//   </copyright>
//  -----------------------------------------------------------------------

namespace ClientApp.Models.Menus
{
    using System;

    public class ZtMenuItem
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string NameResource { get; set; }
        public string IconName { get; set; }
        public string ToolTipResource { get; set; }
        public Type Screen { get; set; }

        /// <summary>
        /// Make the menu resource, will format resource names correctly
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentid"></param>
        /// <param name="nameresource"></param>
        /// <param name="screen"></param>
        /// <returns></returns>
        public static ZtMenuItem MakeMenuItem(int id, int parentid, string nameresource, Type screen = null)
        {
            var resname = nameresource.ToLower();
            return new ZtMenuItem() { Id = id, ParentId = parentid, NameResource = resname, IconName = resname + "icon", ToolTipResource = resname + "tooltip", Screen = screen };
        }
    }
}
