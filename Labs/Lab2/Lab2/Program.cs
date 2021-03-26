using System;
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

			const string FULL_PATH_NO_FILE = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFile.txt";

			const string FULL_PATH_NO_DIR = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\NoDir\NoDirFile.txt";

			const string FULL_PATH_NO_FILE_MD = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFileMD.md";

			const string FULL_PATH_NO_FILE_XML = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFileXML.xml";

			const string FULL_PATH_NO_FILE_CSV = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFileCSV.csv";

			const string FULL_PATH_NO_FILE_XLSX = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFileXLSX.xlsx";

			FileWorker worker = new(FULL_PATH);

			FileWorker workerNoFile = new(FULL_PATH_NO_FILE_XLSX);

			// FileWorker writeNoDir = new(FULL_PATH_NO_DIR);

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

			/*
			Console.WriteLine(worker.ReadAll());

			Console.WriteLine(FileWorker.ReadAll(FULL_PATH));

			Console.WriteLine(FileWorker.ReadAll(FULL_PATH_MD));
			Console.WriteLine(FileWorker.ReadAll(FULL_PATH_EXCEL));
			Console.WriteLine(FileWorker.ReadAll(FULL_PATH_XML));
			Console.WriteLine(FileWorker.ReadAll(FULL_PATH_CSV));
			*/

			/*
			for (int i = 0; i < worker.ReadLines().Length; i++)
			{
				Console.WriteLine(worker.ReadLines()[i]);
			}

			for (int i = 0; i < FileWorker.ReadLines(FULL_PATH).Length; i++)
			{
				Console.WriteLine(FileWorker.ReadLines(FULL_PATH)[i]);
			}

			for (int i = 0; i < FileWorker.ReadLines(FULL_PATH_MD).Length; i++)
			{
				Console.WriteLine(FileWorker.ReadLines(FULL_PATH_MD)[i]);
			}

			for (int i = 0; i < FileWorker.ReadLines(FULL_PATH_EXCEL).Length; i++)
			{
				Console.WriteLine(FileWorker.ReadLines(FULL_PATH_EXCEL)[i]);
			}

			for (int i = 0; i < FileWorker.ReadLines(FULL_PATH_XML).Length; i++)
			{
				Console.WriteLine(FileWorker.ReadLines(FULL_PATH_XML)[i]);
			}

			for (int i = 0; i < FileWorker.ReadLines(FULL_PATH_CSV).Length; i++)
			{
				Console.WriteLine(FileWorker.ReadLines(FULL_PATH_CSV)[i]);
			}
			*/

			/*
			// doesn't work
			// Console.WriteLine(FileWorker.TryWrite("Text from " +
			// "Visual Studio 2"));

			// doesn't work
			// Console.WriteLine(FileWorker.TryWrite("Text from Visual" +
			//	" Studio 2", FULL_PATH_NO_DIR));

			Console.WriteLine(workerNoFile.TryWrite("Text from Visual Studio 2", 0));
			Console.WriteLine(workerNoFile.TryWrite("Text from Visual Studio 2", -1));
			Console.WriteLine(workerNoFile.TryWrite("Text from Visual Studio 2", 10));

			Console.WriteLine(FileWorker.TryWrite("Text from" +
				" Visual Studio 2", FULL_PATH_NO_FILE, 0));
			Console.WriteLine(FileWorker.TryWrite("Text from" +
				" Visual Studio 2", FULL_PATH_NO_FILE, -1));
			Console.WriteLine(FileWorker.TryWrite("Text from" +
				" Visual Studio 2", FULL_PATH_NO_FILE, 10));

			Console.WriteLine(workerNoFile.TryWrite("Text from Visual Studio XLSX"));
			*/

			Console.WriteLine(worker.Write("Text from Visual Studio"));
		}
	}
}
