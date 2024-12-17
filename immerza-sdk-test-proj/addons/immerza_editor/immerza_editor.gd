@tool
extends EditorPlugin;

const main_panel = preload("res://addons/immerza_editor/immerza_main_screen.tscn");
const logo = preload("res://addons/immerza_editor/logo_icon.svg");

var main_panel_instance;

func _enter_tree():
	main_panel_instance = main_panel.instantiate();
	
	EditorInterface.get_editor_main_screen().add_child(main_panel_instance);
	
	_make_visible(false);


func _exit_tree():
	if main_panel_instance:
		main_panel_instance.queue_free();


func _has_main_screen():
	return true;


func _make_visible(visible):
	if main_panel_instance:
		main_panel_instance.visible = visible;


func _get_plugin_name():
	return "Immerza Exporter";


func _get_plugin_icon():
	return logo;
