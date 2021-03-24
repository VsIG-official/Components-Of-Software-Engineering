using System;
using IIG.Core.FileWorkingUtils;

namespace Lab2
{
	class Program
	{
		static void Main()
		{
			FileWorker worker = new("D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile.txt");

			Console.WriteLine(worker.FilePath);

			/*
			//Tried to change field and failed
			worker.FilePath = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile1.txt";
			*/
		}
	}
}
