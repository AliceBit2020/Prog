namespace Prog.Services
{
	public interface IMyLogger
	{


	    Task WriteLogAsync(string log);
	    void WriteLog(string log);
	}
}
