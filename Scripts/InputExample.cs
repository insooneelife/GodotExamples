using Godot;
using System;

public class InputExample : Node
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyEvent &&
			keyEvent.Pressed &&
			keyEvent.Scancode == (int)KeyList.Space)
		{
			GD.Print("pressed");
		}
	}
}
