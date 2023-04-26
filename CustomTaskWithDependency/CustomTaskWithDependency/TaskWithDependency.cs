using SomeProject;

namespace CustomTaskWithDependency;

public class TaskWithDependency : Microsoft.Build.Utilities.Task {

  public override bool Execute() {
    HelloWorld.Print("Some Random Name!");
    return true;
  }
}
