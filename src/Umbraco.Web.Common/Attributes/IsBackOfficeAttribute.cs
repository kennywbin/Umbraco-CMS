﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Umbraco.Web.Common.Attributes
{
    /// <summary>
    /// When applied to an api controller it will be routed to the /Umbraco/BackOffice prefix route so we can determine if it
    /// is a back office route or not.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class IsBackOfficeAttribute : Attribute
    {        
    }
}
