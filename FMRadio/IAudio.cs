using System;
namespace FMRadio
{
	public interface IAudio
	{
		bool Play_Pause(string url);
		bool Stop(bool val);
	}
}
