@echo off
SET _input=%~1
SET _input=%_input:~-4%
if not "%_input%" == ".bmd" (
    if not "%_input%" == ".bdl"  (
        "%~dp0SuperBMD.exe" %1 --mat "%~dp0material_presets/simpleshading2.json"
    )
)
if ERRORLEVEL pause