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
///|
namespace UnderAquaCore.Tools.Type
{
    public struct Fbytes
    {
        private byte _value;
        public Fbytes(byte val)
        {
            _value = val;
        }
        public static implicit operator byte(Fbytes val)
        {
            return val._value;
        }
        public static implicit operator Fbytes(byte val)
        {
            return new Fbytes(val);
        }
    }
    public struct FBool
    {
        private bool _value;
        public FBool(bool val)
        {
            _value = val;
        }
        public static implicit operator bool(FBool val)
        {
            return val._value;
        }
        public static implicit operator FBool(bool val)
        {
            return new FBool(val);
        }
    }
    public struct FStr
    {
        private String _value;
        public FStr(String val)
        {
            _value = val;
        }
        public static bool IdexOf(FStr val)
        {
            if (val._value.IndexOf(val) == 1)
            {
                return true;
            }
            else
                return false;
        }
        public static class b1
        {
            private static FStr _a = "1";
            public static FStr oa()
            {
                return ("qwe" + _a);
            }
        }
        public static implicit operator String(FStr val)
        {
            return val._value;
        }
        public static implicit operator FStr(String val)
        {
            return new FStr(val);
        }
    }
    public struct FlachPtr
    {
        private UIntPtr _value;
        public FlachPtr(UIntPtr val)
        {
            _value = val;
        }
        public static implicit operator UIntPtr(FlachPtr val)
        {
            return val._value;
        }
        public static implicit operator FlachPtr(UIntPtr val)
        {
            return new FlachPtr(val);
        }
    }
    public struct FlachU64
    {
        private UInt64 _value;
        public FlachU64(UInt64 val)
        {
            _value = val;
        }
        public static implicit operator UInt64(FlachU64 val)
        {
            return val._value;
        }
        public static implicit operator FlachU64(UInt64 val)
        {
            return new FlachU64(val);
        }
    }
    public struct FlachU32
    {
        private UInt32 _value;
        public FlachU32(UInt32 val)
        {
            _value = val;
        }
        public static implicit operator UInt32(FlachU32 val)
        {
            return val._value;
        }
        public static implicit operator FlachU32(UInt32 val)
        {
            return new FlachU32(val);
        }
    }
    public struct FlachU16
    {
        private UInt16 _value;
        public FlachU16(UInt16 val)
        {
            _value = val;
        }
        public static implicit operator UInt16(FlachU16 val)
        {
            return val._value;
        }
        public static implicit operator FlachU16(UInt16 val)
        {
            return new FlachU16(val);
        }
    }
    public struct Flach16
    {
        private Int16 _value;
        public Flach16(Int16 val)
        {
            _value = val;
        }
        public static implicit operator Int16(Flach16 val)
        {
            return val._value;
        }
        public static implicit operator Flach16(Int16 val)
        {
            return new Flach16(val);
        }
    }
    public struct Flach64
    {
        private Int64 _value;
        public Flach64(Int64 val)
        {
            _value = val;
        }
        public static implicit operator Int64(Flach64 val)
        {
            return val._value;
        }
        public static implicit operator Flach64(Int64 val)
        {
            return new Flach64(val);
        }
    }
    public struct Flach32
    {
        private Int32 _value;
        public Flach32(Int32 val)
        {
            _value = val;
        }
        public static implicit operator Int32(Flach32 val)
        {
            return val._value;
        }
        public static implicit operator Flach32(Int32 val)
        {
            return new Flach32(val);
        }
    }
    public struct Singl32
    {
        private float _value;
        public Singl32(float val)
        {
            _value = val;
        }
        public static implicit operator float (Singl32 val)
        {
            return val._value;
        }
        public static implicit operator Singl32(float val)
        {
            return new Singl32(val);
        }
    }
}
///|