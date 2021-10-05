using System;
using System.Collections.Generic;

public static partial class BackEnd
{
	private static Random random = new Random();

	public static T[] Request<T>(Func<T> function, int length)
	{
		Console.WriteLine("INPUTS:");

		T[] array = new T[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = function();
			Console.WriteLine(array[i]);
		}

		Console.WriteLine("====================================================");

		return array;
	}

	#region Random_Generation

	public static int RandomInteger(int max = 11) => random.Next(max);
	public static int RandomInteger(int min, int max) => random.Next(min, max);

	public static long RandomLong()
	{
		int r = random.Next(4);
		switch (r)
		{
			case 0:
				return random.Next(byte.MaxValue);
			case 1:
				return random.Next(short.MaxValue);
			case 2:
				return random.Next(int.MaxValue);
			case 3:
				byte[] b = new byte[8];
				random.NextBytes(b);
				return Math.Abs(BitConverter.ToInt64(b));
			default:
				goto case 2;
		}
	}

	public static ulong RandomUlong()
	{
		int r = random.Next(4);
		switch (r)
		{
			case 0:
				return (ulong)random.Next(byte.MaxValue);
			case 1:
				return (ulong)random.Next(ushort.MaxValue);
			case 2:
				return (ulong)random.Next(int.MaxValue);
			case 3:
				byte[] b = new byte[8];
				random.NextBytes(b);
				return (ulong)Math.Abs(BitConverter.ToInt64(b));
			default:
				goto case 2;
		}
	}

	public static double RandomDouble(double min = 0, double max = 1) => random.NextDouble() * (max - min) + min;

	public static bool RandomBoolean() => random.Next(2) == 0 ? true : false;
	
	#region Letters

	public static char[] letters = new char[] 
	{
		'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
	};

	#endregion

	public static char RandomLetter() => letters[random.Next(letters.Length)];

	public static string RandomWord(int length = 0)
	{
		if (length == 0) length = (int)RandomDouble(7, 3);

		string word = String.Empty;

		for (int i = 0; i < length; i++)
		{
			word += RandomLetter();
		}

		return word;
	}

	public static string RandomSentence(int length = 0)
	{
		if (length == 0) length = (int)RandomDouble(7, 3);

		string sentence = String.Empty;

		for (int i = 0; i < length; i++)
		{
			sentence += RandomWord();
			if (i != length - 1) sentence += ' ';
			else sentence += '.';
		}
		
		sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

		return sentence;
	}

	public static T[] CreateArray<T>(int length, Func<int, T> function)
	{
		T[] array = new T[length];

		for (int i = 0; i < length; i++)
		{
			array[i] = function(i);
		}

		return array;
	}

	public static List<T> CreateList<T>(Func<int, T> function, int length = 10)
	{
		List<T> list = new List<T>(length);

		for (int i = 0; i < length; i++)
		{
			list.Add(function(i));
		}

		return list;
	}

	#endregion

}