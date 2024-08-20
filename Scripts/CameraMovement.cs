using Godot;
using System;

public partial class CameraMovement : Camera2D
{
	[Export]
	public int Speed = 300;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += Input.GetVector("Left", "Right", "Up", "Down").Normalized() * Speed * (float)delta;
	}
}
