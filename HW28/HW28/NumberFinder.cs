namespace HW28
{
	public class NumberFinder
	{
		public static int FindMissingNumber(int[] array)
		{
			Array.Sort(array);
			int iterator = 1;

			foreach (int i in array)
			{
				if (i != iterator)
				{
					return iterator;
				}
				iterator++;
			}
			return -1;
		}
	}
}
