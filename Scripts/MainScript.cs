using Godot;
using System;

public class MainScript : Node
{
    public override void _Ready()
    {

	}


}

public static class ScriptResourceExample
{
	public static void CreateScriptResource()
	{
		Resource script = GD.Load("res://Scripts/ScriptableObjects/SampleData.cs");

		Resource resource = new Godot.Resource();

		ulong objId = resource.GetInstanceId();

		// Replaces old C# instance with a new one. Old C# instance is disposed.
		resource.SetScript(script);

		// Get the new C# instance (type is SampleData)
		resource = GD.InstanceFromId(objId) as Resource;

		Error error = ResourceSaver.Save("res://Resources/ScriptableObjects/Data1.tres", resource);
		GD.Print(error);
	}
}
