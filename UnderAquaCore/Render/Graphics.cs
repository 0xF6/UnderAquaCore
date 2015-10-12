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
namespace UnderAquaCore.Render
{
    public enum RGraphics
    {
        None        = 0x0,
        DirectX9    = 0x1,
        DirectX10   = 0x2,
        DirectX11   = 0x3,
        DirectX12   = 0x4,
        OpenGL      = 0x5
    }
    struct OctoGraphics
    {
        public RGraphics rg;
        private Flach32 _Width;
        private Flach32 _Height;
        private Singl32 _Red;
        private Singl32 _Green;
        private Singl32 _Blue;
        private Singl32 _Alpha;
        public Flach32 Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if(value != 0)
                {
                    _Width = value;
                }
            }
        }
        public Flach32 Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (Height != 0F)
                {
                    _Height = value;
                }
            }
        }
        public Singl32 Red
        {
            get
            {
                return _Red;
            }
            set
            {
                if (Red != 0F)
                {
                    _Red = value;
                }
            }
        }
        public Singl32 Green
        {
            get
            {
                return _Green;
            }
            set
            {
                if (Green != 0F)
                {
                    _Green = value;
                }
            }
        }
        public Singl32 Blue
        {
            get
            {
                return _Blue;
            }
            set
            {
                if (Blue != 0F)
                {
                    _Blue = value;
                }
            }
        }
        public Singl32 Alpha
        {
            get
            {
                return _Alpha;
            }
            set
            {
                if (Alpha != 0F)
                {
                    _Alpha = value;
                }
            }
        }
    }
    internal sealed class _Graphics
    {
        public void InI(OctoGraphics og)
        {
            if(og.rg == RGraphics.OpenGL)
            {
                try
                {
                    UConsole.Warning("Component rendering->OpenGL;");
                    Glut.glutInit();
                    Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
                    Gl.glClearColor(og.Red, og.Green, og.Blue, og.Alpha);
                    Gl.glViewport(0, 0, og.Width, og.Height);
                    UConsole.Log("<OpenGL> is installed!");
                }
                catch(Exception ex)
                {
                    UConsole.Error(ex.ToString());
                }
            }
            else if (og.rg == RGraphics.DirectX9)
            {
                try
                {
                    UConsole.Log("Component rendering->DirectX9;");
                    //
                    // Preparing..
                    //
                    UConsole.Log("<DirectX9> is installed!");
                }
                catch (Exception ex)
                {
                    UConsole.Error(ex.ToString());
                }
            }
            else if (og.rg == RGraphics.DirectX10)
            {
                try
                {
                    UConsole.Log("Component rendering->DirectX10;");
                    UConsole.Warning("<DirectX10> is not found!");
                    throw new Exception("Component <DirectX10> is not found!");
                }
                catch (Exception ex)
                {
                    UConsole.Error(ex.ToString());
                }
            }
            else if (og.rg == RGraphics.DirectX11)
            {
                try
                {
                    UConsole.Log("Component rendering->DirectX11;");
                    UConsole.Warning("<DirectX11> is not found!");
                    throw new Exception("Component <DirectX11> is not found!");
                }
                catch (Exception ex)
                {
                    UConsole.Error(ex.ToString());
                }
            }
            else if (og.rg == RGraphics.DirectX12)
            {
                try
                {
                    UConsole.Warning("Component rendering->DirectX12;");
                    UConsole.Warning("<DirectX12> is not found!");
                    throw new Exception("Component <DirectX12> is not found!");
                }
                catch (Exception ex)
                {
                    UConsole.Error(ex.ToString());
                }
            }
        }
    }
    public static class Graphics
    {
        private static _Graphics g = new _Graphics();
    }
}
