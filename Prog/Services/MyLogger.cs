namespace Prog.Services
{
	public class MyLogger:IMyLogger
	{
		public string LogFilePath { get; set; }= "AppData/log.txt";
		public async Task WriteLogAsync(string log)
		{
			StreamWriter sw=new StreamWriter(LogFilePath,true);
			await sw.WriteLineAsync(log);
			await sw.WriteLineAsync();	

			sw.Close();

		}
		public void WriteLog(string log)
		{
			StreamWriter sw = new StreamWriter(LogFilePath, true);
		    sw.WriteLine(log);
			sw.WriteLine();

			sw.Close();

		}
	}
}
