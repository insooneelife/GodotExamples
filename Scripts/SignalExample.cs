using Godot;
using System;

public class SignalExample : Node
{
    public override void _Ready()
    {
		AddUserSignal("press");
		Connect("press", this, nameof(OnSignal));

		EmitSignal("press", 155.0f);
	}



	private void OnSignal(float someData)
	{
		GD.Print($"OnSignal  {someData}");
	}
}
