using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Shared.Utilities
{
    public class EnumHelper
    {
        public static List<SelectListItem> ConvertEnumToDropDownSource<T>()
        {
            List<SelectListItem> ret = new List<SelectListItem>();
            var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();

            for (int i = 0; i < Enum.GetNames(typeof(T)).Length; i++)
            {
                SelectListItem ddlItem = new SelectListItem();
                ddlItem.Text = Enum.GetNames(typeof(T))[i];
                ddlItem.Value = values[i].ToString();

                ret.Add(ddlItem);
            }

            return ret;
        }
    }
}
