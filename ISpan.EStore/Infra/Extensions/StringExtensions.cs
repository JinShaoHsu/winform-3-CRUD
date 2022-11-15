namespace ISpan.EStore.Infra.Extensions
{
	public static class StringExtensions
	{
		public static int ToInt(this string source ,int defaultvalue)
		{
			bool isInt = int.TryParse(source, out int value);
			return isInt ? value : defaultvalue;
		}
	}
}
