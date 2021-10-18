using System;
using System.Linq;
using System.Collections.Generic;
using static BackEnd;

class MainClass
{
	static void Main(string[] args)
	{
		var inputs = Request(() => (RandomSentence(), RandomSentence()), 10); // request inputs
		Dictionary<string, int> outputs = new Dictionary<string, int>();

		for (int i = 0; i < inputs.Length; i++)
		{
			string longer = inputs[i].Item1.Length >= inputs[i].Item2.Length ? inputs[i].Item1 : inputs[i].Item2;
			string[] words = longer.Split(' ', '.');

			foreach (string s in words) if (!string.IsNullOrWhiteSpace(s)) outputs.Add(s.ToLower(), s.Length);
		}

		Evaluate("Word_Length", inputs, outputs); // send results to grading system
	}
}

