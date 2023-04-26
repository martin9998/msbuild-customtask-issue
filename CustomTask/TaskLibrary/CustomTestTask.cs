namespace TaskLibrary;

public class CustomTestTask : Microsoft.Build.Utilities.Task
{
  public override bool Execute()
  {
    Console.WriteLine("Hello");
    return true;
  }
}