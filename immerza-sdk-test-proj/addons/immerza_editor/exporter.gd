@tool
extends CenterContainer;


func _on_export_button_button_down():
	
	var dependencies = $ImmerzaExport.export_bundle("res://scripts/test.gd");
	for dependency in dependencies:
		print(dependency)
