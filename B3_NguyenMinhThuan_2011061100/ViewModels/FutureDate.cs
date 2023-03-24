﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace B3_NguyenMinhThuan_2011061100.ViewModels
{ 
    public class FutureDate : ValidationAttribute
    {
    public override bool IsValid(object value)
    {
        DateTime dateTime;
        var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/M/yyyy",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);
        return (isValid && dateTime > DateTime.Now);
    }
}
}

