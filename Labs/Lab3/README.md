1. ��������� dotnet pack -c Release � ����� GoGameLibrary
2. mkdir C:\LocalNuGetRepo
3. �������� ��������� .nupkg ���� � �� �����.
4. dotnet nuget add source C:\LocalNuGetRepo --name LocalNuGetRepo
5. dotnet nuget push "MDubovyk1.1.0.0.nupkg" -s LocalNuGetRepo

