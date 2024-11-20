1. Виконайте dotnet pack -c Release з папки GoGameLibrary
2. mkdir C:\LocalNuGetRepo
3. Скопіюйте створений .nupkg файл у цю папку.
4. dotnet nuget add source C:\LocalNuGetRepo --name LocalNuGetRepo
5. dotnet nuget push "MDubovyk1.1.0.0.nupkg" -s LocalNuGetRepo

