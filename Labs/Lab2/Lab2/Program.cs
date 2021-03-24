﻿using System;
using IIG.Core.FileWorkingUtils;

namespace Lab2
{
	class Program
	{
		static void Main()
		{
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			const string FULL_PATH_MD = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileMD.md";

			const string FULL_PATH_EXCEL = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileEXCEL.xlsx";

			const string FULL_PATH_XML = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileXML.xml";

			const string FULL_PATH_CSV = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFileCSV.csv";

			FileWorker worker = new(FULL_PATH);

			// Print field (should be FULL_PATH)
			// Console.WriteLine(worker.FilePath);

			/*
			//Tried to change field and failed
			worker.FilePath = "D:/ForStudy/Components-Of-" +
				"Software-Engineering/Labs/Lab2/Lab2/TempFile1.txt";
			*/

			/*
			Console.WriteLine(worker.GetFileName());

			Console.WriteLine(FileWorker.GetFileName(FULL_PATH));
			*/

			/*
			Console.WriteLine(worker.GetFullPath());

			Console.WriteLine(FileWorker.GetFullPath(FULL_PATH));
			*/

			//Console.WriteLine(worker.ReadAll());

			//Console.WriteLine(FileWorker.ReadAll(FULL_PATH));

			//Console.WriteLine(FileWorker.ReadAll(FULL_PATH_MD));
			//Console.WriteLine(FileWorker.ReadAll(FULL_PATH_EXCEL));
			//Console.WriteLine(FileWorker.ReadAll(FULL_PATH_XML));
			Console.WriteLine(FileWorker.ReadAll(FULL_PATH_CSV));
		}
	}
}
