namespace System
{
    public static class StringParsingExtensions
    {
        public static char ToChar(this string value) => char.TryParse(value, out var output) ? output : default(char);

        public static byte ToByte(this string value) => byte.TryParse(value, out var output) ? output : default(byte);

        public static sbyte ToSByte(this string value) => sbyte.TryParse(value, out var output) ? output : default(sbyte);

        public static ushort ToUShort(this string value) => ushort.TryParse(value, out var output) ? output : default(ushort);

        public static short ToShort(this string value) => short.TryParse(value, out var output) ? output : default(short);

        public static uint ToUInt(this string value) => uint.TryParse(value, out var output) ? output : default(uint);

        public static int ToInt(this string value) => int.TryParse(value, out var output) ? output : default(int);

        public static ulong ToULong(this string value) => ulong.TryParse(value, out var output) ? output : default(ulong);

        public static long ToLong(this string value) => long.TryParse(value, out var output) ? output : default(long);

        public static float ToFloat(this string value) => float.TryParse(value, out var output) ? output : default(float);

        public static double ToDouble(this string value) => double.TryParse(value, out var output) ? output : default(double);

        public static decimal ToDecimal(this string value) => decimal.TryParse(value, out var output) ? output : default(decimal);

        public static DateTime ToDateTime(this string value) => DateTime.TryParse(value, out var output) ? output : default(DateTime);

        public static TimeSpan ToTimeSpan(this string value) => TimeSpan.TryParse(value, out var output) ? output : default(TimeSpan);

        public static Uri ToUri(this string value, UriKind uriKind = UriKind.RelativeOrAbsolute) => Uri.TryCreate(value, uriKind, out var output) ? output : default(Uri);

        public static Guid ToGuid(this string value) => Guid.TryParse(value, out var output) ? output : default(Guid);

        public static bool ToBool(this string value) => bool.TryParse(value, out var output) ? output : default(bool);

        public static T ToEnum<T>(this string value) where T : struct, IComparable => Enum.TryParse(value, true, out T output) ? output : default(T);

        public static char? ToNullableChar(this string value) => char.TryParse(value, out var output) ? output as char? : null;

        public static byte? ToNullableByte(this string value) => byte.TryParse(value, out var output) ? output as byte? : null;

        public static sbyte? ToNullableSByte(this string value) => sbyte.TryParse(value, out var output) ? output as sbyte? : null;

        public static ushort? ToNullableUShort(this string value) => ushort.TryParse(value, out var output) ? output as ushort? : null;

        public static short? ToNullableShort(this string value) => short.TryParse(value, out var output) ? output as short? : null;

        public static uint? ToNullableUInt(this string value) => uint.TryParse(value, out var output) ? output as uint? : null;

        public static int? ToNullableInt(this string value) => int.TryParse(value, out var output) ? output as int? : null;

        public static ulong? ToNullableULong(this string value) => ulong.TryParse(value, out var output) ? output as ulong? : null;

        public static long? ToNullableLong(this string value) => long.TryParse(value, out var output) ? output as long? : null;

        public static float? ToNullableFloat(this string value) => float.TryParse(value, out var output) ? output as float? : null;

        public static double? ToNullableDouble(this string value) => double.TryParse(value, out var output) ? output as double? : null;

        public static decimal? ToNullableDecimal(this string value) => decimal.TryParse(value, out var output) ? output as decimal? : null;

        public static DateTime? ToNullableDateTime(this string value) => DateTime.TryParse(value, out var output) ? output as DateTime? : null;

        public static TimeSpan? ToNullableTimeSpan(this string value) => TimeSpan.TryParse(value, out var output) ? output as TimeSpan? : null;

        public static Guid? ToNullableGuid(this string value) => Guid.TryParse(value, out var output) ? output as Guid? : null;

        public static bool? ToNullableBool(this string value) => !bool.TryParse(value, out var output) ? null : (bool?)output;

        public static T? ToNullableEnum<T>(this string value) where T : struct, IComparable => Enum.TryParse(value, true, out T output) ? output as T? : null;
    }
}