@echo off
cls 

REM hop up to the main dir where the .proj file is (hopefully)
cd ..

echo Generating EF DB Context and Model Classes From Database ...

dotnet ef dbcontext scaffold "Server=DESKTOP-1H3H065;Database=JobSearch;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --force --output-dir Models

echo DONE!
