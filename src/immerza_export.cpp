#include "immerza_export.h"

#include "godot_cpp/core/class_db.hpp"
#include "godot_cpp/variant/utility_functions.hpp"
#include "godot_cpp/classes/resource_loader.hpp"

using namespace godot;

void ImmerzaExport::_bind_methods() 
{
    ClassDB::bind_method(D_METHOD("export_bundle", "path"), &ImmerzaExport::export_bundle);
}

ImmerzaExport::ImmerzaExport()
{

}

ImmerzaExport::~ImmerzaExport()
{

}

void ImmerzaExport::_ready()
{
    UtilityFunctions::print("Immerza Exporter Initialized");
}

PackedStringArray ImmerzaExport::export_bundle(String path)
{
    ResourceLoader* res_loader = ResourceLoader::get_singleton();
    return res_loader->get_dependencies(path);
}