#region warning disable
#pragma warning disable "CS1587"
#pragma warning disable "CS1591"
#endregion
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
///|
#region using
#region System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
#region Dx9 and Dx10
using SharpDX;
using SharpDX.Collections;
using SharpDX.Diagnostics;
using SharpDX.Direct3D;
using SharpDX.IO;
using SharpDX.Multimedia;
using SharpDX.Serialization;
using SharpDX.Text;
using SharpDX.Threading;
using SharpDX.Win32;
using SharpDX.Windows;
using SharpDX.Direct2D1;
using SharpDX.Direct3D11;
using SharpDX.Direct3D9;
using SharpDX.DirectInput;
using SharpDX.DirectWrite;
using SharpDX.DXGI;
using SharpDX.D3DCompiler;
#endregion
#region Tao
using Tao;
using Tao.Cg;
using Tao.DevIl;
using Tao.FreeGlut;
using Tao.Glfw;
using Tao.Ode;
using Tao.OpenAl;
using Tao.OpenGl;
using Tao.Platform.Windows;
using Tao.Sdl;
#endregion
#region UAE
using UnderAquaCore.System.UConsole;
using UnderAquaCore.System.Tools;
using UnderAquaCore.Tools.Type;
#endregion
#endregion
namespace UnderAquaCore.Render.Tools
{
    internal sealed class _Mechanics : IMechanics
    {

    }
    public static class Mechanics
    {
        private static _Mechanics mh = new _Mechanics();
    }
}





































































interface test
{
    
     void blabla();
}

class test1 : test
{
    private int _i;
    public int i
    {
        get
        {
            return _i;
        }
        set
        {
            _i = value;
        }
    }

    public void blabla()
    {
         
    }
}