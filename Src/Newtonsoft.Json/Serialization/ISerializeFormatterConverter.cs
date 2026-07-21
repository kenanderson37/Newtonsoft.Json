#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

#if HAVE_BINARY_SERIALIZATION
using System;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Serialization
{
    internal class ISerializeFormatterConverter : IFormatterConverter
    {
        public ISerializeFormatterConverter()
        {
        }

        private T ChangeTo<T>(object value)
        {
            return (T)System.Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture)!;
        }

        public object Convert(object value, Type type)
        {
            if (type.IsEnum && !value.GetType().IsEnum)
            {
                return Enum.ToObject(type, value);
            }
            else
            {
                return System.Convert.ChangeType(value, type, CultureInfo.InvariantCulture)!;
            }
        }

        public object Convert(object value, TypeCode typeCode)
        {
            return System.Convert.ChangeType(value, typeCode, CultureInfo.InvariantCulture)!;
        }

        public bool ToBoolean(object value)
        {
            return ChangeTo<bool>(value);
        }

        public byte ToByte(object value)
        {
            return ChangeTo<byte>(value);
        }

        public char ToChar(object value)
        {
            return ChangeTo<char>(value);
        }

        public DateTime ToDateTime(object value)
        {
            return ChangeTo<DateTime>(value);
        }

        public decimal ToDecimal(object value)
        {
            return ChangeTo<decimal>(value);
        }

        public double ToDouble(object value)
        {
            return ChangeTo<double>(value);
        }

        public short ToInt16(object value)
        {
            return ChangeTo<short>(value);
        }

        public int ToInt32(object value)
        {
            return ChangeTo<int>(value);
        }

        public long ToInt64(object value)
        {
            return ChangeTo<long>(value);
        }

        public sbyte ToSByte(object value)
        {
            return ChangeTo<sbyte>(value);
        }

        public float ToSingle(object value)
        {
            return ChangeTo<float>(value);
        }

        public string ToString(object value)
        {
            return ChangeTo<string>(value);
        }

        public ushort ToUInt16(object value)
        {
            return ChangeTo<ushort>(value);
        }

        public uint ToUInt32(object value)
        {
            return ChangeTo<uint>(value);
        }

        public ulong ToUInt64(object value)
        {
            return ChangeTo<ulong>(value);
        }
    }
}

#endif