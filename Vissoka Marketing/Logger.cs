// Vissoka_Marketing.Logger
using System;
using System.IO;

public class Logger
{
	public static string Log;

	public static bool isInitialized;

	public static void AddToLog(string Header, string Value)
	{
		string text = "[" + DateTime.Now.ToString("HH:mm") + "] [" + Header.ToUpper() + "] " + Value;
		if (Log != null)
		{
			Log = Log + "\r\n" + text;
		}
		if (Log == null)
		{
			Log = text;
		}
		Console.WriteLine(text);
	}

	public static void AddWhiteSpace()
	{
		if (Log != null)
		{
			Log += "\r\n";
		}
		Console.WriteLine(" ");
	}

	public static void SetLoggingEvents()
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object obj, UnhandledExceptionEventArgs args)
		{
			AddToLog("Current Domain Error", "Error with App Domain");
			Exception ex = (Exception)args.ExceptionObject;
			AddToLog("Current Domain", "Message : " + ex.Message);
			AddToLog("Current Domain Error", "StackTrace : " + ex.StackTrace);
			AddToLog("Current Domain Error", "Source : " + ex.Source);
			WriteLog();
		};
		AppDomain.CurrentDomain.ProcessExit += delegate
		{
			WriteLog();
		};
		isInitialized = true;
	}

	public static void WriteLog()
	{
		string text = AppDomain.CurrentDomain.BaseDirectory + "\\Vissoka\\CatchError\\";
		string path = text + "Log.log";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (Log != null)
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			File.Create(path).Close();
			File.WriteAllText(path, Log);
		}
	}
}
