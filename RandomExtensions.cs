using System;

// Source: http://stackoverflow.com/a/110570
static class RandomExtensions
{
	//洗牌判斷
	public static void Shuffle<T> (this Random rng, T[] array)
	{
		int n = array.Length;
		while (n > 1) 
		{
			int k = rng.Next(n--);
			T temp = array[n];
			array[n] = array[k];
			array[k] = temp;
		}
	}
}