namespace MementoMori.Ortega.Share.Utils
{
	public static class EnumUtil
	{
		private static class EnumCache<T> where T : Enum
		{
			private static T[] _values;

			internal static T[] Values => _values ??= Enum.GetValues(typeof(T)).Cast<T>().ToArray();
		}

		public static List<T> GetValueList<T>() where T : Enum
		{
			return EnumCache<T>.Values.ToList();
		}

		public static T[] GetValueArray<T>() where T : Enum
		{
			return (T[]) EnumCache<T>.Values.Clone();
		}

		public static int GetLength<T>() where T : Enum
		{
			return EnumCache<T>.Values.Length;
		}

		public static string GetKey<T>(T enumValue) where T : Enum
		{
			string name = typeof(Type).Name;
			string text = enumValue.ToString();
			return "[" + name + text + "]";
		}
	}
}
