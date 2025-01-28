extends Control

var line_series;

func _ready() -> void:
	EventBus.add_data_to_graph.connect(add_data);
	line_series = LineSeries.new(Color.SEA_GREEN, 2.0);
	$Graph2D.add_series(line_series);
	
	
func add_data(x : float, y : float) -> void:
	line_series.add_point(x, y);
