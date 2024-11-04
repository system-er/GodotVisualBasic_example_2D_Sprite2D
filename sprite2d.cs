using Godot;
using System;
using vblibrary;

public partial class sprite2d : Sprite2D
{
    Class1 vbclass = new Class1();
    
	// Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		vbclass._Ready(this);	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		vbclass._Process(delta);
	}
}
