#pragma once

#include "godot_cpp/classes/node.hpp"

namespace godot
{
    class ImmerzaExport : public Node
    {
        GDCLASS(ImmerzaExport, Node)

    private:

    protected:
        static void _bind_methods();
    
    public:
        ImmerzaExport();
        ~ImmerzaExport();

        void _ready() override;

        PackedStringArray export_bundle(String path);
    };
}
