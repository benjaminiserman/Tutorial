/*

=============================================================================

████████╗░█████╗░██████╗░  ░██████╗███╗░░██╗███████╗░█████╗░██╗░░██╗██╗░░░██╗
╚══██╔══╝██╔══██╗██╔══██╗  ██╔════╝████╗░██║██╔════╝██╔══██╗██║░██╔╝╚██╗░██╔╝
░░░██║░░░██║░░██║██████╔╝  ╚█████╗░██╔██╗██║█████╗░░███████║█████═╝░░╚████╔╝░
░░░██║░░░██║░░██║██╔═══╝░  ░╚═══██╗██║╚████║██╔══╝░░██╔══██║██╔═██╗░░░╚██╔╝░░
░░░██║░░░╚█████╔╝██║░░░░░  ██████╔╝██║░╚███║███████╗██║░░██║██║░╚██╗░░░██║░░░
░░░╚═╝░░░░╚════╝░╚═╝░░░░░  ╚═════╝░╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░
=============================================================================

Do not look at the following code if you are a student. Seriously. If you aren't me you probably shouldn't be looking at this. No cheating.











































*/

using System;
using System.Collections.Generic;
using System.Linq;

public static partial class BackEnd
{
	public static bool Evaluate(string lessonName, object inputs, object outputs)
	{
		bool output = true;

		Console.WriteLine("OUTPUTS:");

		try
		{
			switch (lessonName)
			{
				#region 00
				case "Evaluation":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				#endregion
				#region 01
				case "Doubling":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[i] * 2;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Negatives":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = -trueInputs[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Squaring":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[i] * trueInputs[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Order_of_Operations":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = (trueInputs[i] - 1) * 2;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Absolute_Value":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[i];
						if (answer < 0) answer = -answer;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Sum":
				{
					int[] trueInputs = (int[])inputs;
					int trueOutput = (int)outputs;

					int answer = 0;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer += trueInputs[i];
					}

					Console.WriteLine(trueOutput);
					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Polynomial":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int x = trueInputs[i];
						int answer = -2 * x * x * x + 7 * x * x - 9 * x + 5;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				#endregion
				#region 02
				case "Evens":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[i * 2];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length / 2 != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length / 2}");
						output = false;
					}
					break;
				}
				case "Counting_Backwards":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs.Length - i - 1;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Reverse":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = trueInputs[trueInputs.Length - i - 1];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Sum_Until_0":
				{
					int[] trueInputs = (int[])inputs;
					int trueOutput = (int)outputs;

					int answer = 0;

					for (int i = 0; i < trueInputs.Length && trueInputs[i] != 0; i++)
					{
						answer += trueInputs[i];
					}
					
					Console.WriteLine(trueOutput);
					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Foreach_Sum":
				{
					int[] trueInputs = (int[])inputs;
					int trueOutput = (int)outputs;

					int answer = 0;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer += trueInputs[i];
					}

					Console.WriteLine(trueOutput);
					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Sum_Until_7":
				{
					int[] trueInputs = (int[])inputs;
					int trueOutput = (int)outputs;

					int answer = 0, i = 0;

					do
					{
						answer += trueInputs[i];
					}
					while (trueInputs[i] != 7 && ++i < trueInputs.Length);

					Console.WriteLine(trueOutput);
					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Number_To_Word":
				{
					int[] trueInputs = (int[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer;
						switch (trueInputs[i])
						{
							case 0:
								answer = "zero";
								break;
							case 1:
								answer = "one";
								break;
							case 2:
								answer = "two";
								break;
							case 3:
								answer = "three";
								break;
							case 4:
								answer = "four";
								break;
							case 5:
								answer = "five";
								break;
							case 6:
								answer = "six";
								break;
							case 7:
								answer = "seven";
								break;
							case 8:
								answer = "eight";
								break;
							case 9:
								answer = "nine";
								break;
							case 10:
								answer = "ten";
								break;
							default:
								throw new Exception("Input out of range.");
						}

						if (trueOutputs[i].ToLower() != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Addition_And_Factorial":
				{
					int[] trueInputs = (int[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int sum = trueInputs[i * 2] + trueInputs[i * 2 + 1];
						int answer = 1;

						if (sum < 13) for (int j = 2; j <= sum; j++) answer *= j;
						else answer = -1;
						

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length / 2 != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length / 2}");
						output = false;
					}
					break;
				}

				#endregion
				#region 03
				case "Division":
				{
					int[] trueInputs = (int[])inputs;
					double[] trueOutputs = (double[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						double answer = trueInputs[i] / 2.0;

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Floor":
				{
					double[] trueInputs = (double[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						int answer = (int)Math.Floor(trueInputs[i]);
						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Integral_Types":
				{
					long[] trueInputs = (long[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer = string.Empty;

						if (trueInputs[i] <= byte.MaxValue) answer = "byte";
						else if (trueInputs[i] <= short.MaxValue) answer = "short";
						else if (trueInputs[i] <= int.MaxValue) answer = "int";
						else if (trueInputs[i] <= long.MaxValue) answer = "long";

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Unsigned_Types":
				{
					ulong[] trueInputs = (ulong[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer = string.Empty;

						if (trueInputs[i] <= byte.MaxValue) answer = "byte";
						else if (trueInputs[i] <= ushort.MaxValue) answer = "ushort";
						else if (trueInputs[i] <= uint.MaxValue) answer = "uint";
						else if (trueInputs[i] <= ulong.MaxValue) answer = "ulong";

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Opposite":
				{
					bool[] trueInputs = (bool[])inputs;
					bool[] trueOutputs = (bool[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						bool answer = !trueInputs[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "And_All":
				{
					bool[] trueInputs = (bool[])inputs;
					bool trueOutput = (bool)outputs;
					
					Console.WriteLine(trueOutput);

					bool answer = true;
					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer &= trueInputs[i];
					}

					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "True_Or_False":
				{
					bool[] trueInputs = (bool[])inputs;
					bool trueOutput = (bool)outputs;

					Console.WriteLine(trueOutput);

					bool answer = false;
					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer |= trueInputs[i];
					}

					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Vowels":
				{
					char[] trueInputs = (char[])inputs;
					bool[] trueOutputs = (bool[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						bool answer = "aeiouy".Contains(trueInputs[i]);

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Word_Building":
				{
					char[] trueInputs = (char[])inputs;
					string trueOutput = (string)outputs;

					Console.WriteLine(trueOutput);

					string answer = "";
					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer += trueInputs[i];
					}

					if (trueOutput != answer)
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "First_And_Last":
				{
					string[] trueInputs = (string[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer = $"{trueInputs[i][0]}{trueInputs[i][trueInputs[i].Length - 1]}";

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Substring":
				{
					string[] trueInputs = (string[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer;

						if (trueInputs[i].Length % 2 == 0)
						{
							answer = trueInputs[i].Substring(trueInputs[i].Length / 2 - 1, 2);
						}
						else answer = trueInputs[i][trueInputs[i].Length / 2].ToString();

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Capitalize":
				{
					string[] trueInputs = (string[])inputs;
					string[] trueOutputs = (string[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer = $"{char.ToUpper(trueInputs[i][0])}{trueInputs[i].Substring(1)}";

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Sentence_Building":
				{
					string[] trueInputs = (string[])inputs;
					string trueOutput = (string)outputs;

					Console.WriteLine(trueOutput);

					string answer = "";
					for (int i = 0; i < trueInputs.Length; i++)
					{
						answer += trueInputs[i];
						if (i != trueInputs.Length - 1) answer += " ";
					}

					answer = $"{char.ToUpper(answer[0])}{answer.Substring(1)}";

					if (trueOutput.Substring(0, trueOutput.Length - 1) != answer || !char.IsPunctuation(trueOutput[trueOutput.Length - 1]))
					{
						Console.WriteLine($"Got {trueOutput} but expected {answer}.");
						output = false;
					}
					break;
				}
				case "Sentence_Parsing":
				{
					string trueInput = (string)inputs;
					string[] trueOutputs = (string[])outputs;

					int spaceCount = 0;
					for (int i = 0; i < trueInput.Length; i++) 
						if (trueInput[i] == ' ') spaceCount++;
					
					string[] answerArray = new string[spaceCount + 1];
					string working = string.Empty;
					int arrayIndex = 0;
					for (int i = 0; i < trueInput.Length; i++)
					{
						if (char.IsLetter(trueInput[i])) working += trueInput[i];
						else 
						{
							answerArray[arrayIndex] = working.ToLower();
							arrayIndex++;
							working = string.Empty;
						}
					}

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine(trueOutputs[i]);
						string answer = answerArray[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}
					break;
				}
				#endregion
				#region 04
				case "Pairs":
				{
					int[] trueInputs = (int[])inputs;
					int[][] trueOutputs = (int[][])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine($"{{{trueOutputs[i][0]}, {trueOutputs[i][1]}}}");
						int[] answer = new int[] { trueInputs[i * 2], trueInputs[i * 2 + 1]};

						if (!trueOutputs[i].SequenceEqual(answer))
						{
							Console.WriteLine($"Got {{{trueOutputs[i][0]}, {trueOutputs[i][1]}}} but expected {{{answer[0]}, {answer[1]}}}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length * 2)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length / 2}");
						output = false;
					}
					break;
				}
				case "Multidimensional_Arrays":
				{
					int[][] trueInputs = (int[][])inputs;
					int[,] trueOutputs = (int[,])outputs;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						Console.Write("{ ");
						bool wrong = false;
						for (int j = 0; j < trueInputs[i].Length; j++)
						{
							Console.Write($"{trueOutputs[i, j]}, ");

							if (trueOutputs[i, j] != trueInputs[i][j])
							{
								wrong = true;
							}
						}
						Console.WriteLine("}");

						if (wrong)
						{
							Console.Write("Got { ");
							for (int j = 0; j < trueInputs[i].Length; j++) Console.Write($"{trueOutputs[i, j]}, ");
							Console.Write("}\nbut expected { ");
							for (int j = 0; j < trueInputs[i].Length; j++) Console.Write($"{trueInputs[i][j]}, ");
							Console.WriteLine("}");

							output = false;
						}
					}
					break;
				}
				case "Lists":
				{
					double[] trueInputs = (double[])inputs;
					List<double> trueOutputs = (List<double>)outputs;

					for (int i = 0; i < trueOutputs.Count; i++)
					{
						Console.WriteLine($"{trueOutputs[i]}");
						double answer = trueInputs[i];

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Count)
					{ 
						Console.WriteLine($"Got {trueOutputs.Count} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Count_Twos":
				{
					List<int>[] trueInputs = (List<int>[])inputs;
					int[] trueOutputs = (int[])outputs;

					for (int i = 0; i < trueOutputs.Length; i++)
					{
						Console.WriteLine($"{trueOutputs[i]}");
						int answer = trueInputs[i].Count(x => x == 2);

						if (trueOutputs[i] != answer)
						{
							Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
							output = false;
						}
					}

					if (trueInputs.Length != trueOutputs.Length)
					{ 
						Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
						output = false;
					}
					break;
				}
				case "Tuples":
				{
					if (inputs is (float x, float y, float z)[] trueInputs)
					{
						float[] trueOutputs = (float[])outputs;

						for (int i = 0; i < trueOutputs.Length; i++)
						{
							Console.WriteLine($"{trueOutputs[i]}");
							double answer = trueInputs[i].x * trueInputs[i].y * trueInputs[i].z;

							if (trueOutputs[i] != answer)
							{
								Console.WriteLine($"Got {trueOutputs[i]} but expected {answer}.");
								output = false;
							}
						}

						if (trueInputs.Length != trueOutputs.Length)
						{ 
							Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
							output = false;
						}
					}
					break;
				}
				case "Tuple_Construction":
				{
					List<int>[] trueInputs = (List<int>[])inputs;
					if (outputs is (int avg, int md, int l)[] trueOutputs)
					{
						for (int i = 0; i < trueInputs.Length; i++)
						{
							Console.WriteLine($"({trueOutputs[i].avg}, {trueOutputs[i].md}, {trueOutputs[i].l})");
							int avg = trueInputs[i].Sum() / trueInputs[i].Count;
							
							int[] counts = new int[10];
							foreach (int x in trueInputs[i]) counts[x]++;

							int md = 0;
							for (int j = 0; j < counts.Length; j++) if (counts[j] >= counts[md]) md = j;

							int l = trueInputs[i].Count;

							if (trueOutputs[i].avg != avg || trueOutputs[i].md != md || trueOutputs[i].l != l)
							{
								Console.WriteLine($"Got {trueOutputs[i]} but expected {(avg, md, l)}.");
								output = false;
							}
						}

						if (trueInputs.Length != trueOutputs.Length)
						{ 
							Console.WriteLine($"Got {trueOutputs.Length} outputs but expected {trueInputs.Length}");
							output = false;
						}
					}
					break;
				}
				case "Dictionary":
				{
					string[] trueInputs = (string[])inputs;
					Dictionary<string, int> trueOutputs = (Dictionary<string, int>)outputs;

					for (int i = 0; i < trueInputs.Length; i++)
					{
						if (trueOutputs.ContainsKey(trueInputs[i]))
						{
							int answer = trueInputs[i].Count(x => "aeiouy".Contains(x));
							if (trueOutputs[trueInputs[i]] != answer)
							{
								Console.WriteLine($"Got {trueOutputs[trueInputs[i]]} but expected {answer}.");
								output = false;
							}
						}
						else
						{
							Console.WriteLine($"Dictionary does not contain key {trueInputs[i]}.");
							output = false;
						}
					}
					break;
				}
				case "Word_Length":
				{
					if (inputs is (string a, string b)[] trueInputs)
					{
						Dictionary<string, int> trueOutputs = (Dictionary<string, int>)outputs;

						Dictionary<string, int> answerDictionary = new Dictionary<string, int>();

						for (int i = 0; i < trueInputs.Length; i++)
						{
							string longer = trueInputs[i].a.Length >= trueInputs[i].b.Length ? trueInputs[i].a : trueInputs[i].b;

							foreach (string s in from x in longer.Split(new char[] { ' ', '.' }) select x.ToLower())
							{
								if (!string.IsNullOrWhiteSpace(s)) answerDictionary.Add(s, s.Length);
							}
						}

						foreach (var kvp in answerDictionary)
						{
							if (trueOutputs.ContainsKey(kvp.Key))
							{
								if (trueOutputs[kvp.Key] != kvp.Value)
								{
									Console.WriteLine($"Got {trueOutputs[kvp.Key]} but expected {kvp.Value}.");
									output = false;
								}
							}
							else
							{
								Console.WriteLine($"Dictionary does not contain key {kvp.Key}.");
								output = false;
							}
						}
					}
					break;
				}
				#endregion
				default:
					throw new Exception("Invalid lesson name.");
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("An error has occurred.");
			Console.WriteLine(e);
			output = false;
		}

		if (output) Console.WriteLine("All outputs validated successfully.\nAsk your teacher to do a final check on your code before continuing.");
		else Console.WriteLine("It seems an error was found in your outputs.\nPlease try again.");

		Console.WriteLine("====================================================");

		return output;
	}
}