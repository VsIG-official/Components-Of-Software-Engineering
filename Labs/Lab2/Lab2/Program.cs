using IIG.Core.FileWorkingUtils;

namespace Lab2
{
	internal class Program
	{
		private static void Main()
		{
			const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

			const string FULL_PATH_NO_FILE_WRITE_CSV = @"D:\ForStudy\Components-Of-" +
				@"Software-Engineering\Labs\Lab2\Lab2\WriteFileCSV.csv";

			FileWorker worker = new(FULL_PATH);

			FileWorker workerNoFile = new(FULL_PATH_NO_FILE_WRITE_CSV);

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

			/*
			Console.WriteLine(FileWorker.Write("Text from Visual Studio" +
				" Class WRITE CSV", FULL_PATH_NO_FILE_WRITE_CSV));
			*/

			// Console.WriteLine(FileWorker.IsPathValid(FULL_PATH_NO_DIR));

			// Console.WriteLine(FileWorker.MkDir(FULL_PATH_CREATE_DIR));

			/*
			Console.WriteLine(FileWorker.TryCopy(FULL_PATH_COPY_FILE_FROM,
				FULL_PATH_COPY_FILE_TO, true));
			*/
		}
	}
}
