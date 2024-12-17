#pragma once

#include "godot_cpp/classes/sprite2d.hpp"

namespace godot
{
    class ImmerzaRoot : public Sprite2D
    {
        GDCLASS(ImmerzaRoot, Sprite2D)

    private:
        double time_passed;

    protected:
        static void _bind_methods();
    
    public:
        ImmerzaRoot();
        ~ImmerzaRoot();

        void _process(double delta) override;
    };
}
