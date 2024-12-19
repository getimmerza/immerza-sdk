extends Node3D

@export var svg_test : Texture2D;

func _ready():
	$Sprite3D.texture = svg_test;

func _process(delta):
	$OmniLight3D.position = (Vector3(sin(Time.get_ticks_msec() * 0.005), 0.0, cos(Time.get_ticks_msec() * 0.005)));
	
