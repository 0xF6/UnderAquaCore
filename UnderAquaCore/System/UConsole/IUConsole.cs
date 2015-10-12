#pragma warning disable "CS1587"
#pragma warning disable "CS1591"
///|
///| *******************************************************
///|
///|        Copyright © 2013-2014 DespAir Tech
///|
///|
///|                    By DAT Technology
///|
///|
///|
///|
///|
///| *******************************************************
///| using [];
using System;
using System.Collections.Generic;
using UnderAquaCore.Tools.Type;
///|
namespace UnderAquaCore.System.UConsole
{
    interface IUConsole
    {
        void _Log(FStr text);
        void _Error(FStr text);
        void _Warning(FStr text);
    }
}
///|