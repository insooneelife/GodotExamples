using Godot;
using System;

public class ButtonExample : Node
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }


	private void _OnPressed()
	{
		GD.Print("btn pressed");
	}
}
