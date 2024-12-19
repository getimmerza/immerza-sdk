@tool
extends CenterContainer;


func _on_export_button_button_down():
	print("sdaifn")
	var dependencies = get_dependencies("res://main.tscn");
	
	for dependency in dependencies:
		print(dependency)


func get_dependencies(scene_path: String) -> PackedStringArray:
	return ResourceLoader.get_dependencies(scene_path);
