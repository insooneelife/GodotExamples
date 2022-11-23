using Godot;
using System;

public class TimerExample : Node
{
    public override void _Ready()
    {
		CallAfterTimeElapsed();
	}


	private async void CallAfterTimeElapsed()
	{
		float time = 1.5f;
		await ToSignal(GetTree().CreateTimer(time), "timeout");

		GD.Print("OnTimeout");
	}
}
