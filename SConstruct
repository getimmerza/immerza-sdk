#!/usr/bin/env python
import os
import sys

env = SConscript("godot-cpp/SConstruct")
# For reference:
# - CCFLAGS are compilation flags shared between C and C++
# - CFLAGS are for C-specific compilation flags
# - CXXFLAGS are for C++-specific compilation flags
# - CPPFLAGS are for pre-processor flags
# - CPPDEFINES are for pre-processor defines
# - LINKFLAGS are for linking flags

# tweak this if you want to use different folders, or more folders, to store your source code in.
env.Append(CPPPATH=["src/"])
sources = Glob("src/*.cpp")
sources = [str(src) for src in sources]

if env["platform"] == "macos":
    library = env.SharedLibrary(
        "immerza-sdk-test-proj/addons/immerza-sdk/bin/immerza-sdk.{}.{}.framework/immerza-sdk.{}.{}".format(
            env["platform"], env["target"], env["platform"], env["target"]
        ),
        source=sources,
    )
elif env["platform"] == "ios":
    if env["ios_simulator"]:
        library = env.StaticLibrary(
            "immerza-sdk-test-proj/addons/immerza-sdk/bin/immerza-sdk.{}.{}.simulator.a".format(env["platform"], env["target"]),
            source=sources,
        )
    else:
        library = env.StaticLibrary(
            "immerza-sdk-test-proj/addons/immerza-sdk/bin/immerza-sdk.{}.{}.a".format(env["platform"], env["target"]),
            source=sources,
        )
else:
    library = env.SharedLibrary(
        "immerza-sdk-test-proj/addons/immerza-sdk/bin/immerza-sdk{}{}".format(env["suffix"], env["SHLIBSUFFIX"]),
        source=sources,
    )

Default(library)
