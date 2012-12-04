﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Foolproof;
using System.Web.Security;

namespace web.Shared
{
    public class UsernameValidationAttribute : ModelAwareValidationAttribute
    {
        public override bool IsValid(object value, object container)
        {
            string username = value as string;
            if (username == null)
                return false;
            return Membership.GetUser(username, false) != null;
        }
    }
}