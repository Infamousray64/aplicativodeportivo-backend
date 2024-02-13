# aplicativodeportivo-backend
## Para compilar
```powershell
dotnet build
```
## Para ejecutar 
```powershell
dotnet run --project .\AplicativoDeportivoWeb\AplicativoDeportivoWeb.csproj
```
## Agregar migraciòn
```Powershell
dotnet ef --startup-project .\AplicativoDeportivoWeb\ migrations add MuscleTable 


```
Para agregar migraciones a futuro, cambiar nombre de migracion.
## Aplicar migracion
```powershell
dotnet ef --startup-project .\AplicativoDeportivoWeb\ database update


```
aplicar migracion
