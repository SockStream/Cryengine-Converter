using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CgfConverter
{
    public enum StringSizeEnum
    {
        Int8 = 1,
        Int16 = 2,
        Int32 = 4,
    }

    public enum LogLevelEnum
    {
        /// <summary>
        /// Log Everything
        /// </summary>
        Verbose = 0x01,
        /// <summary>
        /// Log Some Stuff Useful For Debugging
        /// </summary>
        Debug = 0x02,
        /// <summary>
        /// Log Information/Progress Updates
        /// </summary>
        Info = 0x04,
        /// <summary>
        /// Log Warnings (Default)
        /// </summary>
        Warning = 0x08,
        /// <summary>
        /// Log Errors
        /// </summary>
        Error = 0x0F,
        /// <summary>
        /// Log Critical Errors
        /// </summary>
        Critical = 0x10,
        /// <summary>
        /// Don't Log Anything
        /// </summary>
        None = 0xFF,
    }

    public static class Utils
    {
        public static LogLevelEnum LogLevel { get; set; }
        public static LogLevelEnum DebugLevel { get; set; }

        /// <summary>
        /// Private DataStore for the DateTimeFormats property.
        /// </summary>
        private static String[] _dateTimeFormats = new String[] {
            @"yyyy-MM-dd\THHmm", // 2010-12-31T2359
        };

        public static Double Safe(Double value)
        {
            if (value == Double.NegativeInfinity)
                return Double.MinValue;

            if (value == Double.PositiveInfinity)
                return Double.MaxValue;

            if (value == Double.NaN)
                return 0;

            return value;
        }

        /// <summary>
        /// Custom DateTime formats supported by the parser.
        /// </summary>
        public static String[] DateTimeFormats
        {
            get { return Utils._dateTimeFormats; }
            set { Utils._dateTimeFormats = value; }
        }

        #region Gets the build date and time (by reading the COFF header)

        // http://msdn.microsoft.com/en-us/library/ms680313

        struct _IMAGE_FILE_HEADER
        {
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.Machine' is never assigned to, and will always have its default value 0
            public ushort Machine;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.Machine' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.NumberOfSections' is never assigned to, and will always have its default value 0
            public ushort NumberOfSections;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.NumberOfSections' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.TimeDateStamp' is never assigned to, and will always have its default value 0
            public uint TimeDateStamp;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.TimeDateStamp' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.PointerToSymbolTable' is never assigned to, and will always have its default value 0
            public uint PointerToSymbolTable;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.PointerToSymbolTable' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.NumberOfSymbols' is never assigned to, and will always have its default value 0
            public uint NumberOfSymbols;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.NumberOfSymbols' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.SizeOfOptionalHeader' is never assigned to, and will always have its default value 0
            public ushort SizeOfOptionalHeader;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.SizeOfOptionalHeader' is never assigned to, and will always have its default value 0
#pragma warning disable CS0649 // Field 'Utils._IMAGE_FILE_HEADER.Characteristics' is never assigned to, and will always have its default value 0
            public ushort Characteristics;
#pragma warning restore CS0649 // Field 'Utils._IMAGE_FILE_HEADER.Characteristics' is never assigned to, and will always have its default value 0
        };

        public static DateTime GetBuildDateTime(Assembly assembly)
        {
            if (File.Exists(assembly.Location))
            {
                var buffer = new byte[Math.Max(Marshal.SizeOf(typeof(_IMAGE_FILE_HEADER)), 4)];
                using (var fileStream = new FileStream(assembly.Location, FileMode.Open, FileAccess.Read))
                {
                    fileStream.Position = 0x3C;
                    fileStream.Read(buffer, 0, 4);
                    fileStream.Position = BitConverter.ToUInt32(buffer, 0); // COFF header offset
                    fileStream.Read(buffer, 0, 4); // "PE\0\0"
                    fileStream.Read(buffer, 0, buffer.Length);
                }
                var pinnedBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
                try
                {
                    var coffHeader = (_IMAGE_FILE_HEADER)Marshal.PtrToStructure(pinnedBuffer.AddrOfPinnedObject(), typeof(_IMAGE_FILE_HEADER));

                    return TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1) + new TimeSpan(coffHeader.TimeDateStamp * TimeSpan.TicksPerSecond));
                }
                finally
                {
                    pinnedBuffer.Free();
                }
            }
            return new DateTime();
        }

        #endregion

        public static T Min<T>(T first, T second) where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(first, second) > 0 ? second : first;
        }

        public static T Max<T>(T first, T second) where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(first, second) > 0 ? first : second;
        }

        public static void Log(String format = null, params Object[] args) { Utils.Log(LogLevelEnum.Debug, format, args); }
        public static void Log(LogLevelEnum logLevel, String format = null, params Object[] args)
        {
            if (Utils.LogLevel <= logLevel)
            {
                Console.WriteLine(format ?? String.Empty, args);
            }

            if (Utils.DebugLevel <= logLevel)
            {
                Debug.WriteLine(format ?? String.Empty, args);
            }
        }

        public static uint SwapUIntEndian(uint input)
        {
            byte[] bytes = BitConverter.GetBytes(input);
            Array.Reverse(bytes, 0, bytes.Length);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static int SwapIntEndian(int input)
        {
            byte[] bytes = BitConverter.GetBytes(input);
            Array.Reverse(bytes, 0, bytes.Length);
            return BitConverter.ToInt32(bytes, 0);
        }

        public static Single SwapSingleEndian(Single input)
        {
            byte[] bytes = BitConverter.GetBytes(input);
            Array.Reverse(bytes, 0, bytes.Length);
            return BitConverter.ToSingle(bytes, 0);
        }

        public static UInt16 SwapUInt16Endian(UInt16 input)
        {
            byte[] bytes = BitConverter.GetBytes(input);
            Array.Reverse(bytes, 0, bytes.Length);
            return BitConverter.ToUInt16(bytes, 0);
        }
    }
}